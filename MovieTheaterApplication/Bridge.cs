using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTheaterApplication
{
    /// <summary>
    /// This class is the main code that handles interaction between the C# program and the SQL database.
    /// </summary>
    public static class Bridge
    {
        // Delegate for logging in
        public delegate void AuthenticateDelegate(string DataSource, string Database, string Username, string Password);
        // public enums for passing information into methods
        public enum MovieSearchType { None, MovieTitle, MovieDirector, MovieGenre }
        public enum MoviesToShow { AllMovies, OnlyAvailable, OnlyUnavailable }
        public enum ViewingSearchType { ExcludeDate, IncludeDate }

        private static SqlConnection connection;
        private static bool response = false;

        /// <summary>
        /// Connects to the SQL server by opening the login form and attempting a connection
        /// </summary>
        /// <returns> bool when finished if connected</returns>
        public static bool Connect()
        {
            // If it's already connected then don't do anything
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                return true;
            }

            // Open the login form so that the user can type in the info to login
            Thread gettingLoginInfo = new Thread(() => new LoginForm(Login, Config.Server, Config.Database, Config.Username, Config.Password).ShowDialog());
            // Start the other thread
            gettingLoginInfo.Start();
            // Wait for the other thread to close (i.e. login information has been entered)
            gettingLoginInfo.Join();

            // 'username' and 'password' fields should be set when the LoginForm calls the Login function (see below method).
            // If they are not set, then return false
            return response;
        }

        /// <summary>
        /// This function is called by the login form to pass the data back
        /// </summary>
        private static void Login(string DataSource, string Database, string Username, string Password)
        {
            // Set response to true if the connection is successful
            response = Connect(DataSource, Database, Username, Password);
        }

        // Gets the most popular age group overall
        internal static object GetMostPopularAgeGroupOverall()
        {
            string sql = SqlProcedures.GetMostPopularAgeGroupOverall();
            return Call(sql);
        }

        // Gets the highest customer count for a given year
        internal static object GetHighestCustomerCountByYear(int day, int month, int year)
        {
            string sql = SqlProcedures.GetHighestCustomerCountByYear(day, month, year);
            return Call(sql);
        }

        // Gets the highest customer count for a given month in a given year
        internal static object GetHighestCustomerCountByMonth(int day, int month, int year)
        {
            string sql = SqlProcedures.GetHighestCustomerCountByMonth(day, month, year);
            return Call(sql);
        }

        // Gets the highest customer count for a given day in a given month in a given year
        internal static object GetHighestCustomerCountByDay(int day, int month, int year)
        {
            string sql = SqlProcedures.GetHighestCustomerCountByDay(day, month, year);
            return Call(sql);
        }

        // Gets the most popular agre group for each and every movie
        internal static object GetMostPopularAgeGroupByMovie()
        {
            string sql = SqlProcedures.GetMostPopularAgeGroupByMovie();
            return Call(sql);
        }

        // Gets the total number of views for every movie and sorts them greatest to least
        internal static object GetMostViewedMovies()
        {
            string sql = SqlProcedures.GetMostViewedMovies();
            return Call(sql);
        }

        // Gets the amount of money that every movie made and sorts them greatest to least
        internal static object GetTopGrossingMovies()
        {
            string sql = SqlProcedures.GetTopGrossingMovies();
            return Call(sql);
        }

        // Attempts a connection using the given login and database info
        public static bool Connect(string DataSource, string Database, string Username, string Password)
        {
            // If it's already connected then return
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                return true;
            }
            // Connection string necessary to connect
            string connectionString =
                "Data Source=" + DataSource + ";" +
                "Initial Catalog=" + Database + ";" +
                "User ID=" + Username + ";" +
                "Password=" + Password;
            
            connection = new SqlConnection(connectionString);
            try
            {
                // Attempt the connection
                connection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        /*
        // THIS METHOD IS NO LONGER USED AND IS INSTEAD IN THE REBUILD SCRIPT
        
        // This method runs all of the procedures in the procedures.txt file.
        public static void RerunAllProcedures()
        {
            using (StreamReader sr = new StreamReader("..\\..\\config\\procedures.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    using (StreamReader sr2 = new StreamReader(line))
                    {
                        string sql = "";
                        while (!sr2.EndOfStream)
                        {
                            string ln = sr2.ReadLine();
                            if (ln.ToLower() == "go")
                            {
                                Run(sql, line);
                                sql = "";
                            }
                            else
                            {
                                sql += ln + ' ';
                            }
                        }
                        if (sql != "")
                            Run(sql, line);
                    }
                }
            }

            MessageBox.Show("All procedures successfully run");
        }
        */

        // Add a movie to the database
        public static bool AddMovie(string MovieName, int directorId, int studioId, string date, string rating, int length)
        {
            try
            {
                Call(SqlProcedures.AddMovie(MovieName, directorId, studioId, date, rating, length));
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        // Edit the movie with 'movieid' with all of the other values
        public static bool ModifyMovie(int MovieId, string MovieName, string director, string date, string studio, int length, string rating)
        {
            try
            {
                int directorId = GetDirector(director);
                int studioId = GetStudio(studio);
                Call(SqlProcedures.ModifyMovie(MovieId, MovieName, directorId, date, studioId, length, rating));
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        // Add a viewing to the database
        public static bool AddViewing(int movieid, int customerid, DateTime viewedon)
        {
            try
            {
                Call(SqlProcedures.CreateViewing(movieid, customerid, viewedon));
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        // Edit the viewing with the 'viewingid'
        public static bool ModifyViewing(int viewingid, int movieid, int customerid, DateTime viewedon)
        {
            try
            {
                Call(SqlProcedures.ModifyViewing(viewingid, movieid, customerid, viewedon));
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        // gets the directors name using the directors id
        public static string FetchDirector(int id)
        {
            string sql = SqlProcedures.FetchDirector(id);
            DataTable temp = Call(sql);
            return temp.Rows[0][0].ToString();
        }

        // gets the studio name using the studio id
        public static string FetchProductionCompany(int id)
        {
            string sql = SqlProcedures.FetchProductionCompany(id);
            DataTable temp = Call(sql);
            return temp.Rows[0][0].ToString();
        }

        // Search for a movie based on how to search, what to show, and the search prompt
        public static DataTable SearchForMovie(MovieSearchType type, MoviesToShow moviesToShow, string input)
        {
            string sql;
            if (input == "")
            {
                type = MovieSearchType.None;
            }

            if (moviesToShow == MoviesToShow.AllMovies)
            {
                switch (type)
                {
                    case MovieSearchType.None:
                        {
                            sql = SqlProcedures.RetrieveMovies();
                            return Call(sql);
                        }
                    case MovieSearchType.MovieTitle:
                        {
                            sql = SqlProcedures.GetMoviesByTitle(input);
                            return Call(sql);
                        }
                    case MovieSearchType.MovieGenre:
                        {
                            sql = SqlProcedures.GetMoviesByGenre(input);
                            return Call(sql);
                        }
                    case MovieSearchType.MovieDirector:
                        {
                            sql = SqlProcedures.GetMoviesByDirector(input);
                            return Call(sql);
                        }
                }
            }
            else
            {
                bool isRemoved = (moviesToShow == MoviesToShow.OnlyUnavailable);

                switch (type)
                {
                    case MovieSearchType.None:
                        {
                            sql = SqlProcedures.GetFilteredMovies(isRemoved);
                            return Call(sql);

                        }
                    case MovieSearchType.MovieTitle:
                        {
                            sql = SqlProcedures.GetFilteredMoviesByTitle(input, isRemoved);
                            return Call(sql);
                        }
                    case MovieSearchType.MovieGenre:
                        {
                            sql = SqlProcedures.GetFilteredMoviesByGenre(input, isRemoved);
                            return Call(sql);
                        }
                    case MovieSearchType.MovieDirector:
                        {
                            sql = SqlProcedures.GetFilteredMoviesByDirector(input, isRemoved);
                            return Call(sql);
                        }
                }
            }

            return null;
        }

        // This function also searches for movies but is used to show them in a more user-friendly manner
        public static DataTable SearchForMovieDisplay(MovieSearchType type, MoviesToShow moviesToShow, string input)
        {
            string sql;
            if (input == "")
            {
                type = MovieSearchType.None;
            }

            if (moviesToShow == MoviesToShow.AllMovies)
            {
                switch (type)
                {
                    case MovieSearchType.None:
                        {
                            sql = SqlProcedures.RetrieveMoviesDisplay();
                            return Call(sql);
                        }
                    case MovieSearchType.MovieTitle:
                        {
                            sql = SqlProcedures.GetMoviesByTitleDisplay(input);
                            return Call(sql);
                        }
                    case MovieSearchType.MovieGenre:
                        {
                            sql = SqlProcedures.GetMoviesByGenreDisplay(input);
                            return Call(sql);
                        }
                    case MovieSearchType.MovieDirector:
                        {
                            sql = SqlProcedures.GetMoviesByDirectorDisplay(input);
                            return Call(sql);
                        }
                }
            }
            else
            {
                bool isRemoved = (moviesToShow == MoviesToShow.OnlyUnavailable);

                switch (type)
                {
                    case MovieSearchType.None:
                        {
                            sql = SqlProcedures.GetFilteredMoviesDisplay(isRemoved);
                            return Call(sql);

                        }
                    case MovieSearchType.MovieTitle:
                        {
                            sql = SqlProcedures.GetFilteredMoviesByTitleDisplay(input, isRemoved);
                            return Call(sql);
                        }
                    case MovieSearchType.MovieGenre:
                        {
                            sql = SqlProcedures.GetFilteredMoviesByGenreDisplay(input, isRemoved);
                            return Call(sql);
                        }
                    case MovieSearchType.MovieDirector:
                        {
                            sql = SqlProcedures.GetFilteredMoviesByDirectorDisplay(input, isRemoved);
                            return Call(sql);
                        }
                }
            }

            return null;
        }
        
        // Search for a specific viewing with the given info
        public static DataTable SearchForViewing(ViewingSearchType type, string moviename, string customername, string categoryname, DateTime viewedon)
        {
            string sql;
                switch (type)
                {
                    case ViewingSearchType.ExcludeDate:
                        {
                            sql = SqlProcedures.GetViewings(moviename, customername, categoryname);
                            return Call(sql);
                        }
                    case ViewingSearchType.IncludeDate:
                        {
                            sql = SqlProcedures.GetViewingsOnDate(moviename, customername, categoryname, viewedon);
                            return Call(sql);
                        }
                }
            return null;
        }

        // Find a customer by name and category
        public static int SearchForCustomer(string customername, string categoryname)
        {
            string sql;
            sql = SqlProcedures.GetCustomers(customername, categoryname);
            DataTable temp = Call(sql);
            if (temp.Rows.Count > 0)
            {
                int id;
                int.TryParse(temp.Rows[0][0].ToString(), out id);
                return id;
            }
            else
                return -1;
        }

        // Get a movie id by name
        public static int GetMovieForViewing(string input)
        {

            string sql = SqlProcedures.GetMoviesForViewings(input);
            DataTable temp = Call(sql);
            if (temp.Rows.Count > 0)
            {
                int id;
                int.TryParse(temp.Rows[0][0].ToString(), out id);
                return id;
            }
            else
                return -1;
        }

        // Gets the viewing id based on other information to search by
        public static int GetViewingId(string moviename, string customername, string categoryname, DateTime viewedon)
        {
            string sql = SqlProcedures.GetViewingsOnDateWithId(moviename, customername, categoryname, viewedon);
            DataTable temp = Call(sql);
            if (temp.Rows.Count > 0)
            {
                int id;
                int.TryParse(temp.Rows[0][0].ToString(), out id);
                return id;
            }
            else
                return -1;
        }

        // This method calls a given SQL script and shows the file name if there is an error. Used for SQL commands with no output.
        public static void Run(string sql, string file)
        {

            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + '\n' + "In file: " + file);
            }
        }

        // This is the main SQL calling method. Takes a sql command and returns a DataTable to be used in the forms.
        public static DataTable Call(string sql)
        {
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader dataReader = null;
            try
            {
                // Run the command
                dataReader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                // Display the error if it didn't work
                MessageBox.Show(e.Message);
            }

            List<string> columns = new List<string>();
            List<DataColumn> dataColumns = new List<DataColumn>();
            // Go through every column and add it to a list of DataColumns
            for (int i = 0; i < dataReader.FieldCount; i++)
            {
                columns.Add(dataReader.GetName(i));
                dataColumns.Add(new DataColumn(dataReader.GetName(i)));
            }

            // Create a DataTable and add all of the columns to it
            DataTable dataTable = new DataTable();
            dataTable.Columns.AddRange(dataColumns.ToArray());

            // Read in every row and add it to the DataTable
            while (dataReader.Read())
            {
                List<string> items = new List<string>();
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    items.Add(dataReader.GetValue(i).ToString());
                }
                dataTable.Rows.Add((object[])items.ToArray());
            }

            // Close the SQL reader to prevent errors or leaks
            dataReader.Close();
            return dataTable;
        }

        // Get all directors that currently exist. This is used when a form is opened to populate the dropdown boxes.
        public static List<string> RetrieveDirectors()
        {
            DataTable temp = Call(SqlProcedures.RetrieveDirectors());
            List<string> directors = new List<string>();
            for (int i = 0; i < temp.Rows.Count; i++)
            {
                if (temp.Rows[i][1].ToString()[0] != '?')
                    directors.Add(temp.Rows[i][1].ToString());
            }
            return directors;
        }

        // Get all studios that currently exist. This is used when a form is opened to populate the dropdown boxes.
        public static List<string> RetrieveStudios()
        {
            DataTable temp = Call(SqlProcedures.RetrieveStudios());
            List<string> studios = new List<string>();
            for (int i = 0; i < temp.Rows.Count; i++)
            {
                studios.Add(temp.Rows[i][1].ToString());
            }
            return studios;
        }

        // Get all genres that currently exist. This is used when a form is opened to populate the dropdown boxes.
        public static List<string> RetrieveGenres()
        {
            DataTable temp = Call(SqlProcedures.RetrieveGenres());
            List<string> genres = new List<string>();
            for (int i = 0; i < temp.Rows.Count; i++)
            {
                genres.Add(temp.Rows[i][1].ToString());
            }
            return genres;
        }

        // Get a directors id by passing in a name
        public static int GetDirector(string director)
        {
            string sql = SqlProcedures.GetDirector(director);
            DataTable temp = Call(sql);
            if(temp.Rows.Count == 0)
            {
                sql = SqlProcedures.CreateDirector(director);
                Run(sql, "Create Director");
                sql = SqlProcedures.GetDirector(director);
                temp = Call(sql);
            }
            if (temp.Rows.Count > 0)
            {
                int id;
                int.TryParse(temp.Rows[0][0].ToString(), out id);
                return id;
            }
            else
                return -1;
        }

        // Get a studios id by passing in a name
        public static int GetStudio(string studio)
        {
            string sql = SqlProcedures.GetStudio(studio);
            DataTable temp = Call(sql);
            if (temp.Rows.Count == 0)
            {
                sql = SqlProcedures.CreateStudio(studio);
                Run(sql, "Create Studio");
                sql = SqlProcedures.GetStudio(studio);
                temp = Call(sql);
            }
            if(temp.Rows.Count > 0)
            {
                int id;
                int.TryParse(temp.Rows[0][0].ToString(), out id);
                return id;
            }
            else
                return -1;
        }
    }
}
