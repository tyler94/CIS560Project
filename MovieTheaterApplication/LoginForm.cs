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
    public partial class LoginForm : Form
    {
        Bridge.AuthenticateDelegate authenticate;

        public LoginForm(Bridge.AuthenticateDelegate Authenticate, string DataSource, string Database)
        {
            InitializeComponent();
            authenticate = Authenticate;
            uxConnectButton.Enabled = false;
        }

        public LoginForm(Bridge.AuthenticateDelegate Authenticate, string DataSource, string Database, string Username)
        {
            InitializeComponent();
            uxUsernameBox.Text = Username;
            uxUsernameBox.ReadOnly = true;
            authenticate = Authenticate;
            uxConnectButton.Enabled = false;
            uxPasswordBox.Select();
        }

        private void uxConnectButton_Click(object sender, EventArgs e)
        {
            authenticate(uxUsernameBox.Text, uxPasswordBox.Text);
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
            if (uxPasswordBox.Text.Length > 0 && uxUsernameBox.Text.Length > 0)
            {
                uxConnectButton.Enabled = true;
            }
            else
            {
                uxConnectButton.Enabled = false;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
