namespace Phonebook
{
    partial class AddContact
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_lastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_office = new System.Windows.Forms.TextBox();
            this.textBox_home = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_mobile = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_web = new System.Windows.Forms.TextBox();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_postalCode = new System.Windows.Forms.TextBox();
            this.textBox_city = new System.Windows.Forms.TextBox();
            this.textBox_note = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.buttonFoto = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.buttonCharge = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.openChargeFoto = new System.Windows.Forms.OpenFileDialog();
            this.label12 = new System.Windows.Forms.Label();
            this.dateBirthay = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(12, 25);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(140, 20);
            this.textBox_name.TabIndex = 1;
            this.textBox_name.TextChanged += new System.EventHandler(this.texBox_name_TextChanged);
            // 
            // textBox_lastName
            // 
            this.textBox_lastName.Location = new System.Drawing.Point(202, 25);
            this.textBox_lastName.Name = "textBox_lastName";
            this.textBox_lastName.Size = new System.Drawing.Size(140, 20);
            this.textBox_lastName.TabIndex = 3;
            this.textBox_lastName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Office Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Home Phone";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox_office
            // 
            this.textBox_office.Location = new System.Drawing.Point(202, 74);
            this.textBox_office.Name = "textBox_office";
            this.textBox_office.Size = new System.Drawing.Size(140, 20);
            this.textBox_office.TabIndex = 7;
            // 
            // textBox_home
            // 
            this.textBox_home.Location = new System.Drawing.Point(12, 74);
            this.textBox_home.Name = "textBox_home";
            this.textBox_home.Size = new System.Drawing.Size(140, 20);
            this.textBox_home.TabIndex = 5;
            this.textBox_home.TextChanged += new System.EventHandler(this.textBox_home_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mobile Phone";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(202, 122);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(140, 20);
            this.textBox_email.TabIndex = 11;
            // 
            // textBox_mobile
            // 
            this.textBox_mobile.Location = new System.Drawing.Point(12, 122);
            this.textBox_mobile.Name = "textBox_mobile";
            this.textBox_mobile.Size = new System.Drawing.Size(140, 20);
            this.textBox_mobile.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Website";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBox_web
            // 
            this.textBox_web.Location = new System.Drawing.Point(12, 171);
            this.textBox_web.Name = "textBox_web";
            this.textBox_web.Size = new System.Drawing.Size(140, 20);
            this.textBox_web.TabIndex = 13;
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(12, 219);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(330, 20);
            this.textBox_address.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(199, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Postal Code";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "City";
            // 
            // textBox_postalCode
            // 
            this.textBox_postalCode.Location = new System.Drawing.Point(202, 258);
            this.textBox_postalCode.Name = "textBox_postalCode";
            this.textBox_postalCode.Size = new System.Drawing.Size(140, 20);
            this.textBox_postalCode.TabIndex = 21;
            // 
            // textBox_city
            // 
            this.textBox_city.Location = new System.Drawing.Point(12, 258);
            this.textBox_city.Name = "textBox_city";
            this.textBox_city.Size = new System.Drawing.Size(140, 20);
            this.textBox_city.TabIndex = 19;
            // 
            // textBox_note
            // 
            this.textBox_note.Location = new System.Drawing.Point(12, 298);
            this.textBox_note.Multiline = true;
            this.textBox_note.Name = "textBox_note";
            this.textBox_note.Size = new System.Drawing.Size(330, 75);
            this.textBox_note.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 281);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Note";
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(93, 396);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 25;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(12, 396);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 24;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // buttonFoto
            // 
            this.buttonFoto.Location = new System.Drawing.Point(233, 396);
            this.buttonFoto.Name = "buttonFoto";
            this.buttonFoto.Size = new System.Drawing.Size(109, 23);
            this.buttonFoto.TabIndex = 26;
            this.buttonFoto.Text = "View Foto >>";
            this.buttonFoto.UseVisualStyleBackColor = true;
            this.buttonFoto.Click += new System.EventHandler(this.buttonFoto_Click);
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.picture.BackgroundImage = global::Phonebook.Properties.Resources.DefaultFoto;
            this.picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture.ErrorImage = null;
            this.picture.Location = new System.Drawing.Point(361, 74);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(200, 200);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picture.TabIndex = 27;
            this.picture.TabStop = false;
            this.picture.Click += new System.EventHandler(this.picture_Click);
            // 
            // buttonCharge
            // 
            this.buttonCharge.Location = new System.Drawing.Point(361, 296);
            this.buttonCharge.Name = "buttonCharge";
            this.buttonCharge.Size = new System.Drawing.Size(60, 23);
            this.buttonCharge.TabIndex = 27;
            this.buttonCharge.Text = "Charge";
            this.buttonCharge.UseVisualStyleBackColor = true;
            this.buttonCharge.Click += new System.EventHandler(this.buttonCharge_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(506, 296);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(55, 23);
            this.buttonRemove.TabIndex = 28;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // openChargeFoto
            // 
            this.openChargeFoto.DefaultExt = "jpg";
            this.openChargeFoto.FileName = "Charge Foto";
            this.openChargeFoto.Filter = "File Jpg|*.jpg|File Png|*.png";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(202, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Birhtday";
            // 
            // dateBirthay
            // 
            this.dateBirthay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBirthay.Location = new System.Drawing.Point(202, 171);
            this.dateBirthay.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dateBirthay.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateBirthay.Name = "dateBirthay";
            this.dateBirthay.Size = new System.Drawing.Size(140, 20);
            this.dateBirthay.TabIndex = 15;
            this.dateBirthay.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // AddContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 428);
            this.Controls.Add(this.dateBirthay);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonCharge);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.buttonFoto);
            this.Controls.Add(this.textBox_lastName);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.textBox_note);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_postalCode);
            this.Controls.Add(this.textBox_city);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_web);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_mobile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_office);
            this.Controls.Add(this.textBox_home);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(800, 471);
            this.MinimizeBox = false;
            this.Name = "AddContact";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddContact";
            this.Load += new System.EventHandler(this.AddContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_lastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_office;
        private System.Windows.Forms.TextBox textBox_home;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_mobile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_web;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_postalCode;
        private System.Windows.Forms.TextBox textBox_city;
        private System.Windows.Forms.TextBox textBox_note;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button buttonFoto;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button buttonCharge;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.OpenFileDialog openChargeFoto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateBirthay;
    }
}