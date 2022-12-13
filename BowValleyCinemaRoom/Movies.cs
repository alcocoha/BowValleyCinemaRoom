using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace BowValleyCinemaRoom
{
    public partial class Movies : Form
    {
        int totalMovies = 0;
        int totalPrice = 0;

        //string movieId;
        int registerId;
        //string rentDate;
        //string returnDate;

        public Movies(int RegisterId)
        {
            InitializeComponent();
            registerId = RegisterId;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgMovies.Rows[e.RowIndex];
            string title = row.Cells["Title"].Value.ToString();
            string price = row.Cells["Price"].Value.ToString();
            listMovies.Items.Add(title);
            listPrices.Items.Add($"{price} cad");

            totalPrice = totalPrice + Int32.Parse(price);
            totalMovies = totalMovies + 1;

            labelTotalMovies.Text = $"Total movies to rent : {totalMovies}";
            labelTotalPrice.Text = $"{totalPrice}.0 cad";
        }

        private void Movies_Load(object sender, EventArgs e)
        {
            MovieQueries movieQueries = new MovieQueries();
            dgMovies.DataSource = movieQueries.GetMovies();
        }

        private void btnSearchAMovie_Click(object sender, EventArgs e)
        {
            MovieQueries movieQueries = new MovieQueries();
            dgMovies.DataSource = movieQueries.FilterMoviesBy("spGetMoviesByTitle", "@Title", textMovie.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textMovie.Clear();
            MovieQueries movieQueries = new MovieQueries();
            dgMovies.DataSource = movieQueries.GetMovies();
        }

        private void dgMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listPrices.Items.Clear();
            listMovies.Items.Clear();
            totalPrice = 0;
            totalMovies = 0;

            labelTotalMovies.Text = $"Total movies to rent : {totalMovies}";
            labelTotalPrice.Text = $"0.0 cad";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime startDate = DateTime.Now;
            string startDateFormat = startDate.ToString("MM/dd/yyyy");
            DateTime endDate = startDate.AddDays(10);
            string endDateFormat = endDate.ToString("MM/dd/yyyy");

            MessageBox.Show($"Rent init {startDateFormat} and ends {endDateFormat}");

        }
    }
}
