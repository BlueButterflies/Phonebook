using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Web;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace Phonebook
{
    public partial class AddContact : Form
    {
        public string IdContact { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string HomePhone { get; set; }
        public string OfficePhone { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Birthday { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Note { get; set; }
        public int EditContact { get; set; }

        public AddContact()
        {
            InitializeComponent();
        }

        #region Control for correct entry
        private void button_add_Click(object sender, EventArgs e)
        {


            // Control Name and Last Name which contains letters and spaces
            if (textBox_name.Text.Length < 2)
            {
                MessageBox.Show("Name cannot contain less than 2 characters");
                return;
            }

            if (Regex.IsMatch(textBox_name.Text, @"^[a-zA-Z ]+$") == false)
            {
                MessageBox.Show("The field Name contains invalid characters");
                return;
            }

            if (textBox_lastName.Text.Length > 0 == true)
            {
                if (Regex.IsMatch(textBox_lastName.Text, @"^[a-zA-Z' ]+$") == false)
                {
                    MessageBox.Show("The field Last Name contains invalid characters");
                    return;
                }
            }

            //Control Phones for valid characters
            if (textBox_home.Text.Length > 0)
            {
                if (Regex.IsMatch(textBox_home.Text, @"^[0-9()+ ]+$") == false)
                {
                    MessageBox.Show("The field Home Phone contains invalid characters");
                    return;
                }
            }
            if (textBox_mobile.Text.Length > 0)
            {
                if (Regex.IsMatch(textBox_mobile.Text, @"^[0-9()+ ]+$") == false)
                {
                    MessageBox.Show("The field Mobile Phone contains invalid characters");
                    return;
                }
            }
            if (textBox_office.Text.Length > 0)
            {
                if (Regex.IsMatch(textBox_office.Text, @"^[0-9()+ ]+$") == false)
                {
                    MessageBox.Show("The field Office Phone contains invalid characters");
                    return;
                }
            }

            // Control valid Email Address
            if (textBox_email.Text.Length > 0)
            {
                string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" +
                    @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" +
                    @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

                Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);

                if (regex.IsMatch(textBox_email.Text) == false)
                {
                    MessageBox.Show("Invalid email");
                }

                //Or use this code for validation email

                /* int emailCounter = 0;

                 try
                 {
                     MailAddress mailAddress = new MailAddress(textBox_email.Text);
                 }
                 catch (Exception)
                 {

                     emailCounter = 0;
                 }

                 if (emailCounter == 0)
                 {
                     MessageBox.Show("Invalid email");
                 }
                 */
            }

            // Control valid Website
            if (textBox_web.Text.Length > 0)
            {

                if (Uri.IsWellFormedUriString(textBox_web.Text, UriKind.Absolute) == false)
                {
                    MessageBox.Show("Invalid Website");
                    return;
                }

                //Or use this verification
                //string pattern = @"^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)?
                //                 [a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$";

                //if (Regex.IsMatch(textBox_web.Text, pattern) == false)
                //{
                //    MessageBox.Show("Invalid Website");
                //    return;
                //}
            }

            int idCounter;

            if (EditContact == 1)
            {
                idCounter = Convert.ToInt32(IdContact);
            }
            else
            {
                //Control Id
                idCounter = 1;

                while (File.Exists(Variable.variableDatabase + idCounter + ".xml") == true)
                {
                    idCounter++;
                }
            }

            //Creates File and Incert Date
            string currentDate = dateBirthay.Text;

            if (currentDate == "01/01/1900")
            {
                currentDate = " ";
            }
            //else
            //{
            //    currentDate = ;
            //}

            XDocument documentContact = new XDocument
                (
                new XElement("contact",

                new XElement("name", textBox_name.Text),
                new XElement("lastName", textBox_lastName.Text),
                new XElement("homePhone", textBox_home.Text),
                new XElement("officePhone", textBox_office.Text),
                new XElement("mobilePhone", textBox_mobile.Text),
                new XElement("email", textBox_email.Text),
                new XElement("website", textBox_web.Text),
                new XElement("birthday", currentDate),
                new XElement("address", textBox_address.Text),
                new XElement("city", textBox_city.Text),
                new XElement("postalCode", textBox_postalCode.Text),
                new XElement("note", textBox_note.Text),
                new XElement("picture", Variable.variableDatabasePicture + idCounter + ".jpg")
                ));


            Variable.ControlRouteDatabase();

            documentContact.Save(Variable.variableDatabase + idCounter + ".xml");

            if (picture.Tag != null)
            {
                File.Copy(picture.Tag.ToString(), Variable.variableDatabasePicture + idCounter + ".jpg");
            }

            this.Close();

        }
        #endregion

        #region Check if window has been opened for new contact or to change the contact
        private void AddContact_Load(object sender, EventArgs e)
        {
            //Reset width Form.AddContact
            this.Width = 371;

            if (EditContact == 1)
            {
                this.Text = "Edit Contact";
                button_add.Text = "Save";
            }
            else
            {
                this.Text = "Add Contact";
                button_add.Text = "Add";
            }

            textBox_name.Text = Name;
            textBox_lastName.Text = LastName;
            textBox_home.Text = HomePhone;
            textBox_office.Text = OfficePhone;
            textBox_mobile.Text = MobilePhone;
            textBox_email.Text = Email;
            textBox_web.Text = Website;
            textBox_address.Text = Address;
            textBox_city.Text = City;
            textBox_postalCode.Text = PostalCode;
            textBox_note.Text = Note;
        }
        #endregion

        #region Botton for Picture
        private void buttonFoto_Click(object sender, EventArgs e)
        {
            if (this.Width == 371)
            {
                this.Width = 590;

                buttonFoto.Text = "<< Reduce";
            }
            else
            {
                this.Width = 371;

                buttonFoto.Text = "View Foto >>";
            }
        }
        #endregion

        #region Charge and Remove Picture
        private void buttonRemove_Click(object sender, EventArgs e) // Remove Picture
        {
            picture.BackgroundImage = Properties.Resources.DefaultFoto;
            picture.Tag = null;
        }

        private void buttonCharge_Click(object sender, EventArgs e) //Charge Picture
        {
            openChargeFoto.ShowDialog();

            try
            {
                if (openChargeFoto.FileName != null)
                {
                    Image imageProfil = Image.FromFile(openChargeFoto.FileName);

                    picture.BackgroundImage = imageProfil;
                    picture.Tag = openChargeFoto.FileName;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void texBox_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox_home_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateBirthDay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void picture_Click(object sender, EventArgs e)
        {

        }
    }
}
