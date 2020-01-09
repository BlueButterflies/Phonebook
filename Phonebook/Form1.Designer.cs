namespace Phonebook
{
    partial class phonebookForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_tool_file = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_tool_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_addNewContact = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_editContact = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_removeContact = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siteWebToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_tool = new System.Windows.Forms.ToolStrip();
            this.botton_add = new System.Windows.Forms.ToolStripButton();
            this.botton_edit = new System.Windows.Forms.ToolStripButton();
            this.botton_remove = new System.Windows.Forms.ToolStripButton();
            this.toolSearch = new System.Windows.Forms.ToolStripButton();
            this.toolTextSearch = new System.Windows.Forms.ToolStripTextBox();
            this.table_phonebook = new System.Windows.Forms.DataGridView();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuRightSendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRightWeb = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusContact = new System.Windows.Forms.ToolStripStatusLabel();
            this.openPictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuZodiac = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColOfficePhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSiteWeb = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.menu_tool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_phonebook)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_tool_file,
            this.menu_tool_edit,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(640, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Menu";
            // 
            // menu_tool_file
            // 
            this.menu_tool_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_exit});
            this.menu_tool_file.Name = "menu_tool_file";
            this.menu_tool_file.Size = new System.Drawing.Size(37, 20);
            this.menu_tool_file.Text = "File";
            // 
            // menu_exit
            // 
            this.menu_exit.Name = "menu_exit";
            this.menu_exit.Size = new System.Drawing.Size(180, 22);
            this.menu_exit.Text = "Exit";
            this.menu_exit.Click += new System.EventHandler(this.menu_exit_Click);
            // 
            // menu_tool_edit
            // 
            this.menu_tool_edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_addNewContact,
            this.menu_editContact,
            this.menu_removeContact});
            this.menu_tool_edit.Name = "menu_tool_edit";
            this.menu_tool_edit.Size = new System.Drawing.Size(39, 20);
            this.menu_tool_edit.Text = "Edit";
            // 
            // menu_addNewContact
            // 
            this.menu_addNewContact.Name = "menu_addNewContact";
            this.menu_addNewContact.Size = new System.Drawing.Size(168, 22);
            this.menu_addNewContact.Text = "Add New Contact";
            this.menu_addNewContact.Click += new System.EventHandler(this.menu_addNewContact_Click);
            // 
            // menu_editContact
            // 
            this.menu_editContact.Name = "menu_editContact";
            this.menu_editContact.Size = new System.Drawing.Size(168, 22);
            this.menu_editContact.Text = "Edit Contact";
            this.menu_editContact.Click += new System.EventHandler(this.menu_editContact_Click);
            // 
            // menu_removeContact
            // 
            this.menu_removeContact.Name = "menu_removeContact";
            this.menu_removeContact.Size = new System.Drawing.Size(168, 22);
            this.menu_removeContact.Text = "Remove Contact";
            this.menu_removeContact.Click += new System.EventHandler(this.menu_removeContact_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.siteWebToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem2.Text = "?";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // siteWebToolStripMenuItem
            // 
            this.siteWebToolStripMenuItem.Name = "siteWebToolStripMenuItem";
            this.siteWebToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.siteWebToolStripMenuItem.Text = "Site Web";
            // 
            // menu_tool
            // 
            this.menu_tool.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.menu_tool.BackColor = System.Drawing.SystemColors.Control;
            this.menu_tool.GripMargin = new System.Windows.Forms.Padding(4);
            this.menu_tool.ImageScalingSize = new System.Drawing.Size(33, 33);
            this.menu_tool.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menu_tool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.botton_add,
            this.botton_edit,
            this.botton_remove,
            this.toolSearch,
            this.toolTextSearch});
            this.menu_tool.Location = new System.Drawing.Point(0, 24);
            this.menu_tool.Name = "menu_tool";
            this.menu_tool.Size = new System.Drawing.Size(640, 58);
            this.menu_tool.TabIndex = 1;
            this.menu_tool.Text = "Menu";
            this.menu_tool.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menu_tool_ItemClicked);
            // 
            // botton_add
            // 
            this.botton_add.BackColor = System.Drawing.SystemColors.Control;
            this.botton_add.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.botton_add.Image = global::Phonebook.Properties.Resources.AddNew;
            this.botton_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botton_add.Margin = new System.Windows.Forms.Padding(3);
            this.botton_add.Name = "botton_add";
            this.botton_add.Size = new System.Drawing.Size(60, 52);
            this.botton_add.Text = "Add New";
            this.botton_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.botton_add.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // botton_edit
            // 
            this.botton_edit.BackColor = System.Drawing.SystemColors.Control;
            this.botton_edit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.botton_edit.Image = global::Phonebook.Properties.Resources.Edit;
            this.botton_edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botton_edit.Name = "botton_edit";
            this.botton_edit.Size = new System.Drawing.Size(37, 55);
            this.botton_edit.Text = "Edit";
            this.botton_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.botton_edit.Click += new System.EventHandler(this.botton_edit_Click);
            // 
            // botton_remove
            // 
            this.botton_remove.BackColor = System.Drawing.SystemColors.Control;
            this.botton_remove.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.botton_remove.Image = global::Phonebook.Properties.Resources.Delete;
            this.botton_remove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botton_remove.Margin = new System.Windows.Forms.Padding(0, 1, 0, 3);
            this.botton_remove.Name = "botton_remove";
            this.botton_remove.Size = new System.Drawing.Size(54, 54);
            this.botton_remove.Text = "Remove";
            this.botton_remove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.botton_remove.Click += new System.EventHandler(this.botton_remove_Click);
            // 
            // toolSearch
            // 
            this.toolSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.toolSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolSearch.BackColor = System.Drawing.SystemColors.Control;
            this.toolSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.toolSearch.Image = global::Phonebook.Properties.Resources.Search;
            this.toolSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSearch.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.toolSearch.Name = "toolSearch";
            this.toolSearch.RightToLeftAutoMirrorImage = true;
            this.toolSearch.Size = new System.Drawing.Size(37, 57);
            this.toolSearch.Text = " ";
            this.toolSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolSearch.ToolTipText = " Search";
            this.toolSearch.Click += new System.EventHandler(this.toolSearch_Click);
            // 
            // toolTextSearch
            // 
            this.toolTextSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolTextSearch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolTextSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolTextSearch.ForeColor = System.Drawing.SystemColors.Highlight;
            this.toolTextSearch.Name = "toolTextSearch";
            this.toolTextSearch.Size = new System.Drawing.Size(100, 58);
            // 
            // table_phonebook
            // 
            this.table_phonebook.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.table_phonebook.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.table_phonebook.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.table_phonebook.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.table_phonebook.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_phonebook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.table_phonebook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_phonebook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColName,
            this.ColLastName,
            this.ColPhoneNumber,
            this.ColMobile,
            this.ColOfficePhone,
            this.ColEmail,
            this.ColSiteWeb,
            this.ColAddress,
            this.ColCity,
            this.ColPostalCode,
            this.ColBirthday,
            this.ColNote});
            this.table_phonebook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_phonebook.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.table_phonebook.GridColor = System.Drawing.SystemColors.HotTrack;
            this.table_phonebook.Location = new System.Drawing.Point(0, 82);
            this.table_phonebook.MultiSelect = false;
            this.table_phonebook.Name = "table_phonebook";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_phonebook.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.table_phonebook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table_phonebook.Size = new System.Drawing.Size(640, 253);
            this.table_phonebook.TabIndex = 3;
            this.table_phonebook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_phonebook_CellContentClick);
            this.table_phonebook.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_phonebook_CellDoubleClick);
            this.table_phonebook.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.table_phonebook_CellMouseClick);
            this.table_phonebook.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.table_phonebook_CellMouseDoubleClick);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRightSendEmail,
            this.menuRightWeb,
            this.openPictureToolStripMenuItem,
            this.menuZodiac,
            this.viewAgeToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(200, 136);
            this.contextMenu.Text = "Menu Context";
            // 
            // menuRightSendEmail
            // 
            this.menuRightSendEmail.Name = "menuRightSendEmail";
            this.menuRightSendEmail.Size = new System.Drawing.Size(199, 22);
            this.menuRightSendEmail.Text = "Send Email";
            this.menuRightSendEmail.Click += new System.EventHandler(this.menuRightSendEmail_Click);
            // 
            // menuRightWeb
            // 
            this.menuRightWeb.Name = "menuRightWeb";
            this.menuRightWeb.Size = new System.Drawing.Size(199, 22);
            this.menuRightWeb.Text = "Go to Website";
            this.menuRightWeb.Click += new System.EventHandler(this.menuRightWeb_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusContact});
            this.statusStrip1.Location = new System.Drawing.Point(0, 335);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(640, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusContact
            // 
            this.statusContact.BackColor = System.Drawing.SystemColors.MenuBar;
            this.statusContact.ForeColor = System.Drawing.SystemColors.Highlight;
            this.statusContact.Name = "statusContact";
            this.statusContact.Size = new System.Drawing.Size(69, 17);
            this.statusContact.Text = "Contacts:  0";
            // 
            // openPictureToolStripMenuItem
            // 
            this.openPictureToolStripMenuItem.Name = "openPictureToolStripMenuItem";
            this.openPictureToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.openPictureToolStripMenuItem.Text = "Open Picture";
            // 
            // menuZodiac
            // 
            this.menuZodiac.Name = "menuZodiac";
            this.menuZodiac.Size = new System.Drawing.Size(199, 22);
            this.menuZodiac.Text = "Calculation Zodiac Sign";
            this.menuZodiac.Click += new System.EventHandler(this.menuZodiac_Click);
            // 
            // viewAgeToolStripMenuItem
            // 
            this.viewAgeToolStripMenuItem.Name = "viewAgeToolStripMenuItem";
            this.viewAgeToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.viewAgeToolStripMenuItem.Text = "View Age";
            this.viewAgeToolStripMenuItem.Click += new System.EventHandler(this.viewAgeToolStripMenuItem_Click);
            // 
            // ColID
            // 
            this.ColID.HeaderText = "ID";
            this.ColID.Name = "ColID";
            this.ColID.Width = 43;
            // 
            // ColName
            // 
            this.ColName.HeaderText = "Name";
            this.ColName.Name = "ColName";
            this.ColName.Width = 60;
            // 
            // ColLastName
            // 
            this.ColLastName.HeaderText = "Last Name";
            this.ColLastName.Name = "ColLastName";
            // 
            // ColPhoneNumber
            // 
            this.ColPhoneNumber.HeaderText = "Phone Number";
            this.ColPhoneNumber.Name = "ColPhoneNumber";
            // 
            // ColMobile
            // 
            this.ColMobile.HeaderText = "Mobile ";
            this.ColMobile.Name = "ColMobile";
            // 
            // ColOfficePhone
            // 
            this.ColOfficePhone.HeaderText = "Office Phone";
            this.ColOfficePhone.Name = "ColOfficePhone";
            // 
            // ColEmail
            // 
            this.ColEmail.HeaderText = "Email";
            this.ColEmail.Name = "ColEmail";
            // 
            // ColSiteWeb
            // 
            this.ColSiteWeb.HeaderText = "Website";
            this.ColSiteWeb.Name = "ColSiteWeb";
            this.ColSiteWeb.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColSiteWeb.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColAddress
            // 
            this.ColAddress.HeaderText = "Address";
            this.ColAddress.Name = "ColAddress";
            // 
            // ColCity
            // 
            this.ColCity.HeaderText = "City";
            this.ColCity.Name = "ColCity";
            // 
            // ColPostalCode
            // 
            this.ColPostalCode.HeaderText = "Postal Code";
            this.ColPostalCode.Name = "ColPostalCode";
            // 
            // ColBirthday
            // 
            this.ColBirthday.HeaderText = "Birthday";
            this.ColBirthday.Name = "ColBirthday";
            // 
            // ColNote
            // 
            this.ColNote.HeaderText = "Note";
            this.ColNote.Name = "ColNote";
            // 
            // phonebookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(640, 357);
            this.Controls.Add(this.table_phonebook);
            this.Controls.Add(this.menu_tool);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(900, 900);
            this.MinimumSize = new System.Drawing.Size(660, 400);
            this.Name = "phonebookForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Phonebook";
            this.TransparencyKey = System.Drawing.Color.Navy;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menu_tool.ResumeLayout(false);
            this.menu_tool.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_phonebook)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip menu_tool;
        private System.Windows.Forms.DataGridView table_phonebook;
        private System.Windows.Forms.ToolStripMenuItem menu_tool_file;
        private System.Windows.Forms.ToolStripMenuItem menu_tool_edit;
        private System.Windows.Forms.ToolStripButton botton_add;
        private System.Windows.Forms.ToolStripButton botton_edit;
        private System.Windows.Forms.ToolStripButton botton_remove;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menu_exit;
        private System.Windows.Forms.ToolStripMenuItem menu_addNewContact;
        private System.Windows.Forms.ToolStripMenuItem menu_editContact;
        private System.Windows.Forms.ToolStripMenuItem menu_removeContact;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siteWebToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusContact;
        public System.Windows.Forms.ToolStripButton toolSearch;
        internal System.Windows.Forms.ToolStripTextBox toolTextSearch;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem menuRightSendEmail;
        private System.Windows.Forms.ToolStripMenuItem menuRightWeb;
        private System.Windows.Forms.ToolStripMenuItem openPictureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuZodiac;
        private System.Windows.Forms.ToolStripMenuItem viewAgeToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColOfficePhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmail;
        private System.Windows.Forms.DataGridViewLinkColumn ColSiteWeb;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNote;
    }
}

