﻿using System;
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
    /// <summary>
    /// This is the main form for the program. Simply opens other forms when the buttons are clicked.
    /// </summary>
    public partial class TheaterNavigationForm : Form
    {
        public TheaterNavigationForm()
        {
            InitializeComponent();
            this.Show();

            if(!Bridge.Connect())
            {
                MessageBox.Show("Connection failed!");
            }
        }

        private void uxActiveMovies_Click(object sender, EventArgs e)
        {
            new Thread(() => new ActiveMoviesForm().ShowDialog()).Start();
        }

        private void uxEditShowings_Click(object sender, EventArgs e)
        {
            new Thread(() => new EditShowingsForm().ShowDialog()).Start();
        }

        private void uxStatistics_Click(object sender, EventArgs e)
        {
            new Thread(() => new StatisticsForm().ShowDialog()).Start();
        }

        private void uxLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
