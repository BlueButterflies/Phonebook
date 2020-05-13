namespace Phonebook
{
    partial class Notifications
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
            this.pictureBoxNotific = new System.Windows.Forms.PictureBox();
            this.labelBirth = new System.Windows.Forms.Label();
            this.txtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNotific)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxNotific
            // 
            this.pictureBoxNotific.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBoxNotific.Location = new System.Drawing.Point(76, 4);
            this.pictureBoxNotific.Name = "pictureBoxNotific";
            this.pictureBoxNotific.Size = new System.Drawing.Size(110, 90);
            this.pictureBoxNotific.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNotific.TabIndex = 0;
            this.pictureBoxNotific.TabStop = false;
            // 
            // labelBirth
            // 
            this.labelBirth.AutoSize = true;
            this.labelBirth.Font = new System.Drawing.Font("Franklin Gothic Medium", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirth.Location = new System.Drawing.Point(80, 104);
            this.labelBirth.Name = "labelBirth";
            this.labelBirth.Size = new System.Drawing.Size(0, 24);
            this.labelBirth.TabIndex = 1;
            // 
            // txtBox
            // 
            this.txtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBox.Location = new System.Drawing.Point(27, 147);
            this.txtBox.Multiline = true;
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(208, 209);
            this.txtBox.TabIndex = 2;
            // 
            // Notifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(262, 368);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.labelBirth);
            this.Controls.Add(this.pictureBoxNotific);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Notifications";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Notifications";
            this.Load += new System.EventHandler(this.Notifications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNotific)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxNotific;
        private System.Windows.Forms.Label labelBirth;
        private System.Windows.Forms.TextBox txtBox;
    }
}