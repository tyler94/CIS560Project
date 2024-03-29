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
    /// <summary>
    /// This form is to modify movies
    /// </summary>
    public partial class ModifyMovieForm : Form
    {
        private int selectedMovieId = 0;
        public ModifyMovieForm()
        {
            // Initial setup code
            InitializeComponent();
            uxDirectorBox.DataSource = Bridge.RetrieveDirectors();
            uxStudioBox.DataSource = Bridge.RetrieveStudios();
        }

        // When the user attempts to search for a movie
        private void uxSearchButton_Click(object sender, EventArgs e)
        {
            Bridge.MoviesToShow toShow = Bridge.MoviesToShow.AllMovies;

            uxMovieEntries.DataSource = Bridge.SearchForMovie(Bridge.MovieSearchType.MovieTitle, toShow, uxMovieSearchBox.Text);
        }

        // Whenever the user changes their selection in the datagridview, adjust the form to be more user friendly and change all boxes based on the selection
        private void uxMovieEntries_SelectionChanged(object sender, EventArgs e)
        {
            if (uxMovieEntries.SelectedRows == null)
                return;
            if (uxMovieEntries.SelectedRows.Count == 0)
                return;
            DataGridViewRow selected = uxMovieEntries.SelectedRows[0];
            int.TryParse(selected.Cells[0].Value.ToString(), out selectedMovieId);
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

        // When the user clicks submit, attempt to edit the movie
        private void uxSubmit_Click(object sender, EventArgs e)
        {
            if (!checkBoxes())
                return;
            if(Bridge.ModifyMovie(selectedMovieId, uxTitleBox.Text, uxDirectorBox.Text, uxReleaseDateBox.Text, uxStudioBox.Text, (int) uxLengthBox.Value, uxRatingBox.Text))
            {
                MessageBox.Show("Successfully edited movie!");
            }
            else
            {
                MessageBox.Show("Failed to edit movie!");
            }
        }

        // Check to make sure everything has been typed in or alert the user
        private bool checkBoxes()
        {
            if (uxTitleBox.Text == "")
            {
                MessageBox.Show("Title must be included!");
                return false;
            }
            if (uxDirectorBox.Text == "")
            {
                MessageBox.Show("Director must be included!");
                return false;
            }
            if (uxReleaseDateBox.Text == "")
            {
                MessageBox.Show("Date must be included!");
                return false;
            }
            if (uxStudioBox.Text == "")
            {
                MessageBox.Show("Studio must be included!");
                return false;
            }
            if (uxRatingBox.Text == "")
            {
                MessageBox.Show("Rating must be selected!");
                return false;
            }
            return true;
        }
    }
}
