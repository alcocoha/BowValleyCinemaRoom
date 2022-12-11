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

namespace BowValleyCinemaRoom
{
    public partial class UpdateMovie : Form
    {
        int MovieID;
        public UpdateMovie(int Id)
        {
            InitializeComponent();
            MovieID= Id;
        }

        private void UpdateMovie_Load(object sender, EventArgs e)
        {
            MovieQueries movieQueries = new MovieQueries();
            DataTable dtable = new DataTable();
            dtable = movieQueries.GetMovieById(MovieID);
            textTitle.Text = dtable.Rows[0].Field<string>("Title");
            textDescription.Text = dtable.Rows[0].Field<string>("Description");
            textYear.Text = dtable.Rows[0].Field<string>("Year");
            textCopiesInStore.Text = dtable.Rows[0].Field<int>("TotalCopiesInStore").ToString();
            textPrice.Text = dtable.Rows[0].Field<int>("Price").ToString();
            comboBoxCategory.SelectedItem = dtable.Rows[0].Field<string>("Category");
        }

        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {
            
            string title = textTitle.Text;
            string category = comboBoxCategory.SelectedItem.ToString();
            string description = textDescription.Text;
            string year = textYear.Text;
            int totalCopies = Int32.Parse(textCopiesInStore.Text);
            int price = Int32.Parse(textPrice.Text);

            MovieQueries movieQueries = new MovieQueries();
            //MessageBox.Show(MovieID.ToString() + " " + title + " " + category + " \"" + description + "\" " + year + " " + totalCopies.ToString() + " " + price.ToString());
            var data = movieQueries.UpdateMovie(MovieID, title, category, description, year, totalCopies, price);
            MessageBox.Show(data.Item2);
            if (data.Item1 == "success" ) Close();
        }
    }
}
