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
    public partial class MovieList : Form
    {
        public MovieList()
        {
            InitializeComponent();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            textFilter.Clear();
            MovieQueries movieQueries = new MovieQueries();
            dgMovies.DataSource = movieQueries.GetMovies();
        }

        private void MovieList_Load(object sender, EventArgs e)
        {
            radioTitle.Checked = true;
            MovieQueries movieQueries = new MovieQueries();
            dgMovies.DataSource = movieQueries.GetMovies();
        }

        private void filter(object sender, EventArgs e)
        {
            MovieQueries movieQueries = new MovieQueries();
            if (radioTitle.Checked == true)
            {
                dgMovies.DataSource = movieQueries.FilterMoviesBy("spGetMoviesByTitle", "@Title", textFilter.Text);
            }
            else if (radioCategory.Checked == true)
            {
                dgMovies.DataSource = movieQueries.FilterMoviesBy("spGetMoviesByCategory", "@Category", textFilter.Text);
            }
            else if (radioYear.Checked == true)
            {
                dgMovies.DataSource = movieQueries.FilterMoviesBy("spGetMoviesByYear", "@Year", textFilter.Text);
            }

        }

        private void dgMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgMovies.Rows[e.RowIndex];

                if (radioTitle.Checked == true)
                {
                    textFilter.Text = row.Cells["Title"].Value.ToString();
                }
                else if (radioCategory.Checked == true)
                {
                    textFilter.Text = row.Cells["Category"].Value.ToString();
                }
                else if (radioYear.Checked == true)
                {
                    textFilter.Text = row.Cells["Year"].Value.ToString();
                }
            }
        }

        private void textFilter_TextChanged(object sender, EventArgs e)
        {
            MovieQueries movieQueries = new MovieQueries();
            if (radioTitle.Checked == true)
            {
                dgMovies.DataSource = movieQueries.FilterMoviesBy("spGetMoviesByTitle", "@Title", textFilter.Text);
            }
            else if (radioCategory.Checked == true)
            {
                dgMovies.DataSource = movieQueries.FilterMoviesBy("spGetMoviesByCategory", "@Category", textFilter.Text);
            }
            else if (radioYear.Checked == true)
            {
                dgMovies.DataSource = movieQueries.FilterMoviesBy("spGetMoviesByYear", "@Year", textFilter.Text);
            }
        }

        private void dgMovies_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Edit_Click(object sender, CancelEventArgs e)
        {
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //MessageBox.Show((dgMovies.CurrentCell.Value).ToString());
            UpdateMovie updateMovie = new UpdateMovie(Convert.ToInt32(dgMovies.CurrentCell.Value));
            //updateMovie.MdiParent = this;
            updateMovie.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MovieQueries movieQueries = new MovieQueries();
            var data = movieQueries.DeleteMovieById(Convert.ToInt32(dgMovies.CurrentCell.Value));
            //MessageBox.Show(data.ToString());
            if (data.Item1 == "success") {
                MessageBox.Show("Movie successfully deleted!");
                dgMovies.DataSource = movieQueries.GetMovies();
            }
        }
    }
}
