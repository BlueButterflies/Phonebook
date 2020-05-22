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
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void lblVersion_Click(object sender, EventArgs e)
        {
            lblVersion.Text = Variable.verisonSoftware;
        }

        private void Info_Load(object sender, EventArgs e)
        {
            lblVersion.Text = "Version " + Variable.verisonSoftware;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
