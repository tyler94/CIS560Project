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
                        uxMovieEntries.DataSource = Bridge.GetHighestCustomerCountByYear();
                        break;
                    }
                // Highest customer count by month
                case 5:
                    {
                        uxMovieEntries.DataSource = Bridge.GetHighestCustomerCountByMonth();
                        break;
                    }
                // Highest customer count by day
                case 6:
                    {
                        uxMovieEntries.DataSource = Bridge.GetHighestCustomerCountByDay();
                        break;
                    }

            }
        }
    }
}
