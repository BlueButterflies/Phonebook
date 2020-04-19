using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Phonebook
{
    public partial class Notifications : Form
    {
        private DateTime tablePhonebook;

        [DllImport("user32.dll")]
        static extern bool AnimateWindow(IntPtr windows, int time, AnimateWindowsFlags flags);
        [Flags]
        enum AnimateWindowsFlags
        {
            AW_HOR_POSITIVE = 0x0000000,
            AW_HOR_NEGATIVE = 0x00000002,
            AW_VER_POSITIVE = 0x00000004,
            AW_VER_NEGATIVE = 0x00000008,
            AW_CENTER = 0x00000010,
            AW_HIDE = 0x00010000,
            AW_ACTIVATE = 0x00020000,
            AW_SLIDE = 0x00040000,
            AW_BLEND = 0x00080000
        }

        public Notifications()
        {
            InitializeComponent();
        }

        private void Notifications_Load(object sender, EventArgs e)
        {
            int wigth = Screen.PrimaryScreen.Bounds.Width;
            int height = Screen.PrimaryScreen.Bounds.Height;

            this.Left = wigth - this.Width;
            this.Top = height / 2 - this.Height / 2;

            AnimateWindow(this.Handle, 800, AnimateWindowsFlags.AW_SLIDE | AnimateWindowsFlags.AW_HOR_NEGATIVE);
        }

        private void labelBirth_Click(object sender, EventArgs e)
        {

        }
    }
}
