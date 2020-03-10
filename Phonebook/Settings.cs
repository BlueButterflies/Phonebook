using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phonebook
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void selectStartWindows_Click(object sender, EventArgs e)
        {

        }

        private void Settings_Load(object sender, EventArgs e)
        {
            selectStartWindows.Text = string.Format($"selection if you start the {Variable.nameSoftware} when windows opens");

            if (Properties.Settings.Default.OpenWindows == true)
            {
                checkStart.Checked = true;
            }
            else
            {
                checkStart.Checked = false;
            }

            textChooseFile.Text = Properties.Settings.Default.DatabasePath;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DatabasePath = textChooseFile.Text;

            if (checkStart.Checked == true)
            {
                Properties.Settings.Default.OpenWindows = true;
                Microsoft.Win32.Registry.SetValue(@"HKayLocaleMachine\Software\Microsoft\Windows\CurrentVersion\Run", "Phonebook", 
                                                  Application.ExecutablePath, Microsoft.Win32.RegistryValueKind.String);
            }
            else
            {
                Properties.Settings.Default.OpenWindows = false;

                Microsoft.Win32.RegistryKey registryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);

                registryKey.DeleteValue("Phonebook", false);
            }

            Properties.Settings.Default.Save();

            this.Close();
        }
    }
}
