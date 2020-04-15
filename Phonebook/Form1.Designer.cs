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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(phonebookForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_tool_file = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExport = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAllContacts = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_tool_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_addNewContact = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_editContact = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_removeContact = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSendFeedback = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_tool = new System.Windows.Forms.ToolStrip();
            this.botton_add = new System.Windows.Forms.ToolStripButton();
            this.botton_edit = new System.Windows.Forms.ToolStripButton();
            this.botton_remove = new System.Windows.Forms.ToolStripButton();
            this.toolSearch = new System.Windows.Forms.ToolStripButton();
            this.toolTextSearch = new System.Windows.Forms.ToolStripTextBox();
            this.table_phonebook = new System.Windows.Forms.DataGridView();
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
            this.ColPicture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuRightSendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRightWeb = new System.Windows.Forms.ToolStripMenuItem();
            this.openPictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuZodiac = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusContact = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveExpoContactHtml = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.menu_tool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_phonebook)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_tool_file,
            this.menu_tool_edit,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(747, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Menu";
            // 
            // menu_tool_file
            // 
            this.menu_tool_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExport,
            this.toolStripSeparator1,
            this.menuSettings,
            this.toolStripSeparator2,
            this.menu_exit});
            this.menu_tool_file.Font = new System.Drawing.Font("Segoe Print", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_tool_file.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.menu_tool_file.Name = "menu_tool_file";
            this.menu_tool_file.Size = new System.Drawing.Size(41, 25);
            this.menu_tool_file.Text = "File";
            // 
            // menuExport
            // 
            this.menuExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportAllContacts});
            this.menuExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.menuExport.Name = "menuExport";
            this.menuExport.Size = new System.Drawing.Size(129, 26);
            this.menuExport.Text = "Export";
            this.menuExport.Click += new System.EventHandler(this.menuExport_Click);
            // 
            // exportAllContacts
            // 
            this.exportAllContacts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.exportAllContacts.Name = "exportAllContacts";
            this.exportAllContacts.Size = new System.Drawing.Size(153, 26);
            this.exportAllContacts.Text = "All Contacts";
            this.exportAllContacts.Click += new System.EventHandler(this.exportAllContacts_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(126, 6);
            // 
            // menuSettings
            // 
            this.menuSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.menuSettings.Name = "menuSettings";
            this.menuSettings.Size = new System.Drawing.Size(129, 26);
            this.menuSettings.Text = "Settings";
            this.menuSettings.Click += new System.EventHandler(this.menuSettings_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(126, 6);
            // 
            // menu_exit
            // 
            this.menu_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.menu_exit.Name = "menu_exit";
            this.menu_exit.Size = new System.Drawing.Size(129, 26);
            this.menu_exit.Text = "Exit";
            this.menu_exit.Click += new System.EventHandler(this.menu_exit_Click);
            // 
            // menu_tool_edit
            // 
            this.menu_tool_edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_addNewContact,
            this.menu_editContact,
            this.menu_removeContact});
            this.menu_tool_edit.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_tool_edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.menu_tool_edit.Name = "menu_tool_edit";
            this.menu_tool_edit.Size = new System.Drawing.Size(47, 25);
            this.menu_tool_edit.Text = "Edit";
            // 
            // menu_addNewContact
            // 
            this.menu_addNewContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.menu_addNewContact.Name = "menu_addNewContact";
            this.menu_addNewContact.Size = new System.Drawing.Size(190, 26);
            this.menu_addNewContact.Text = "Add New Contact";
            this.menu_addNewContact.Click += new System.EventHandler(this.menu_addNewContact_Click);
            // 
            // menu_editContact
            // 
            this.menu_editContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.menu_editContact.Name = "menu_editContact";
            this.menu_editContact.Size = new System.Drawing.Size(190, 26);
            this.menu_editContact.Text = "Edit Contact";
            this.menu_editContact.Click += new System.EventHandler(this.menu_editContact_Click);
            // 
            // menu_removeContact
            // 
            this.menu_removeContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.menu_removeContact.Name = "menu_removeContact";
            this.menu_removeContact.Size = new System.Drawing.Size(190, 26);
            this.menu_removeContact.Text = "Remove Contact";
            this.menu_removeContact.Click += new System.EventHandler(this.menu_removeContact_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.toolSendFeedback});
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(28, 25);
            this.toolStripMenuItem2.Text = "?";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // toolSendFeedback
            // 
            this.toolSendFeedback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.toolSendFeedback.Name = "toolSendFeedback";
            this.toolSendFeedback.Size = new System.Drawing.Size(169, 26);
            this.toolSendFeedback.Text = "Send Feedback";
            this.toolSendFeedback.Click += new System.EventHandler(this.toolSendFeedback_Click);
            // 
            // menu_tool
            // 
            this.menu_tool.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.menu_tool.BackColor = System.Drawing.Color.White;
            this.menu_tool.GripMargin = new System.Windows.Forms.Padding(4);
            this.menu_tool.ImageScalingSize = new System.Drawing.Size(33, 33);
            this.menu_tool.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menu_tool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.botton_add,
            this.botton_edit,
            this.botton_remove,
            this.toolSearch,
            this.toolTextSearch});
            this.menu_tool.Location = new System.Drawing.Point(0, 29);
            this.menu_tool.Name = "menu_tool";
            this.menu_tool.Size = new System.Drawing.Size(747, 64);
            this.menu_tool.TabIndex = 1;
            this.menu_tool.Text = "Menu";
            this.menu_tool.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menu_tool_ItemClicked);
            // 
            // botton_add
            // 
            this.botton_add.BackColor = System.Drawing.Color.White;
            this.botton_add.Font = new System.Drawing.Font("Segoe Print", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botton_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.botton_add.Image = ((System.Drawing.Image)(resources.GetObject("botton_add.Image")));
            this.botton_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botton_add.Margin = new System.Windows.Forms.Padding(3);
            this.botton_add.Name = "botton_add";
            this.botton_add.Size = new System.Drawing.Size(71, 58);
            this.botton_add.Text = "Add New";
            this.botton_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.botton_add.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // botton_edit
            // 
            this.botton_edit.BackColor = System.Drawing.Color.White;
            this.botton_edit.Font = new System.Drawing.Font("Segoe Print", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botton_edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.botton_edit.Image = ((System.Drawing.Image)(resources.GetObject("botton_edit.Image")));
            this.botton_edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botton_edit.Name = "botton_edit";
            this.botton_edit.Size = new System.Drawing.Size(39, 61);
            this.botton_edit.Text = "Edit";
            this.botton_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.botton_edit.Click += new System.EventHandler(this.botton_edit_Click);
            // 
            // botton_remove
            // 
            this.botton_remove.BackColor = System.Drawing.Color.White;
            this.botton_remove.Font = new System.Drawing.Font("Segoe Print", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botton_remove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.botton_remove.Image = ((System.Drawing.Image)(resources.GetObject("botton_remove.Image")));
            this.botton_remove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botton_remove.Margin = new System.Windows.Forms.Padding(0, 1, 0, 3);
            this.botton_remove.Name = "botton_remove";
            this.botton_remove.Size = new System.Drawing.Size(61, 60);
            this.botton_remove.Text = "Remove";
            this.botton_remove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.botton_remove.Click += new System.EventHandler(this.botton_remove_Click);
            // 
            // toolSearch
            // 
            this.toolSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.toolSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolSearch.BackColor = System.Drawing.Color.White;
            this.toolSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.toolSearch.Image = ((System.Drawing.Image)(resources.GetObject("toolSearch.Image")));
            this.toolSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSearch.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.toolSearch.Name = "toolSearch";
            this.toolSearch.RightToLeftAutoMirrorImage = true;
            this.toolSearch.Size = new System.Drawing.Size(37, 63);
            this.toolSearch.Text = " ";
            this.toolSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolSearch.ToolTipText = " Search";
            this.toolSearch.Click += new System.EventHandler(this.toolSearch_Click);
            // 
            // toolTextSearch
            // 
            this.toolTextSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolTextSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolTextSearch.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTextSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.toolTextSearch.Name = "toolTextSearch";
            this.toolTextSearch.Size = new System.Drawing.Size(100, 64);
            this.toolTextSearch.Click += new System.EventHandler(this.toolTextSearch_Click);
            // 
            // table_phonebook
            // 
            this.table_phonebook.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.table_phonebook.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.table_phonebook.BackgroundColor = System.Drawing.Color.Linen;
            this.table_phonebook.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.table_phonebook.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_phonebook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            this.ColNote,
            this.ColPicture});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe Print", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.table_phonebook.DefaultCellStyle = dataGridViewCellStyle3;
            this.table_phonebook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_phonebook.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.table_phonebook.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.table_phonebook.Location = new System.Drawing.Point(0, 93);
            this.table_phonebook.MultiSelect = false;
            this.table_phonebook.Name = "table_phonebook";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_phonebook.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.table_phonebook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table_phonebook.Size = new System.Drawing.Size(747, 242);
            this.table_phonebook.TabIndex = 3;
            this.table_phonebook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_phonebook_CellContentClick);
            this.table_phonebook.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_phonebook_CellDoubleClick);
            this.table_phonebook.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.table_phonebook_CellMouseClick);
            this.table_phonebook.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.table_phonebook_CellMouseDoubleClick);
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
            // ColPicture
            // 
            this.ColPicture.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColPicture.ContextMenuStrip = this.contextMenu;
            this.ColPicture.HeaderText = "Picture";
            this.ColPicture.MinimumWidth = 100;
            this.ColPicture.Name = "ColPicture";
            this.ColPicture.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColPicture.Visible = false;
            // 
            // contextMenu
            // 
            this.contextMenu.BackColor = System.Drawing.Color.White;
            this.contextMenu.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRightSendEmail,
            this.menuRightWeb,
            this.openPictureToolStripMenuItem,
            this.menuZodiac,
            this.viewAgeToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(222, 134);
            this.contextMenu.Text = "Menu Context";
            // 
            // menuRightSendEmail
            // 
            this.menuRightSendEmail.Name = "menuRightSendEmail";
            this.menuRightSendEmail.Size = new System.Drawing.Size(221, 26);
            this.menuRightSendEmail.Text = "Send Email";
            this.menuRightSendEmail.Click += new System.EventHandler(this.menuRightSendEmail_Click);
            // 
            // menuRightWeb
            // 
            this.menuRightWeb.Name = "menuRightWeb";
            this.menuRightWeb.Size = new System.Drawing.Size(221, 26);
            this.menuRightWeb.Text = "Go to Website";
            this.menuRightWeb.Click += new System.EventHandler(this.menuRightWeb_Click);
            // 
            // openPictureToolStripMenuItem
            // 
            this.openPictureToolStripMenuItem.Name = "openPictureToolStripMenuItem";
            this.openPictureToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.openPictureToolStripMenuItem.Text = "Open Picture";
            // 
            // menuZodiac
            // 
            this.menuZodiac.Name = "menuZodiac";
            this.menuZodiac.Size = new System.Drawing.Size(221, 26);
            this.menuZodiac.Text = "Calculation Zodiac Sign";
            this.menuZodiac.Click += new System.EventHandler(this.menuZodiac_Click);
            // 
            // viewAgeToolStripMenuItem
            // 
            this.viewAgeToolStripMenuItem.Name = "viewAgeToolStripMenuItem";
            this.viewAgeToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.viewAgeToolStripMenuItem.Text = "View Age";
            this.viewAgeToolStripMenuItem.Click += new System.EventHandler(this.viewAgeToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusContact});
            this.statusStrip1.Location = new System.Drawing.Point(0, 335);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(747, 22);
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
            // saveExpoContactHtml
            // 
            this.saveExpoContactHtml.DefaultExt = "html";
            this.saveExpoContactHtml.FileName = "Phonebook";
            this.saveExpoContactHtml.Filter = "File Html|*.html";
            // 
            // phonebookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(747, 357);
            this.Controls.Add(this.table_phonebook);
            this.Controls.Add(this.menu_tool);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1250, 700);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "phonebookForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Phonebook";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
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
        private System.Windows.Forms.ToolStripMenuItem toolSendFeedback;
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
        private System.Windows.Forms.ToolStripMenuItem menuExport;
        private System.Windows.Forms.ToolStripMenuItem exportAllContacts;
        private System.Windows.Forms.SaveFileDialog saveExpoContactHtml;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPicture;
    }
}

