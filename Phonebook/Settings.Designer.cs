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
            this.chooseFile.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.chooseFile.Location = new System.Drawing.Point(-2, 9);
            this.chooseFile.Name = "chooseFile";
            this.chooseFile.Size = new System.Drawing.Size(184, 19);
            this.chooseFile.TabIndex = 0;
            this.chooseFile.Text = "Choose where save file database";
            // 
            // textChooseFile
            // 
            this.textChooseFile.BackColor = System.Drawing.Color.PapayaWhip;
            this.textChooseFile.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textChooseFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textChooseFile.Location = new System.Drawing.Point(2, 31);
            this.textChooseFile.Name = "textChooseFile";
            this.textChooseFile.Size = new System.Drawing.Size(204, 21);
            this.textChooseFile.TabIndex = 2;
            // 
            // select
            // 
            this.select.BackColor = System.Drawing.Color.PapayaWhip;
            this.select.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.select.Location = new System.Drawing.Point(243, 25);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(75, 30);
            this.select.TabIndex = 3;
            this.select.Text = "Select";
            this.select.UseVisualStyleBackColor = false;
            // 
            // checkStart
            // 
            this.checkStart.AutoSize = true;
            this.checkStart.BackColor = System.Drawing.Color.White;
            this.checkStart.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.checkStart.Location = new System.Drawing.Point(12, 107);
            this.checkStart.Name = "checkStart";
            this.checkStart.Size = new System.Drawing.Size(162, 23);
            this.checkStart.TabIndex = 4;
            this.checkStart.Text = "Open program Windows";
            this.checkStart.UseVisualStyleBackColor = false;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.PapayaWhip;
            this.buttonSave.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonSave.Location = new System.Drawing.Point(12, 156);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 27);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.PapayaWhip;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(243, 156);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 27);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // selectStartWindows
            // 
            this.selectStartWindows.AutoSize = true;
            this.selectStartWindows.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectStartWindows.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.selectStartWindows.Location = new System.Drawing.Point(-2, 85);
            this.selectStartWindows.Name = "selectStartWindows";
            this.selectStartWindows.Size = new System.Drawing.Size(331, 19);
            this.selectStartWindows.TabIndex = 7;
            this.selectStartWindows.Text = "Selection if you start the Phonebook when Windows opens";
            this.selectStartWindows.Click += new System.EventHandler(this.selectStartWindows_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(330, 191);
            this.Controls.Add(this.selectStartWindows);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.checkStart);
            this.Controls.Add(this.select);
            this.Controls.Add(this.textChooseFile);
            this.Controls.Add(this.chooseFile);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximumSize = new System.Drawing.Size(346, 230);
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