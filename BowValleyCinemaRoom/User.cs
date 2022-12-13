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
    public partial class User : Form
    {
        int RegisterID;
        public User(int registerId)
        {
            InitializeComponent();
            RegisterID = registerId;
        }

        private void moviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Movies movies = new Movies(RegisterID);
            movies.MdiParent = this;
            movies.Show();
        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateRegister updateMovie = new UpdateRegister(RegisterID);
            updateMovie.Show();
        }
    }
}
