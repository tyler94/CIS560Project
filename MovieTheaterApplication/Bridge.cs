using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MovieTheaterApplication
{
    public static class Bridge
    {
        public delegate void AuthenticateDelegate(string Username, string Password);

        private static SqlConnection connection;

        public static bool Connect(string DataSource, string Database)
        {
            if(connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                return true;
            }
            string username = "";
            string password = "";
            
            Thread gettingLoginInfo = new Thread(() => new LoginForm(Login, DataSource, Database).ShowDialog());
            gettingLoginInfo.Start();
            // Wait for the other thread to close
            gettingLoginInfo.Join();

            // 'username' and 'password' fields should be set when the LoginForm calls the Login function below.
            // If they are not set, then return false
            if (username.Length == 0 || password.Length == 0)
                return false;
            return Connect(DataSource, Database, username, password);

            void Login(string _Username, string _Password)
            {
                username = _Username;
                password = _Password;
            }
        }

        public static bool Connect(string DataSource, string Database, string Username)
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                return true;
            }
            string password = "";

            Thread gettingLoginInfo = new Thread(() => new LoginForm(Login, DataSource, Database, Username).ShowDialog());
            gettingLoginInfo.Start();
            // Wait for the other thread to close
            gettingLoginInfo.Join();

            // 'username' and 'password' fields should be set when the LoginForm calls the Login function below.
            // If they are not set, then return false
            if (Username.Length == 0 || password.Length == 0)
                return false;
            return Connect(DataSource, Database, Username, password);

            void Login(string _Username, string _Password)
            {
                password = _Password;
            }
        }

        public static bool Connect(string DataSource, string Database, string Username, string Password)
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                return true;
            }
            string connectionString = 
                "Data Source=" + DataSource + ";" +
                "Initial Catalog=" + Database + ";" +
                "User ID=" + Username + ";" +
                "Password=" + Password;

            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch(Exception e)
            {
                // return false because the login attempt failed
                return false;
            }
            return true;
        }
    }
}
