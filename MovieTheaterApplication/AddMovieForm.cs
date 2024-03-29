﻿using System;
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
            // Intial code for this form
            InitializeComponent();
            uxDirectorBox.DataSource = Bridge.RetrieveDirectors();
            uxStudioBox.DataSource = Bridge.RetrieveStudios();
        }

        private void uxApplyButton_Click(object sender, EventArgs e)
        {
            // Makes sure all necessary boxes are filled in
            if(CheckEmptyFields())
            {
                //AddMovie(string MovieName, string DirectorName, string ProductionCompanyName, string date, string rating, int length)
                string movieName = uxTitleBox.Text;
                string directorName = uxDirectorBox.Text;
                int directorId = Bridge.GetDirector(directorName);
                string studio = uxStudioBox.Text;
                int studioid = Bridge.GetStudio(studio);
                string date = uxReleaseDateBox.Text;
                string rating = uxRatingBox.Text;
                int length;
                try
                {
                    // Check the Length box to make sure it's a number
                    int.TryParse(uxLengthBox.Text, out length);
                }
                catch
                {
                    MessageBox.Show("Length must be an integer!");
                    return;
                }

                // Actually add the movie
                if (Bridge.AddMovie(movieName, directorId, studioid, date, rating, length))
                {
                    MessageBox.Show("Successfully added movie!");
                }
                else
                {
                    MessageBox.Show("Failed to add movie!");
                }
            }
            else
            {
                MessageBox.Show("At least one field isn't filled out. Be sure to fill out all the fields.");
            }
        }

        /// <summary>
        /// verifies if required fields aren't empty strings
        /// </summary>
        /// <returns>true if required fields aren't empty, and false if at least one of them is empty</returns>
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
            else if(uxStudioBox.Text == "")
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
            else
            {
                return true;
            }
        }

        private void uxReleaseDateBox_MouseHover(object sender, EventArgs e)
        {
            uxToolTip.Show("month-day-year", uxReleaseDateBox);
        }

    }
}
