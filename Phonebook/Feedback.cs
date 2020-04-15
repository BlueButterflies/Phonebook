﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phonebook
{
    public partial class FeedbackForm : Form
    {
        public FeedbackForm()
        {
            InitializeComponent();
        }

        #region From Button Send
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(txtEmail.Text);
                mail.To.Add("Dsvk23020818@outlook.it");
                mail.Subject = txtSubject.Text;
                mail.Body = txtMessage.Text;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(txtEmail.Text, txtPass.Text);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);

                MessageBox.Show("Thank you for your Feedback");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
#endregion

        #region From Button Exit
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Mask Password
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked ==  false)
            {
                string a = txtPass.Text;
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }
        #endregion

        private void FeedbackForm_Load(object sender, EventArgs e) 
        {
            checkBox1.Checked =  true;
        }
    }
}
