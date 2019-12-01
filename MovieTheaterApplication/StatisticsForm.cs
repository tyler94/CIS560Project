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
            uxDateEntryLabel.Visible = false;
            uxYearEntryBox.Visible = false;
            uxYearLabel.Visible = false;
            uxMonthEntryBox.Visible = false;
            uxMonthLabel.Visible = false;
            uxDayEntryBox.Visible = false;
            uxDayLabel.Visible = false;
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
                        MessageBox.Show("This will require a year/date input, defaulting to 2019");
                        uxMovieEntries.DataSource = Bridge.GetHighestCustomerCountByYear(1, 1, 2019);
                        uxDateEntryLabel.Visible = true;
                        uxYearEntryBox.Visible = true;
                        uxYearLabel.Visible = true;
                        break;
                    }
                // Highest customer count by month
                case 5:
                    {
                        MessageBox.Show("This will require a month/date input, defaulting to 1 (January)");
                        uxMovieEntries.DataSource = Bridge.GetHighestCustomerCountByMonth(1, 1, 2019);
                        uxDateEntryLabel.Visible = true;
                        uxYearEntryBox.Visible = true;
                        uxYearLabel.Visible = true;
                        uxMonthEntryBox.Visible = true;
                        uxMonthLabel.Visible = true;
                        break;
                    }
                // Highest customer count by day
                case 6:
                    {
                        MessageBox.Show("This will require a day/date input, defaulting to 1st");
                        uxMovieEntries.DataSource = Bridge.GetHighestCustomerCountByDay(1, 1, 2019);
                        uxDateEntryLabel.Visible = true;
                        uxYearEntryBox.Visible = true;
                        uxYearLabel.Visible = true;
                        uxMonthEntryBox.Visible = true;
                        uxMonthLabel.Visible = true;
                        uxDayEntryBox.Visible = true;
                        uxDayLabel.Visible = true;
                        break;
                    }

            }
        }
    }
}
