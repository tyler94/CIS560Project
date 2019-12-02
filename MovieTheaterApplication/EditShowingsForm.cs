using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace MovieTheaterApplication
{
    public partial class EditShowingsForm : Form
    {
        public EditShowingsForm()
        {
            InitializeComponent();
            uxExecuteButton.Enabled = false;
        }

        private void uxExecuteButton_Click(object sender, EventArgs e)
        {

        }

        private void uxSearchButton_Click(object sender, EventArgs e)
        {
            DateTime viewedOn = Convert.ToDateTime(uxShowDateTimePicker.Text);
            if (!String.IsNullOrEmpty(uxShowTimesBox.Text))
            {
                DateTime dateTime = DateTime.ParseExact(uxShowTimesBox.Text,
                                    "h:mm tt", CultureInfo.InvariantCulture);
                TimeSpan span = dateTime.TimeOfDay;

                viewedOn += span;
            }
            

            switch (uxSearchOptionsBox.SelectedIndex)
            {
                // None
                case 0:
                    {
                        uxMovieEntries.DataSource = Bridge.SearchForViewing(Bridge.ViewingSearchType.ExcludeDate,  uxTitleSearchBox.Text, uxCustomerNameBox.Text, uxCustomerTypeBox.Text, viewedOn);
                        break;
                    }
                // Movie Title
                case 1:
                    {
                        uxMovieEntries.DataSource = Bridge.SearchForViewing(Bridge.ViewingSearchType.IncludeDate, uxTitleSearchBox.Text, uxCustomerNameBox.Text, uxCustomerTypeBox.Text, viewedOn);
                        break;
                    }
            }
            uxExecuteButton.Enabled = true;
        }
    }
}
