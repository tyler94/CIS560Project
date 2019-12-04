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
            DateTime viewedOn = Convert.ToDateTime(uxShowDateTimePicker.Text);
            if (!String.IsNullOrEmpty(uxShowTimesBox.Text))
            {
                DateTime dateTime = DateTime.ParseExact(uxShowTimesBox.Text,
                                    "h:mm tt", CultureInfo.InvariantCulture);
                TimeSpan span = dateTime.TimeOfDay;

                viewedOn += span;
            }

            if (CheckEmptyFields())
            {
                switch (uxEditTypesBox.SelectedIndex)
                {
                    // None
                    case 0:
                        {
                            int viewingCheck = Bridge.GetViewingId(uxTitleSearchBox.Text, uxCustomerNameBox.Text, uxCustomerTypeBox.Text, viewedOn);
                            int movieCheck = Bridge.GetMovieForViewing(uxTitleSearchBox.Text);
                            int customerCheck = Bridge.SearchForCustomer(uxCustomerNameBox.Text, uxCustomerTypeBox.Text);
                            if (viewingCheck != -1)
                            {
                                MessageBox.Show("A viewing with the entered data already exists! If you meant to modify an existing viewing make sure to select the modify option in the edit type field at the top of the page");
                            }
                            else if (movieCheck == -1)
                            {
                                MessageBox.Show("The entered movie is currently unavailable. Please enter a valid movie");
                            }
                            else if (customerCheck == -1)
                            {
                                MessageBox.Show("The customer you entered does not exist");
                            }
                            else
                            {
                                if (Bridge.AddViewing(movieCheck, customerCheck, viewedOn))
                                {
                                    MessageBox.Show("Successfully added viewing!");
                                }
                                else
                                {
                                    MessageBox.Show("Failed to add viewing! If you meant to modify an existing viewing make sure to select the modify option in the edit type field at the top of the page");
                                }
                            }
                            
                            break;
                        }
                    // Movie Title
                    case 1:
                        {
                            uxMovieEntries.DataSource = Bridge.SearchForViewing(Bridge.ViewingSearchType.IncludeDate, uxTitleSearchBox.Text, uxCustomerNameBox.Text, uxCustomerTypeBox.Text, viewedOn);
                            break;
                        }
                }
            }
            else
            {
                MessageBox.Show("At least one field isn't filled out. Be sure to fill out all the fields.");
            }

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

        /// <returns>true if required fields aren't empty, and false if at least one of them is empty</returns>
        private bool CheckEmptyFields()
        {
            if (uxTitleSearchBox.Text == "")
            {
                return false;
            }
            else if (uxCustomerNameBox.Text == "")
            {
                return false;
            }
            else if (uxCustomerTypeBox.Text == "")
            {
                return false;
            }
            else if (uxShowDateTimePicker.Text == "")
            {
                return false;
            }
            else if (uxShowTimesBox.Text == "")
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
