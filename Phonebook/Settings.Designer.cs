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
            this.SuspendLayout();
            // 
            // chooseFile
            // 
            this.chooseFile.AutoSize = true;
            this.chooseFile.Location = new System.Drawing.Point(9, 9);
            this.chooseFile.Name = "chooseFile";
            this.chooseFile.Size = new System.Drawing.Size(164, 13);
            this.chooseFile.TabIndex = 0;
            this.chooseFile.Text = "Choose where save file database";
            // 
            // textChooseFile
            // 
            this.textChooseFile.Location = new System.Drawing.Point(12, 31);
            this.textChooseFile.Name = "textChooseFile";
            this.textChooseFile.Size = new System.Drawing.Size(194, 20);
            this.textChooseFile.TabIndex = 2;
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(212, 29);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(75, 23);
            this.select.TabIndex = 3;
            this.select.Text = "Select";
            this.select.UseVisualStyleBackColor = true;
            // 
            // checkStart
            // 
            this.checkStart.AutoSize = true;
            this.checkStart.Location = new System.Drawing.Point(12, 107);
            this.checkStart.Name = "checkStart";
            this.checkStart.Size = new System.Drawing.Size(140, 17);
            this.checkStart.TabIndex = 4;
            this.checkStart.Text = "Open program Windows";
            this.checkStart.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 160);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(212, 160);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // selectStartWindows
            // 
            this.selectStartWindows.AutoSize = true;
            this.selectStartWindows.Location = new System.Drawing.Point(9, 80);
            this.selectStartWindows.Name = "selectStartWindows";
            this.selectStartWindows.Size = new System.Drawing.Size(286, 13);
            this.selectStartWindows.TabIndex = 7;
            this.selectStartWindows.Text = "Selection if you start the Phonebook when Windows opens";
            this.selectStartWindows.Click += new System.EventHandler(this.selectStartWindows_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 191);
            this.Controls.Add(this.selectStartWindows);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.checkStart);
            this.Controls.Add(this.select);
            this.Controls.Add(this.textChooseFile);
            this.Controls.Add(this.chooseFile);
            this.MaximumSize = new System.Drawing.Size(320, 230);
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "Settings";
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
    }
}