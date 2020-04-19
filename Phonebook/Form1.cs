using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Diagnostics;

namespace Phonebook
{
    public partial class phonebookForm : Form
    {
        public phonebookForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = Variable.nameSoftware + " " + Variable.verisonSoftware;

            ChargeDataBase();

            //Charge Notification
            Notifications notifications = new Notifications();
            notifications.Show();
        }

        #region Creat, charge contacts, charge database and add new contact from bottons
        private void ChargeNewContact()//Charge new contact
        {
            statusContact.Text = "Contacts: " + Variable.CounterNumberElement().ToString();

            statusContact.Tag = Variable.CounterNumberElement().ToString();

            Variable.phonebookActive = Variable.variableDatabase;

            tablePhonebook.Rows.Clear();

            string[] elements = new string[Variable.CounterNumberElement()];
            elements = Variable.ChargeItems();

            for (int i = 0; i < elements.Length; i++)
            {
                XmlDocument document = new XmlDocument();
                document.Load(elements[i].ToString());


                string idContacts = Path.GetFileNameWithoutExtension(elements[i]);

                XmlNode nodeName = document.DocumentElement.SelectSingleNode("/contact/name");
                XmlNode nodeLastName = document.DocumentElement.SelectSingleNode("/contact/lastName");
                XmlNode nodeHome = document.DocumentElement.SelectSingleNode("/contact/homePhone");
                XmlNode nodeOffice = document.DocumentElement.SelectSingleNode("/contact/officePhone");
                XmlNode nodeMobile = document.DocumentElement.SelectSingleNode("/contact/mobilePhone");
                XmlNode nodeEmail = document.DocumentElement.SelectSingleNode("/contact/email");
                XmlNode nodeWeb = document.DocumentElement.SelectSingleNode("/contact/website");
                XmlNode nodeAddress = document.DocumentElement.SelectSingleNode("/contact/address");
                XmlNode nodeCity = document.DocumentElement.SelectSingleNode("/contact/city");
                XmlNode nodePostalCode = document.DocumentElement.SelectSingleNode("/contact/postalCode");
                XmlNode nodeBirthday = document.DocumentElement.SelectSingleNode("/contact/birthday");
                XmlNode nodeNote = document.DocumentElement.SelectSingleNode("/contact/note");
                XmlNode nodePicture = document.DocumentElement.SelectSingleNode("/contact/picture");

                string picture = "";

                if (nodePicture == null)
                {
                    picture = "";
                }
                else
                {
                    picture = nodePicture.InnerText;
                }

                string[] newElement =
                {
                    idContacts,
                    nodeName.InnerText,
                    nodeLastName.InnerText,
                    nodeHome.InnerText,
                    nodeOffice.InnerText,
                    nodeMobile.InnerText,
                    nodeEmail.InnerText,
                    nodeWeb.InnerText,
                    nodeAddress.InnerText,
                    nodeCity.InnerText,
                    nodePostalCode.InnerText,
                    nodeBirthday.InnerText,
                    nodeNote.InnerText,
                    picture
                };

                tablePhonebook.Rows.Add(newElement);
            }
        }

        private void CloseNewContact(object sender, FormClosingEventArgs e)// Add contact
        {
            ChargeNewContact();

            if (tablePhonebook.Rows.Count > 0)
            {
                botton_edit.Enabled = true;
                botton_remove.Enabled = true;
                menu_editContact.Enabled = true;
                menuRemoveContact.Enabled = true;
            }
        }

        private void ChargeDataBase()// Charge database
        {
            Variable.ControlDatabaseUser();
            Variable.ControlRouteDatabase();

            ChargeNewContact();

            if (tablePhonebook.Rows.Count > 0)
            {
                botton_edit.Enabled = true;
                botton_remove.Enabled = true;
                menu_editContact.Enabled = true;
                menuRemoveContact.Enabled = true;
            }

            this.Text = Variable.nameSoftware + " " + Variable.verisonSoftware + " - " + Variable.phonebookActive;
        }



        private void botton_add_Click(object sender, EventArgs e)// Add new contact from Icon 
        {
            AddContact addContact = new AddContact();

            addContact.FormClosing += new FormClosingEventHandler(CloseNewContact);

            addContact.EditContact = 0;

            addContact.ShowDialog();
        }
        private void menu_addNewContact_Click(object sender, EventArgs e) // Add new contact from menu(up) Edit
        {
            botton_add_Click(sender, new EventArgs());
        }
        #endregion

        #region Remove Contact from bottons
        private void botton_remove_Click(object sender, EventArgs e) // Remove contact from Icon
        {
            if (tablePhonebook.Rows.Count == 0)
            {
                MessageBox.Show("There are no contacts present  for delete.");
                return;
            }

            string idContact = tablePhonebook.Rows[tablePhonebook.CurrentCell.RowIndex].Cells[0].Value.ToString();

            string nameAndLastrName = tablePhonebook.Rows[tablePhonebook.CurrentCell.RowIndex].Cells[1].Value.ToString() + " "
                + tablePhonebook.Rows[tablePhonebook.CurrentCell.RowIndex].Cells[2].Value.ToString();

            DialogResult userChoice = MessageBox.Show("Are you sure to cancel " + nameAndLastrName + "?", "Delete contact", MessageBoxButtons.YesNo);

            if (userChoice == DialogResult.Yes)
            {
                try
                {
                    File.Delete(Variable.variableDatabase + idContact + ".xml");

                    if (File.Exists(Variable.variableDatabasePicture + idContact + ".jpg"))
                    {
                        File.Delete(Variable.variableDatabasePicture + idContact + ".jpg");
                    }

                    if (File.Exists(Variable.variableDatabasePicture + idContact + ".png"))
                    {
                        File.Delete(Variable.variableDatabasePicture + idContact + ".png");
                    }

                }
                catch (Exception message)
                {
                    MessageBox.Show(message.Message, "Cannot delete the file");
                }

                MessageBox.Show("Contact deleted");

                ChargeNewContact();

                if (tablePhonebook.Rows.Count == 0)
                {
                    botton_edit.Enabled = false;
                    botton_remove.Enabled = false;
                    menu_editContact.Enabled = false;
                    menuRemoveContact.Enabled = false;
                }
            }
        }
        private void menuRemoveContact_Click(object sender, EventArgs e)
        {
            botton_remove_Click(sender, new EventArgs());
        }
        #endregion

        #region Edit contacts
        private void botton_edit_Click(object sender, EventArgs e) // Edit from Icon 
        {
            if (tablePhonebook.Rows.Count == 0)
            {
                MessageBox.Show("There are no contacts present  for edit.");
                return;
            }

            AddContact addContact = new AddContact();

            addContact.FormClosing += new FormClosingEventHandler(CloseNewContact);

            addContact.IdContact = tablePhonebook.Rows[tablePhonebook.CurrentCell.RowIndex].Cells[0].Value.ToString();

            addContact.Name = tablePhonebook.Rows[tablePhonebook.CurrentCell.RowIndex].Cells[1].Value.ToString();
            addContact.LastName = tablePhonebook.Rows[tablePhonebook.CurrentCell.RowIndex].Cells[2].Value.ToString();
            addContact.HomePhone = tablePhonebook.Rows[tablePhonebook.CurrentCell.RowIndex].Cells[3].Value.ToString();
            addContact.OfficePhone = tablePhonebook.Rows[tablePhonebook.CurrentCell.RowIndex].Cells[4].Value.ToString();
            addContact.MobilePhone = tablePhonebook.Rows[tablePhonebook.CurrentCell.RowIndex].Cells[5].Value.ToString();
            addContact.Email = tablePhonebook.Rows[tablePhonebook.CurrentCell.RowIndex].Cells[6].Value.ToString();
            addContact.Website = tablePhonebook.Rows[tablePhonebook.CurrentCell.RowIndex].Cells[7].Value.ToString();
            addContact.Address = tablePhonebook.Rows[tablePhonebook.CurrentCell.RowIndex].Cells[8].Value.ToString();
            addContact.City = tablePhonebook.Rows[tablePhonebook.CurrentCell.RowIndex].Cells[9].Value.ToString();
            addContact.PostalCode = tablePhonebook.Rows[tablePhonebook.CurrentCell.RowIndex].Cells[10].Value.ToString();
            addContact.Birthday = tablePhonebook.Rows[tablePhonebook.CurrentCell.RowIndex].Cells[11].Value.ToString();
            addContact.Note = tablePhonebook.Rows[tablePhonebook.CurrentCell.RowIndex].Cells[12].Value.ToString();
            addContact.PictureProfil = tablePhonebook.Rows[tablePhonebook.CurrentCell.RowIndex].Cells[13].Value.ToString();

            addContact.EditContact = 1;

            addContact.ShowDialog();
        }

        private void menu_editContact_Click(object sender, EventArgs e)// Edit from menu Edit
        {
            botton_edit_Click(sender, e);
        }

        private void table_phonebook_CellDoubleClick(object sender, DataGridViewCellEventArgs e)// Edit contact with double click from any cell
        {
            if (e.RowIndex != -1)
            {
                botton_edit_Click(sender, e);
            }
        }
        #endregion

        #region Search contacts
        private void SearchContacts(string textSearch)
        {
            statusContact.Text = "Contacts: " + Variable.CounterNumberElement().ToString();

            tablePhonebook.Rows.Clear();

            string[] elements = new string[Variable.CounterNumberElement()];
            elements = Variable.ChargeItems();

            for (int i = 0; i < elements.Length; i++)
            {
                XmlDocument document = new XmlDocument();
                document.Load(elements[i]);

                string idContacts = Path.GetFileNameWithoutExtension(elements[i]);

                XmlNode nodeName = document.DocumentElement.SelectSingleNode("/contact/name");
                XmlNode nodeLastName = document.DocumentElement.SelectSingleNode("/contact/lastName");
                XmlNode nodeHome = document.DocumentElement.SelectSingleNode("/contact/homePhone");
                XmlNode nodeOffice = document.DocumentElement.SelectSingleNode("/contact/officePhone");
                XmlNode nodeMobile = document.DocumentElement.SelectSingleNode("/contact/mobilePhone");
                XmlNode nodeEmail = document.DocumentElement.SelectSingleNode("/contact/email");
                XmlNode nodeWeb = document.DocumentElement.SelectSingleNode("/contact/website");
                XmlNode nodeAddress = document.DocumentElement.SelectSingleNode("/contact/address");
                XmlNode nodeCity = document.DocumentElement.SelectSingleNode("/contact/city");
                XmlNode nodePostalCode = document.DocumentElement.SelectSingleNode("/contact/postalCode");
                XmlNode nodeNote = document.DocumentElement.SelectSingleNode("/contact/note");

                string[] newElement =
                {
                    idContacts,
                    nodeName.InnerText.ToLower(),
                    nodeLastName.InnerText.ToLower(),
                    nodeHome.InnerText,
                    nodeOffice.InnerText,
                    nodeMobile.InnerText,
                    nodeEmail.InnerText.ToLower(),
                    nodeWeb.InnerText.ToLower(),
                    nodeAddress.InnerText.ToLower(),
                    nodeCity.InnerText.ToLower(),
                    nodePostalCode.InnerText,
                    nodeNote.InnerText.ToLower()
                };

                string[] elemntsSearch = newElement;

                if (elemntsSearch.Contains(textSearch.ToLower()))
                {
                    tablePhonebook.Rows.Add(newElement);
                }
                statusContact.Text = "Contacts: " + Variable.CounterNumberElement().ToString()
                    + "(Filtered: " + tablePhonebook.Rows.Count + ")";
            }
        }

        private void toolSearch_Click(object sender, EventArgs e) //Botton Search
        {
            if (toolTextSearch.Text.Length >= 1)
            {
                SearchContacts(toolTextSearch.Text);

                if (tablePhonebook.Rows.Count == 0)
                {
                    MessageBox.Show("No contacts were found");
                    ChargeNewContact();
                }
            }
            else
            {
                ChargeNewContact();
            }
        }
        #endregion

        #region Context Menu botton right - mouse 
        private void table_phonebook_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    //Selected Cell Position
                    tablePhonebook.CurrentCell = tablePhonebook.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    tablePhonebook.Rows[e.RowIndex].Selected = true;
                    tablePhonebook.Focus();

                    //Veiw Context Menu
                    tablePhonebook.ContextMenuStrip = contextMenu;
                    Point positionContextMenu = new Point(MousePosition.X, MousePosition.Y);
                    tablePhonebook.ContextMenuStrip.Show(positionContextMenu);
                    tablePhonebook.ContextMenuStrip = null;
                }
                else
                {
                    tablePhonebook.ContextMenuStrip = null;
                }
            }
        }

        private void menuRightSendEmail_Click(object sender, EventArgs e)
        {
            string sendEmail = tablePhonebook.SelectedRows[0].Cells[6].Value.ToString();

            if (sendEmail.Length > 0)
            {
                Process.Start("mailto:" + sendEmail);
            }
        }

        private void menuRightWeb_Click(object sender, EventArgs e)
        {
            string website = tablePhonebook.SelectedRows[0].Cells[7].Value.ToString();

            if (website.Length > 0)
            {
                Process.Start(website);
            }
        }

        private void menuZodiac_Click(object sender, EventArgs e)
        {
            string dateBirth = tablePhonebook.SelectedRows[0].Cells[11].Value.ToString();

            if (dateBirth.Length > 0)
            {
                string name = tablePhonebook.SelectedRows[0].Cells[1].Value.ToString();
                string lastName = tablePhonebook.SelectedRows[0].Cells[2].Value.ToString();
                string zodiacSign = Variable.ZodiacSign(dateBirth);

                string message = string.Format($"Zodiac Sing of {name} {lastName} is {zodiacSign}.");

                MessageBox.Show(message);
            }
            else
            {
                MessageBox.Show("The contact has no date of birth.");
            }
        }

        private void viewAgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dateBirth = tablePhonebook.SelectedRows[0].Cells[11].Value.ToString();

            if (dateBirth.Length > 0)
            {
                string name = tablePhonebook.SelectedRows[0].Cells[1].Value.ToString();
                string lastName = tablePhonebook.SelectedRows[0].Cells[2].Value.ToString();
                string age = Variable.CalcoleteAge(dateBirth);
                string birthday = tablePhonebook.SelectedRows[0].Cells[11].Value.ToString();

                string message = string.Format($"{name} {lastName} is {age} years old and born on {birthday}");
                MessageBox.Show(message);
            }
        }
        #endregion

        #region For menu File-Exit
        private void menu_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Menu File Export All Contacts
        private void exportAllContacts_Click(object sender, EventArgs e)
        {
            saveExpoContactHtml.ShowDialog();

            try
            {
                if (saveExpoContactHtml.FileName != null)
                {
                    string htmlFile = GetHtmlFile();

                    File.WriteAllText(saveExpoContactHtml.FileName, htmlFile);
                    Process.Start(saveExpoContactHtml.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string GetHtmlFile()
        {
            string resultOfHtml = "<html>\n"
            + "<head>\n"
            + "<link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css\" integrity=\"sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm\" crossorigin=\"anonymous\">\n"
            + "<script src=\"https://code.jquery.com/jquery-3.4.1.slim.min.js\" integrity=\"sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN\" crossorigin=\"anonymous\"></script>\n"
            + "<script src=\"https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js\" integrity=\"sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q\" crossorigin=\"anonymous\"></script>\n"
            + "<script src=\"https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js\" integrity=\"sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl\" crossorigin=\"anonymous\"></script>\n"
            + "<style>\n"
            + ".container-fluid {\n"
            + "padding-left: 2px\n"
            + "padding-right: 2px;}\n"
            + "</style>\n"
            + "<title>Phonebook</title>\n"
            + "</head>\n"
            + "<body class=\"bg-secondary\">\n"
            + "<div class=\"jumbotron jumbotron-fluid bg-dark text-white\">\n"
            + "<div class=\"container-fluid\">\n"
            + "<h1 class=\"display-4\">Phonebook</h1>\n"
            + "</div>\n"
            + "</div>\n"
            + "<div class=\"container-fluid\">\n"
            + "<table class=\"table table-striped table-dark table-hover\" width=\"100%\">\n"
            + "<thead class=\"thead-dark\">\n"
            + "<tr>\n"
            + "<th scope=\"col\">#</th>\n"
            + "<th scope=\"col\">Name</th>\n"
            + "<th scope=\"col\">LastName</th>\n"
            + "<th scope=\"col\">Phone Number</th>\n"
            + "<th scope=\"col\">Mobile</th>\n"
            + "<th scope=\"col\">Office Phone</th>\n"
            + "<th scope=\"col\">Email</th>\n"
            + "<th scope=\"col\">Website</th>\n"
            + "<th scope=\"col\">Address</th>\n"
            + "<th scope=\"col\">City</th>\n"
            + "<th scope=\"col\">Postal Code</th>\n"
            + "<th scope=\"col\">Birthday</th>\n"
            + "<th scope=\"col\">Note</th>\n"
            + "</tr>\n"
            + "</thead>\n"
            + "<tbody>\n";

            int coutnContacts = 1;

            for (int i = 0; i < tablePhonebook.RowCount - 1; i++)
            {
                resultOfHtml += "<tr>\n"
                    + "<th scope=\"row\">" + coutnContacts + "</th>\n"
                    + "<td>" + tablePhonebook.Rows[i].Cells[2].Value.ToString() + "</td>\n"
                    + "<td>" + tablePhonebook.Rows[i].Cells[3].Value.ToString() + "</td>\n"
                    + "<td>" + tablePhonebook.Rows[i].Cells[4].Value.ToString() + "</td>\n"
                    + "<td>" + tablePhonebook.Rows[i].Cells[5].Value.ToString() + "</td>\n"
                    + "<td>" + tablePhonebook.Rows[i].Cells[6].Value.ToString() + "</td>\n"
                    + "<td>" + tablePhonebook.Rows[i].Cells[7].Value.ToString() + "</td>\n"
                    + "<td>" + tablePhonebook.Rows[i].Cells[8].Value.ToString() + "</td>\n"
                    + "<td>" + tablePhonebook.Rows[i].Cells[9].Value.ToString() + "</td>\n"
                    + "<td>" + tablePhonebook.Rows[i].Cells[10].Value.ToString() + "</td>\n"
                    + "<td>" + tablePhonebook.Rows[i].Cells[11].Value.ToString() + "</td>\n"
                    + "<td>" + tablePhonebook.Rows[i].Cells[12].Value.ToString() + "</td>\n"
                    + "<td>" + tablePhonebook.Rows[i].Cells[13].Value.ToString() + "</td>\n"
                    + "<\tr>\n";

                coutnContacts++;
            }

            resultOfHtml += "</tbody>\n"
                + "<tfoor>\n"
                + "<tr>\n"
                + "<td colspan=\"5\"> All Contacts: " + statusContact.Tag.ToString() + "</td>\n"
                + "</tr>\n"
                + "</tfoor>\n"
                + "</table>\n"
                + "<p class=\"text-withe\">Html generated from " + Variable.nameSoftware + " " + Variable.verisonSoftware + "</p>\n"
                  + "</div>\n"
                + "</body>\n"
                + "</html>\n";
            return resultOfHtml;
        }
        #endregion

        #region Menu ? Send Feedback
        private void toolSendFeedback_Click(object sender, EventArgs e)
        {
            FeedbackForm feedback = new FeedbackForm();

            feedback.ShowDialog();
        }
        #endregion

        #region From File - Settings
        private void menuSettings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();

            settings.FormClosing += new FormClosingEventHandler(ClosingFormSetting);

            settings.ShowDialog();

        }

        private void ClosingFormSetting(object sender, FormClosingEventArgs e)
        {
            Variable.ControlDatabaseUser();

            if (Variable.phonebookActive != Variable.variableDatabase)
            {
                ChargeDataBase();
            }
        }
        #endregion

        private void table_phonebook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void table_phonebook_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void menu_tool_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuExport_Click(object sender, EventArgs e)
        {

        }

        private void toolTextSearch_Click(object sender, EventArgs e)
        {

        }


    }
}
