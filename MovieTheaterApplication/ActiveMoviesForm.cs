using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace MovieTheaterApplication
{
    public partial class ActiveMoviesForm : Form
    {
        private bool AvailableMovies;
        private bool UnavailableMovies;

        public ActiveMoviesForm()
        {
            //Initial Startup code for this form
            InitializeComponent();
            AvailableMovies = true;
            UnavailableMovies = false;
            uxSearchOptionsBox.SelectedIndex = 0;
            CheckSearchType();
        }

        // When the user clicks 'Search'
        private void uxSearchButton_Click(object sender, EventArgs e)
        {
            if (ValidateRadioButtons())
            {
                // Determine which movies to show (Only Available, Unavailable, or all)
                Bridge.MoviesToShow moviesToShow;

                if (uxActiveShowings.Checked)
                {
                    moviesToShow = Bridge.MoviesToShow.OnlyAvailable;
                }
                else if (uxInactiveShowings.Checked)
                {
                    moviesToShow = Bridge.MoviesToShow.OnlyUnavailable;
                }
                else
                {
                    moviesToShow = Bridge.MoviesToShow.AllMovies;
                }

                // Determine how we're searching
                switch (uxSearchOptionsBox.SelectedIndex)
                {
                    // None
                    case 0:
                        {
                            uxMovieEntries.DataSource = Bridge.SearchForMovieDisplay(Bridge.MovieSearchType.None, moviesToShow, uxSearchEntry.Text);
                            break;
                        }
                    // Movie Title
                    case 1:
                        {
                            uxMovieEntries.DataSource = Bridge.SearchForMovieDisplay(Bridge.MovieSearchType.MovieTitle, moviesToShow, uxSearchEntry.Text);
                            break;
                        }
                    // Movie Director
                    case 2:
                        {
                            uxMovieEntries.DataSource = Bridge.SearchForMovieDisplay(Bridge.MovieSearchType.MovieDirector, moviesToShow, uxSearchEntry.Text);
                            break;
                        }
                    // Movie Genre
                    case 3:
                        {
                            uxMovieEntries.DataSource = Bridge.SearchForMovieDisplay(Bridge.MovieSearchType.MovieGenre, moviesToShow, uxSearchEntry.Text);
                            break;
                        }
                }
            }
            else
            {
                MessageBox.Show("Select one of the following: " +
                    "\n All Movies " +
                    "\n Available Movies " +
                    "\n Unavailable Movies");
            }
        }

        private void uxAddMovie_Click(object sender, EventArgs e)
        {
            // Open the AddMovieForm in a new thread
            new Thread(() => new AddMovieForm().ShowDialog()).Start();
        }

        private void uxModifyMovieButton_Click(object sender, EventArgs e)
        {
            // Open the ModifyMovieForm in a new thread
            new Thread(() => new ModifyMovieForm().ShowDialog()).Start();
        }

        private void uxAllMovies_CheckedChanged(object sender, EventArgs e)
        {
            // When the user clicks on 'All Movies'
            AvailableMovies = true;
            UnavailableMovies = true;
        }

        private void uxActiveShowings_CheckedChanged(object sender, EventArgs e)
        {
            // When the user clicks on 'Active Movies'
            AvailableMovies = true;
            UnavailableMovies = false;
        }

        private void uxInactiveShowings_CheckedChanged(object sender, EventArgs e)
        {
            // When the user clicks on 'Inactive Movies'
            AvailableMovies = false;
            UnavailableMovies = true;
        }

        /// <summary>
        /// This checks if at least one of the radio buttons is selected,
        /// which is determined by the fields "AvailableMovies" and "UnavailableMovies".
        /// </summary>
        /// <returns>true if at least one of the fields is true (which should only happen when a button is selected).
        /// returns false if both fields remain false (initial values on form creation, which has no button selected).</returns>
        private bool ValidateRadioButtons()
        {
            if (AvailableMovies == false && UnavailableMovies == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        
        private void uxSearchOptionsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // When the user switches the search types, we need to check if the search box should be enabled or disabled.
            CheckSearchType();
        }

        private void CheckSearchType()
        {
            if (uxSearchOptionsBox.SelectedIndex == 0)
            {
                uxSearchEntry.Enabled = false;
            }
            else
            {
                uxSearchEntry.Enabled = true;
            }
        }
    }
}
