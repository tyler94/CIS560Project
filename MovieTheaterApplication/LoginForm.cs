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
    /// <summary>
    /// This form simply takes login information from the user and gets the default values from the config file
    /// </summary>
    public partial class LoginForm : Form
    {
        Bridge.AuthenticateDelegate authenticate;

        public LoginForm(Bridge.AuthenticateDelegate Authenticate, string DataSource, string Database, string Username, string Password)
        {
            InitializeComponent();
            authenticate = Authenticate;
            uxServerBox.Select();
            bool selected = false;

            if (DataSource.Length > 0)
            {
                uxServerBox.Text = DataSource;
            }
            else if(!selected)
            {
                uxServerBox.Select();
                selected = true;
            }

            if(Database.Length > 0)
            {
                uxDatabaseBox.Text = Database;
            }
            else if (!selected)
            {
                uxDatabaseBox.Select();
                selected = true;
            }

            if (Username.Length > 0)
            {
                uxUsernameBox.Text = Username;
            }
            else if (!selected)
            {
                uxUsernameBox.Select();
                selected = true;
            }

            if (Password.Length > 0)
            {
                uxPasswordBox.Text = Password;
            }
            else if (!selected)
            {
                uxPasswordBox.Select();
                selected = true;
            }
            CheckIfValid();
        }

        private void uxConnectButton_Click(object sender, EventArgs e)
        {
            authenticate(uxServerBox.Text, uxDatabaseBox.Text, uxUsernameBox.Text, uxPasswordBox.Text);
            this.Close();
        }

        private void uxPasswordBox_TextChanged(object sender, EventArgs e)
        {
            CheckIfValid();
        }

        private void uxUsernameBox_TextChanged(object sender, EventArgs e)
        {
            CheckIfValid();
        }

        private void CheckIfValid()
        {
            if (uxPasswordBox.Text.Length > 0 && uxUsernameBox.Text.Length > 0 && uxDatabaseBox.Text.Length > 0 && uxServerBox.Text.Length > 0)
            {
                uxConnectButton.Enabled = true;
            }
            else
            {
                uxConnectButton.Enabled = false;
            }
        }

        private void uxDatabaseBox_TextChanged(object sender, EventArgs e)
        {
            CheckIfValid();
        }

        private void uxServerBox_TextChanged(object sender, EventArgs e)
        {
            CheckIfValid();
        }
    }
}
