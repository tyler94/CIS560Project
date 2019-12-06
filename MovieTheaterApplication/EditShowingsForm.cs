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
    /// <summary>
    /// This form allows the user to edit viewings
    /// </summary>
    public partial class EditShowingsForm : Form
    {
        // Global variable
        int activeViewingId = -1;

        public EditShowingsForm()
        {
            // Initial code
            InitializeComponent();
            checkBoxes();
            uxEditTypesBox.SelectedIndex = 2;
        }

        //modify or create a viewing 
        private void uxExecuteButton_Click(object sender, EventArgs e)
        {
            // When the user clicks execute
            DateTime viewedOn = Convert.ToDateTime(uxShowDateTimePicker.Text);
            if (!String.IsNullOrEmpty(uxShowTimesBox.Text))
            {
                DateTime dateTime = Convert.ToDateTime(uxShowTimesBox.Text);
                TimeSpan span = dateTime.TimeOfDay;

                viewedOn += span;
            }
            
            if (CheckEmptyFields())
            {
                int viewingCheck = Bridge.GetViewingId(uxTitleSearchBox.Text, uxCustomerNameBox.Text, uxCustomerTypeBox.Text, viewedOn);
                int movieCheck = Bridge.GetMovieForViewing(uxTitleSearchBox.Text);
                int customerCheck = Bridge.SearchForCustomer(uxCustomerNameBox.Text, uxCustomerTypeBox.Text);
                if (viewingCheck != -1)
                {
                    MessageBox.Show("A viewing with the entered data already exists!");
                }
                else if (movieCheck == -1)
                {
                    MessageBox.Show("The entered movie is currently unavailable. Please enter a valid movie");
                }
                else if (customerCheck == -1)
                {
                    MessageBox.Show("The customer you entered does not exist! Be sure to check the customer type!");
                }
                else
                {
                    switch (uxEditTypesBox.SelectedIndex)
                    {
                        // Add Movie
                        case 0:
                            {

                                if (Bridge.AddViewing(movieCheck, customerCheck, viewedOn))
                                {
                                    MessageBox.Show("Successfully added viewing!");
                                    uxSearchButton.PerformClick();
                                }
                                else
                                {
                                    MessageBox.Show("Failed to add viewing! If you meant to modify an existing viewing make sure to select the modify option in the edit type field at the top of the page");
                                }

                                break;
                            }
                        // Modify Movie
                        case 1:
                            {
                                if(activeViewingId == -1)
                                {
                                    MessageBox.Show("No viewing selected! You must select a viewing in order to modify it!");
                                }
                                else
                                {
                                    if (Bridge.ModifyViewing(activeViewingId, movieCheck, customerCheck, viewedOn))
                                    {
                                        MessageBox.Show("Successfully modified viewing!");
                                        uxSearchButton.PerformClick();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Failed to modify viewing!");
                                    }
                                }
                                

                                break;
                            }
                    }
                }
            }
            else
            {
                MessageBox.Show("At least one field isn't filled out. Be sure to fill out all the fields.");
            }

        }

        //Uses fields on form to search for existing showings, the date may be included or excluded from the search
        private void uxSearchButton_Click(object sender, EventArgs e)
        {
            string movieTitle;
            {
                if (uxIncludeMovieTitle.Checked)
                {
                    if (uxTitleSearchBox.Text == "")
                    {
                        MessageBox.Show("Movie Title cannot be blank!");
                        return;
                    }
                    movieTitle = uxTitleSearchBox.Text;
                }
                else
                {
                    movieTitle = "";
                }
            }

            string customerName;
            {
                if (uxIncludeCustomerName.Checked)
                {
                    if (uxCustomerNameBox.Text == "")
                    {
                        MessageBox.Show("Customer name cannot be blank!");
                        return;
                    }
                    customerName = uxCustomerNameBox.Text;
                }
                else
                {
                    customerName = "";
                }
            }

            string customerType;
            {
                if (uxIncludeCustomerType.Checked)
                {
                    if (uxCustomerTypeBox.Text == "")
                    {
                        MessageBox.Show("Customer type cannot be blank!");
                        return;
                    }
                    customerType = uxCustomerTypeBox.Text;
                }
                else
                {
                    customerType = "";
                }
            }

            Bridge.ViewingSearchType includeDate;
            string showingDate;
            string showingTime;
            DateTime viewedOn;
            {
                if (uxIncludeShowingDateAndTime.Checked)
                {
                    showingDate = uxShowDateTimePicker.Value.ToShortDateString();
                    showingTime = uxShowTimesBox.Text;
                    includeDate = Bridge.ViewingSearchType.IncludeDate;
                    viewedOn = Convert.ToDateTime(uxShowDateTimePicker.Text);
                    if (!String.IsNullOrEmpty(uxShowTimesBox.Text))
                    {
                        DateTime dateTime = Convert.ToDateTime(uxShowTimesBox.Text);
                        TimeSpan span = dateTime.TimeOfDay;

                        viewedOn += span;
                    }
                }
                else
                {
                    showingDate = "";
                    showingTime = "";
                    includeDate = Bridge.ViewingSearchType.ExcludeDate;
                    viewedOn = new DateTime();
                }
            }

            uxMovieEntries.DataSource = Bridge.SearchForViewing(includeDate, movieTitle, customerName, customerType, viewedOn);
        }

        //Populate the form and get/set the active viewingid based on the selected row
        private void uxMovieEntries_SelectionChanged(object sender, EventArgs e)
        {
            if (uxMovieEntries.SelectedRows == null)
                return;
            if (uxMovieEntries.SelectedRows.Count == 0)
                return;
            
            checkBoxes();

            DataGridViewRow selected = uxMovieEntries.SelectedRows[0];
            uxTitleSearchBox.Text = selected.Cells[2].Value.ToString();
            uxCustomerNameBox.Text = selected.Cells[0].Value.ToString();
            uxCustomerTypeBox.Text = selected.Cells[1].Value.ToString();

            DateTime dtValue = Convert.ToDateTime(selected.Cells[3].Value.ToString());  // load your date & time into this variable
            uxShowDateTimePicker.Value = dtValue;
            uxShowTimesBox.Text = dtValue.ToString("h:mm:ss tt", CultureInfo.InvariantCulture);

            DateTime viewedOn = Convert.ToDateTime(uxShowDateTimePicker.Text);
            if (!String.IsNullOrEmpty(uxShowTimesBox.Text))
            {
                DateTime dateTime = Convert.ToDateTime(uxShowTimesBox.Text);
                TimeSpan span = dateTime.TimeOfDay;

                viewedOn += span;
            }
            activeViewingId = Bridge.GetViewingId(uxTitleSearchBox.Text, uxCustomerNameBox.Text, uxCustomerTypeBox.Text, viewedOn);

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

        private void uxSearchOptionsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBoxes();
        }

        private void uxIncludeMovieTitle_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxes();
        }

        private void uxIncludeCustomerName_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxes();
        }

        private void uxIncludeCustomerType_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxes();
        }

        private void uxIncludeShowingDateAndTime_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxes();
        }

        // Check all of the boxes to determine what should be enabled/disabled
        private void checkBoxes()
        {
            if (uxIncludeMovieTitle.Checked)
            {
                uxTitleSearchLabel.Enabled = true;
                uxTitleSearchBox.Enabled = true;
            }
            else
            {
                uxTitleSearchLabel.Enabled = false;
                uxTitleSearchBox.Enabled = false;
            }

            if (uxIncludeCustomerName.Checked)
            {
                uxCustomerNameLabel.Enabled = true;
                uxCustomerNameBox.Enabled = true;
            }
            else
            {
                uxCustomerNameLabel.Enabled = false;
                uxCustomerNameBox.Enabled = false;
            }

            if (uxIncludeCustomerType.Checked)
            {
                uxCustomerTypeLabel.Enabled = true;
                uxCustomerTypeBox.Enabled = true;
            }
            else
            {
                uxCustomerTypeLabel.Enabled = false;
                uxCustomerTypeBox.Enabled = false;
            }

            if (uxIncludeShowingDateAndTime.Checked)
            {
                uxGroupBox.Enabled = true;
            }
            else
            {
                uxGroupBox.Enabled = false;
            }

            if (uxEditTypesBox.SelectedIndex != 2 && uxMovieEntries.SelectedRows != null && uxMovieEntries.SelectedRows.Count != 0)
            {
                uxIncludeMovieTitle.Checked = true;
                uxIncludeMovieTitle.Enabled = false;
                uxIncludeCustomerName.Checked = true;
                uxIncludeCustomerName.Enabled = false;
                uxIncludeCustomerType.Checked = true;
                uxIncludeCustomerType.Enabled = false;
                uxIncludeShowingDateAndTime.Checked = true;
                uxIncludeShowingDateAndTime.Enabled = false;
            }
            else
            {
                uxIncludeMovieTitle.Enabled = true;
                uxIncludeCustomerName.Enabled = true;
                uxIncludeCustomerType.Enabled = true;
                uxIncludeShowingDateAndTime.Enabled = true;
            }
        }

        private void uxEditTypesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBoxes();
        }
    }
}
