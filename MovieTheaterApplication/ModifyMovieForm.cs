using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTheaterApplication
{
    public partial class ModifyMovieForm : Form
    {
        public ModifyMovieForm()
        {
            InitializeComponent();
        }

        private void uxSearchButton_Click(object sender, EventArgs e)
        {
            Bridge.MoviesToShow toShow = Bridge.MoviesToShow.AllMovies;

            uxMovieEntries.DataSource = Bridge.SearchForMovie(Bridge.MovieSearchType.MovieTitle, toShow, uxMovieSearchBox.Text);


        }

        private void uxMovieEntries_SelectionChanged(object sender, EventArgs e)
        {
            if (uxMovieEntries.SelectedRows == null)
                return;
            if (uxMovieEntries.SelectedRows.Count == 0)
                return;
            DataGridViewRow selected = uxMovieEntries.SelectedRows[0];
            //MessageBox.Show(selected.Cells[0].Value.ToString());
            //selected.Cells[0].OwningColumn.HeaderText
            uxTitleBox.Text = selected.Cells[1].Value.ToString();
            int directorId;
            int.TryParse(selected.Cells[2].Value.ToString(), out directorId);
            uxDirectorBox.Text = Bridge.FetchDirector(directorId);
        }

        private void uxSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
