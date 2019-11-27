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
            InitializeComponent();
            AvailableMovies = false;
            UnavailableMovies = false;
        }

        private void uxSearchButton_Click(object sender, EventArgs e)
        {
            if(ValidateRadioButtons())
            {

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
            new Thread(() => new AddMovieForm().ShowDialog()).Start();
        }

        private void uxModifyMovieButton_Click(object sender, EventArgs e)
        {
            new Thread(() => new ModifyMovieForm().ShowDialog()).Start();
        }

        private void uxAllMovies_CheckedChanged(object sender, EventArgs e)
        {
            AvailableMovies = true;
            UnavailableMovies = true;
        }

        private void uxActiveShowings_CheckedChanged(object sender, EventArgs e)
        {
            AvailableMovies = true;
            UnavailableMovies = false;
        }

        private void uxInactiveShowings_CheckedChanged(object sender, EventArgs e)
        {
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
    }
}
