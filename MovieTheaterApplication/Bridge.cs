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
    public static class Bridge
    {
        public delegate void AuthenticateDelegate(string DataSource, string Database, string Username, string Password);
        public enum MovieSearchType { None, MovieTitle, MovieDirector, MovieGenre }
        public enum MoviesToShow { AllMovies, OnlyAvailable, OnlyUnavailable}

        private static SqlConnection connection;
        private static bool response = false;

        public static bool Connect()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                return true;
            }

            Thread gettingLoginInfo = new Thread(() => new LoginForm(Login, Config.Server, Config.Database, Config.Username, Config.Password).ShowDialog());
            gettingLoginInfo.Start();
            // Wait for the other thread to close
            gettingLoginInfo.Join();

            // 'username' and 'password' fields should be set when the LoginForm calls the Login function below.
            // If they are not set, then return false
            return response;
        }

        private static void Login(string DataSource, string Database, string Username, string Password)
        {
            response = Connect(DataSource, Database, Username, Password);
        }

        internal static object GetMostPopularAgeGroupOverall()
        {
            string sql = SqlProcedures.GetMostPopularAgeGroupOverall();
            return Call(sql);
        }

        internal static object GetHighestCustomerCountByYear(int day, int month, int year)
        {
            string sql = SqlProcedures.GetHighestCustomerCountByYear(day, month, year);
            return Call(sql);
        }

        internal static object GetHighestCustomerCountByMonth(int day, int month, int year)
        {
            string sql = SqlProcedures.GetHighestCustomerCountByMonth(day, month, year);
            return Call(sql);
        }

        internal static object GetHighestCustomerCountByDay(int day, int month, int year)
        {
            string sql = SqlProcedures.GetHighestCustomerCountByDay(day, month, year);
            return Call(sql);
        }

        internal static object GetMostPopularAgeGroupByMovie()
        {
            string sql = SqlProcedures.GetMostPopularAgeGroupByMovie();
            return Call(sql);
        }

        internal static object GetMostViewedMovies()
        {
            string sql = SqlProcedures.GetMostViewedMovies();
            return Call(sql);
        }

        internal static object GetTopGrossingMovies()
        {
            string sql = SqlProcedures.GetTopGrossingMovies();
            return Call(sql);
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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

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
                            if(ln.ToLower() == "go")
                            {
                                Run(sql, line);
                                sql = "";
                            }
                            else
                            {
                                sql += ln + ' ';
                            }
                        }
                        if(sql != "")
                            Run(sql, line);
                    }
                }
            }

            MessageBox.Show("All procedures successfully run");
        }

        public static bool AddMovie(string MovieName, string DirectorName, string ProductionCompanyName, string date, string rating, int length)
        {
            try
            {
                Call(SqlProcedures.AddMovie(MovieName, DirectorName, ProductionCompanyName, date, rating, length));
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public static string FetchDirector(int id)
        {
            string sql = SqlProcedures.FetchDirector(id);
            DataTable temp = Call(sql);
            return temp.Rows[0][0].ToString();
        }

        public static string FetchProductionCompany(int id)
        {
            string sql = SqlProcedures.FetchProductionCompany(id);
            DataTable temp = Call(sql);
            return temp.Rows[0][0].ToString();
        }

        public static DataTable SearchForMovie(MovieSearchType type, MoviesToShow moviesToShow, string input)
        {
            string sql;
            if (input == "")
            {
                type = MovieSearchType.None;
            }

            if(moviesToShow == MoviesToShow.AllMovies)
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

        public static DataTable Call(string sql)
        {
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader dataReader = null;
            try
            {
                dataReader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            List<string> columns = new List<string>();
            List<DataColumn> dataColumns = new List<DataColumn>();
            for (int i = 0; i < dataReader.FieldCount; i++)
            {
                columns.Add(dataReader.GetName(i));
                dataColumns.Add(new DataColumn(dataReader.GetName(i)));
            }

            DataTable dataTable = new DataTable();
            dataTable.Columns.AddRange(dataColumns.ToArray());
            
            while (dataReader.Read())
            {
                List<string> items = new List<string>();
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    items.Add(dataReader.GetValue(i).ToString());
                }
                dataTable.Rows.Add((object[])items.ToArray());
            }
            
            dataReader.Close();
            return dataTable;
        }

        public static List<string> RetrieveDirectors()
        {
            DataTable temp = Call(SqlProcedures.RetrieveDirectors());
            List<string> directors = new List<string>();
            for(int i = 0; i < temp.Rows.Count; i++)
            {
                if(temp.Rows[i][1].ToString()[0] != '?')
                    directors.Add(temp.Rows[i][1].ToString());
            }
            return directors;
        }

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
    }
}
