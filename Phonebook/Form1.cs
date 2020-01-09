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

        #region Creat, charge and add new contact from bottons
        private void ChargeNewContact()//Charge new contact
        {
            statusContact.Text = "Contacts: " + Variable.CounterNumberElement().ToString();

            table_phonebook.Rows.Clear();

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
                };

                table_phonebook.Rows.Add(newElement);
            }
        }

        private void CloseNewContact(object sender, FormClosingEventArgs e)// Add contact
        {
            ChargeNewContact();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = Variable.nameSaftware + " " + Variable.verisonSoftware;
            ChargeNewContact();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)// Add new contact from Icon 
        {
            AddContact addContact = new AddContact();

            addContact.FormClosing += new FormClosingEventHandler(CloseNewContact);

            addContact.EditContact = 0;

            addContact.ShowDialog();
        }
        private void menu_addNewContact_Click(object sender, EventArgs e) // Add new contact from menu(up) Edit
        {
            toolStripButton1_Click(sender, new EventArgs());
        }
        #endregion

        #region Remove Contact from bottons
        private void botton_remove_Click(object sender, EventArgs e) // Remove contact from Icon
        {
            string idContact = table_phonebook.Rows[table_phonebook.CurrentCell.RowIndex].Cells[0].Value.ToString();

            string nameAndLastrName = table_phonebook.Rows[table_phonebook.CurrentCell.RowIndex].Cells[1].Value.ToString() + " "
                + table_phonebook.Rows[table_phonebook.CurrentCell.RowIndex].Cells[2].Value.ToString();

            DialogResult userChoice = MessageBox.Show("Are you sure to cancel " + nameAndLastrName + "?", "Delete contact", MessageBoxButtons.YesNo);

            if (userChoice == DialogResult.Yes)
            {
                try
                {
                    File.Delete(Variable.variableDatabase + idContact + ".xml");
                    File.Delete(Variable.variableDatabasePicture + idContact + ".jpg");
                }
                catch (Exception message)
                {
                    MessageBox.Show(message.Message, "Cannot delete the file");
                }

                MessageBox.Show("Contact deleted");

                ChargeNewContact();
            }
        }

        private void menu_removeContact_Click(object sender, EventArgs e) // Remove contact from menu(up) Edit
        {
            botton_remove_Click(sender, new EventArgs());
        }
        #endregion

        #region Edit contacts
        private void botton_edit_Click(object sender, EventArgs e) // Edit from Icon 
        {
            AddContact addContact = new AddContact();

            addContact.FormClosing += new FormClosingEventHandler(CloseNewContact);

            addContact.IdContact = table_phonebook.Rows[table_phonebook.CurrentCell.RowIndex].Cells[0].Value.ToString();
            addContact.Name = table_phonebook.Rows[table_phonebook.CurrentCell.RowIndex].Cells[1].Value.ToString();
            addContact.LastName = table_phonebook.Rows[table_phonebook.CurrentCell.RowIndex].Cells[2].Value.ToString();
            addContact.HomePhone = table_phonebook.Rows[table_phonebook.CurrentCell.RowIndex].Cells[3].Value.ToString();
            addContact.OfficePhone = table_phonebook.Rows[table_phonebook.CurrentCell.RowIndex].Cells[4].Value.ToString();
            addContact.MobilePhone = table_phonebook.Rows[table_phonebook.CurrentCell.RowIndex].Cells[5].Value.ToString();
            addContact.Email = table_phonebook.Rows[table_phonebook.CurrentCell.RowIndex].Cells[6].Value.ToString();
            addContact.Website = table_phonebook.Rows[table_phonebook.CurrentCell.RowIndex].Cells[7].Value.ToString();
            addContact.Address = table_phonebook.Rows[table_phonebook.CurrentCell.RowIndex].Cells[8].Value.ToString();
            addContact.City = table_phonebook.Rows[table_phonebook.CurrentCell.RowIndex].Cells[9].Value.ToString();
            addContact.PostalCode = table_phonebook.Rows[table_phonebook.CurrentCell.RowIndex].Cells[10].Value.ToString();
            addContact.Birthday = table_phonebook.Rows[table_phonebook.CurrentCell.RowIndex].Cells[11].Value.ToString();
            addContact.Note = table_phonebook.Rows[table_phonebook.CurrentCell.RowIndex].Cells[12].Value.ToString();
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

            table_phonebook.Rows.Clear();

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
                    table_phonebook.Rows.Add(newElement);
                }
                statusContact.Text = "Contacts: " + Variable.CounterNumberElement().ToString()
                    + "(Filtered: " + table_phonebook.Rows.Count + ")";
            }
        }

        private void toolSearch_Click(object sender, EventArgs e) //Botton Search
        {
            if (toolTextSearch.Text.Length >= 1)
            {
                SearchContacts(toolTextSearch.Text);

                if (table_phonebook.Rows.Count == 0)
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
                    table_phonebook.CurrentCell = table_phonebook.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    table_phonebook.Rows[e.RowIndex].Selected = true;
                    table_phonebook.Focus();

                    //Veiw Context Menu
                    table_phonebook.ContextMenuStrip = contextMenu;
                    Point positionContextMenu = new Point(MousePosition.X, MousePosition.Y);
                    table_phonebook.ContextMenuStrip.Show(positionContextMenu);
                    table_phonebook.ContextMenuStrip = null;
                }
                else
                {
                    table_phonebook.ContextMenuStrip = null;
                }
            }
        }

        private void menuRightSendEmail_Click(object sender, EventArgs e)
        {
            string sendEmail = table_phonebook.SelectedRows[0].Cells[6].Value.ToString();

            if (sendEmail.Length > 0)
            {
                Process.Start("mailto:" + sendEmail);
            }
        }

        private void menuRightWeb_Click(object sender, EventArgs e)
        {
            string website = table_phonebook.SelectedRows[0].Cells[7].Value.ToString();

            if (website.Length > 0)
            {
                Process.Start(website);
            }
        }

        private void menuZodiac_Click(object sender, EventArgs e)
        {
            string dateBirth = table_phonebook.SelectedRows[0].Cells[11].Value.ToString();

            if (dateBirth.Length > 0)
            {
                string name = table_phonebook.SelectedRows[0].Cells[1].Value.ToString();
                string lastName = table_phonebook.SelectedRows[0].Cells[2].Value.ToString();
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
            string dateBirth = table_phonebook.SelectedRows[0].Cells[11].Value.ToString();

            if (dateBirth.Length > 0)
            {
                string name = table_phonebook.SelectedRows[0].Cells[1].Value.ToString();
                string lastName = table_phonebook.SelectedRows[0].Cells[2].Value.ToString();
                string age = Variable.CalcoleteAge(dateBirth);
                string birthday = table_phonebook.SelectedRows[0].Cells[11].Value.ToString();

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


    }
}
