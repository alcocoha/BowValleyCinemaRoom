﻿using System;
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
        public User()
        {
            InitializeComponent();
        }

        private void moviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Movies movies = new Movies();
            movies.MdiParent = this;
            movies.Show();
        }
    }
}
