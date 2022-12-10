﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BowValleyCinemaRoom
{
    public partial class RegistersList : Form
    {
        public RegistersList()
        {
            InitializeComponent();
        }

        private void RegistersList_Load(object sender, EventArgs e)
        {
            radioId.Checked = true;
            RegisterQueries registerQueries = new RegisterQueries();
            dgRegisters.DataSource = registerQueries.GetRegisters();
            
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            textFilter.Clear();
            RegisterQueries registerQueries = new RegisterQueries();
            dgRegisters.DataSource = registerQueries.GetRegisters();
        }

        private void filter(object sender, EventArgs e)
        {
            if (radioId.Checked == true) {
                RegisterQueries registerQueries = new RegisterQueries();
                dgRegisters.DataSource = registerQueries.FilterRegisterBy("spGetRegisterById", "@Id", textFilter.Text);
            }
            else if (radioFirstName.Checked == true) {
                RegisterQueries registerQueries = new RegisterQueries();
                dgRegisters.DataSource = registerQueries.FilterRegisterBy("spGetRegisterByFirstName", "@FirstName", textFilter.Text);
            }
            else if (radioLastName.Checked == true) {
                RegisterQueries registerQueries = new RegisterQueries();
                dgRegisters.DataSource = registerQueries.FilterRegisterBy("spGetRegisterByLastName", "@LastName", textFilter.Text);
            }

        }

        private void dgRegisters_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) {
                DataGridViewRow row = this.dgRegisters.Rows[e.RowIndex];

                if (radioId.Checked == true)
                {
                    textFilter.Text = row.Cells["RegisterID"].Value.ToString();
                }
                else if (radioFirstName.Checked == true)
                {
                    textFilter.Text = row.Cells["FirstName"].Value.ToString();
                }
                else if (radioLastName.Checked == true)
                {
                    textFilter.Text = row.Cells["LastName"].Value.ToString();
                }
            }
        }
    }
}
