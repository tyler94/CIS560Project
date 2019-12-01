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
            uxDirectorBox.DataSource = Bridge.RetrieveDirectors();
            uxStudioBox.DataSource = Bridge.RetrieveStudios();
            uxGenreBox.DataSource = Bridge.RetrieveGenres();
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
            uxTitleBox.Text = selected.Cells[1].Value.ToString();

            int directorId;
            int.TryParse(selected.Cells[2].Value.ToString(), out directorId);
            uxDirectorBox.Text = Bridge.FetchDirector(directorId);

            int studioId;
            int.TryParse(selected.Cells[3].Value.ToString(), out studioId);
            uxStudioBox.Text = Bridge.FetchProductionCompany(studioId);

            string dateFull = selected.Cells[4].Value.ToString();
            string date = dateFull.Substring(0, dateFull.IndexOf(' ')).Replace('/', '-');
            uxReleaseDateBox.Text = date;

            int length;
            int.TryParse(selected.Cells[6].Value.ToString(), out length);
            uxLengthBox.Value = length;
            uxRatingBox.Text = selected.Cells[7].Value.ToString();
        }

        private void uxSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
