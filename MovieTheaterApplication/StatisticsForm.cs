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
    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            InitializeComponent();
        }

        private void uxStatisticTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            uxDateEntryLabel.Enabled = false;
            uxYearEntryBox.Enabled = false;
            uxYearLabel.Enabled = false;
            uxMonthEntryBox.Enabled = false;
            uxMonthLabel.Enabled = false;
            uxDayEntryBox.Enabled = false;
            uxDayLabel.Enabled = false;
            switch (uxStatisticTypes.SelectedIndex)
            {
                // Highest Grossing Films
                case 0:
                    {
                        break;
                    }
                // Highest Number of Viewings
                case 1:
                    {
                        break;
                    }
                // Most popular age group by film
                case 2:
                    {
                        break;
                    }
                // Most popular age group overall
                case 3:
                    {
                        break;
                    }
                // Highest Customer count by year
                case 4:
                    {
                        uxDateEntryLabel.Enabled = true;
                        uxYearEntryBox.Enabled = true;
                        uxYearLabel.Enabled = true;
                        break;
                    }
                // Highest customer count by month
                case 5:
                    {
                        uxDateEntryLabel.Enabled = true;
                        uxYearEntryBox.Enabled = true;
                        uxYearLabel.Enabled = true;
                        uxMonthEntryBox.Enabled = true;
                        uxMonthLabel.Enabled = true;
                        break;
                    }
                // Highest customer count by day
                case 6:
                    {
                        uxDateEntryLabel.Enabled = true;
                        uxYearEntryBox.Enabled = true;
                        uxYearLabel.Enabled = true;
                        uxMonthEntryBox.Enabled = true;
                        uxMonthLabel.Enabled = true;
                        uxDayEntryBox.Enabled = true;
                        uxDayLabel.Enabled = true;
                        break;
                    }

            }
        }

        private void uxRun_Click(object sender, EventArgs e)
        {
            switch (uxStatisticTypes.SelectedIndex)
            {
                // Highest Grossing Films
                case 0:
                    {
                        uxMovieEntries.DataSource = Bridge.GetTopGrossingMovies();
                        break;
                    }
                // Highest Number of Viewings
                case 1:
                    {
                        uxMovieEntries.DataSource = Bridge.GetMostViewedMovies();
                        break;
                    }
                // Most popular age group by film
                case 2:
                    {
                        uxMovieEntries.DataSource = Bridge.GetMostPopularAgeGroupByMovie();
                        break;
                    }
                // Most popular age group overall
                case 3:
                    {
                        uxMovieEntries.DataSource = Bridge.GetMostPopularAgeGroupOverall();
                        break;
                    }
                // Highest Customer count by year
                case 4:
                    {
                        int day = (int)uxDayEntryBox.Value;
                        int month = (int)uxMonthEntryBox.Value;
                        int year = (int)uxYearEntryBox.Value;
                        uxMovieEntries.DataSource = Bridge.GetHighestCustomerCountByYear(day, month, year);
                        break;
                    }
                // Highest customer count by month
                case 5:
                    {
                        int day = (int)uxDayEntryBox.Value;
                        int month = (int)uxMonthEntryBox.Value;
                        int year = (int)uxYearEntryBox.Value;
                        uxMovieEntries.DataSource = Bridge.GetHighestCustomerCountByMonth(day, month, year);
                        break;
                    }
                // Highest customer count by day
                case 6:
                    {
                        int day = (int) uxDayEntryBox.Value;
                        int month = (int) uxMonthEntryBox.Value;
                        int year = (int) uxYearEntryBox.Value;
                        uxMovieEntries.DataSource = Bridge.GetHighestCustomerCountByDay(day, month, year);
                        break;
                    }
            }
        }
    }
}
