namespace Phonebook
{
    partial class Settings
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
            this.chooseFile = new System.Windows.Forms.Label();
            this.textChooseFile = new System.Windows.Forms.TextBox();
            this.select = new System.Windows.Forms.Button();
            this.checkStart = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.selectStartWindows = new System.Windows.Forms.Label();
            this.folderSelect = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // chooseFile
            // 
            this.chooseFile.AutoSize = true;
            this.chooseFile.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chooseFile.Location = new System.Drawing.Point(10, 21);
            this.chooseFile.Name = "chooseFile";
            this.chooseFile.Size = new System.Drawing.Size(203, 16);
            this.chooseFile.TabIndex = 0;
            this.chooseFile.Text = "Choose where save file database";
            // 
            // textChooseFile
            // 
            this.textChooseFile.BackColor = System.Drawing.Color.White;
            this.textChooseFile.Font = new System.Drawing.Font("Book Antiqua", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textChooseFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textChooseFile.Location = new System.Drawing.Point(10, 42);
            this.textChooseFile.Name = "textChooseFile";
            this.textChooseFile.Size = new System.Drawing.Size(262, 21);
            this.textChooseFile.TabIndex = 2;
            // 
            // select
            // 
            this.select.BackColor = System.Drawing.Color.White;
            this.select.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.select.Location = new System.Drawing.Point(278, 36);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(101, 35);
            this.select.TabIndex = 3;
            this.select.Text = "Select";
            this.select.UseVisualStyleBackColor = false;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // checkStart
            // 
            this.checkStart.AutoSize = true;
            this.checkStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.checkStart.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.checkStart.Location = new System.Drawing.Point(10, 123);
            this.checkStart.Name = "checkStart";
            this.checkStart.Size = new System.Drawing.Size(166, 20);
            this.checkStart.TabIndex = 4;
            this.checkStart.Text = "Open program Windows";
            this.checkStart.UseVisualStyleBackColor = false;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.White;
            this.buttonSave.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonSave.Location = new System.Drawing.Point(10, 180);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(101, 31);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.White;
            this.buttonCancel.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonCancel.Location = new System.Drawing.Point(276, 180);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(103, 31);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // selectStartWindows
            // 
            this.selectStartWindows.AutoSize = true;
            this.selectStartWindows.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectStartWindows.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.selectStartWindows.Location = new System.Drawing.Point(10, 104);
            this.selectStartWindows.Name = "selectStartWindows";
            this.selectStartWindows.Size = new System.Drawing.Size(354, 16);
            this.selectStartWindows.TabIndex = 7;
            this.selectStartWindows.Text = "Selection if you start the Phonebook when Windows opens";
            this.selectStartWindows.Click += new System.EventHandler(this.selectStartWindows_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(385, 220);
            this.Controls.Add(this.selectStartWindows);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.checkStart);
            this.Controls.Add(this.select);
            this.Controls.Add(this.textChooseFile);
            this.Controls.Add(this.chooseFile);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(429, 271);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(231, 225);
            this.Name = "Settings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chooseFile;
        private System.Windows.Forms.TextBox textChooseFile;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.CheckBox checkStart;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label selectStartWindows;
        private System.Windows.Forms.FolderBrowserDialog folderSelect;
    }
}