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
    public partial class AddMovieForm : Form
    {
        public AddMovieForm()
        {
            InitializeComponent();
        }

        private void uxApplyButton_Click(object sender, EventArgs e)
        {
            if(CheckEmptyFields())
            {

            }
            else
            {
                MessageBox.Show("At least one field isn't filled out. Be sure to fill out all the fields." +
                    "\n Note: Movies need at least one actor.");
            }
        }

        /// <summary>
        /// verifies if required fields aren't empty strings
        /// </summary>
        /// returns true if required fields aren't empty, and false if at least one of them is empty
        private bool CheckEmptyFields()
        {
            if(uxTitleBox.Text == "")
            {
                return false;
            }
            else if(uxDirectorBox.Text == "")
            {
                return false;
            }
            else if(uxReleaseDateBox.Text == "")
            {
                return false;
            }
            else if(uxEndDateBox.Text == "")
            {
                return false;
            }
            else if(uxStudioBox.Text == "")
            {
                return false;
            }
            else if(uxGenreBox.Text == "")
            {
                return false;
            }
            else if(uxRatingBox.Text == "")
            {
                return false;
            }
            else if(uxLengthBox.Text == "")
            {
                return false;
            }
            else if(uxActorOneBox.Text == "" && uxActorTwoBox.Text == "" && uxActorThreeBox.Text == "" && uxActorFourBox.Text == "")
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
