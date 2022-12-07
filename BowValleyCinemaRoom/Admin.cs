using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BowValleyCinemaRoom
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void openScreenAddNewAdmin_Click(object sender, EventArgs e)
        {
            RegisterAdmin registerAdmin = new RegisterAdmin();
            registerAdmin.MdiParent = this;
            registerAdmin.Show();
        }

        private void moviesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
