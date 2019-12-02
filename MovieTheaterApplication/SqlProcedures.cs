using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheaterApplication
{
    public static class SqlProcedures
    {
        public static string GetMovies(string MovieName)
        {
            return "EXEC Movie.GetMovies \"" + MovieName + "\"";
        }

        public static string RetrieveMovies()
        {
            return "EXEC Movie.RetrieveMovies";
        }

        public static string GetMoviesByDirector(string input)
        {
            return "EXEC Movie.GetMoviesByDirector \"" + input + "\"";
        }

        public static string GetMoviesByGenre(string input)
        {
            return "EXEC Movie.GetMoviesByGenre \"" + input + "\"";
        }

        public static string GetMoviesByTitle(string input)
        {
            return "EXEC Movie.GetMoviesByTitle \"" + input + "\"";
        }

        public static string GetFilteredMoviesByDirector(string FullName, bool IsRemoved)
        {
            int num;
            if (IsRemoved)
                num = 1;
            else
                num = 0;
            return "EXEC Movie.GetFilteredMoviesByDirector \"" + FullName + "\", " + num + ";"; 
        }

        public static string GetFilteredMoviesByTitle(string FullName, bool IsRemoved)
        {
            int num;
            if (IsRemoved)
                num = 1;
            else
                num = 0;
            return "EXEC Movie.GetFilteredMoviesByTitle \"" + FullName + "\", " + num + ";";
        }

        public static string GetFilteredMoviesByGenre(string FullName, bool IsRemoved)
        {
            int num;
            if (IsRemoved)
                num = 1;
            else
                num = 0;
            return "EXEC Movie.GetFilteredMoviesByGenre \"" + FullName + "\", " + num + ";";
        }

        public static string GetFilteredMovies(bool IsRemoved)
        {
            int num;
            if (IsRemoved)
                num = 1;
            else
                num = 0;
            return "EXEC Movie.GetFilteredMoviesByTitle '', " + num + ";";
        }

        public static string GetMoviesDisplay(string MovieName)
        {
            return "EXEC Movie.GetMoviesDisplay \"" + MovieName + "\"";
        }

        public static string RetrieveMoviesDisplay()
        {
            return "EXEC Movie.RetrieveMoviesDisplay";
        }

        public static string GetMoviesByDirectorDisplay(string input)
        {
            return "EXEC Movie.GetMoviesByDirectorDisplay \"" + input + "\"";
        }

        public static string GetMoviesByGenreDisplay(string input)
        {
            return "EXEC Movie.GetMoviesByGenreDisplay \"" + input + "\"";
        }

        public static string GetMoviesByTitleDisplay(string input)
        {
            return "EXEC Movie.GetMoviesByTitleDisplay \"" + input + "\"";
        }

        public static string GetViewings(string moviename, string customername, string categoryname)
        {
            return "EXEC Movie.GetViewings '"
                + moviename + "', '"
                + customername + "', '"
                + categoryname + "'";
        }

        public static string GetViewingsOnDate(string moviename, string customername, string categoryname, DateTime viewedon)
        {
            return "EXEC Movie.GetViewingsOnDate '"
                + moviename + "', '"
                + customername + "', '"
                + categoryname + "', '"
                + viewedon + "'";
        }

        public static string GetFilteredMoviesByDirectorDisplay(string FullName, bool IsRemoved)
        {
            int num;
            if (IsRemoved)
                num = 1;
            else
                num = 0;
            return "EXEC Movie.GetFilteredMoviesByDirectorDisplay \"" + FullName + "\", " + num + ";";
        }

        public static string GetFilteredMoviesByTitleDisplay(string FullName, bool IsRemoved)
        {
            int num;
            if (IsRemoved)
                num = 1;
            else
                num = 0;
            return "EXEC Movie.GetFilteredMoviesByTitleDisplay \"" + FullName + "\", " + num + ";";
        }

        public static string GetFilteredMoviesByGenreDisplay(string FullName, bool IsRemoved)
        {
            int num;
            if (IsRemoved)
                num = 1;
            else
                num = 0;
            return "EXEC Movie.GetFilteredMoviesByGenreDisplay \"" + FullName + "\", " + num + ";";
        }

        public static string GetFilteredMoviesDisplay(bool IsRemoved)
        {
            int num;
            if (IsRemoved)
                num = 1;
            else
                num = 0;
            return "EXEC Movie.GetFilteredMoviesByTitleDisplay '', " + num + ";";
        }

        public static string GetHighestCustomerCountByYear(int day, int month, int year)
        {
            return "EXEC Movie.GetHighestCustomerCountByYear '" + month + "-" + day + "-" + year + "'";
        }

        public static string GetHighestCustomerCountByMonth(int day, int month, int year)
        {
            return "EXEC Movie.GetHighestCustomerCountByMonth '" + month + "-" + day + "-" + year + "'";
        }

        public static string GetHighestCustomerCountByDay(int day, int month, int year)
        {
            return "EXEC Movie.GetHighestCustomerCountByDay '" + month + "-" + day + "-" + year + "'";
        }

        public static string GetMostPopularAgeGroupOverall()
        {
            return "EXEC Movie.GetMostPopularAgeGroupOverall";
        }

        public static string GetMostPopularAgeGroupByMovie()
        {
            return "EXEC Movie.GetMostPopularAgeGroupByMovie";
        }

        public static string GetMostViewedMovies()
        {
            return "EXEC Movie.GetMostViewedMovies";
        }

        public static string GetTopGrossingMovies()
        {
            return "EXEC Movie.GetTopGrossingMovies";
        }

        public static string CreateMovie(string MovieName, int DirectorId, int ProductionCompanyId, int day, int month, int year, string rating)
        {
            return "EXEC Movie.CreateMovie "
                + MovieName + ", "
                + DirectorId + ", "
                + ProductionCompanyId + ", "
                + "'" + month + "-" + day + "-" + year + "'"
                + rating;
        }

        public static string AddMovie(string MovieName, int DirectorId, int studioId, string date, string rating, int length)
        {
            return "EXEC Movie.CreateMovie '"
                + MovieName + "', "
                + DirectorId + ", "
                + studioId + ", "
                + "'" + date + "'" + ", '"
                + rating + "', "
                + length + ", NULL";
        }

        public static string FetchDirector(int id)
        {
            return "EXEC Movie.FetchDirector " + id;
        }

        public static string FetchProductionCompany(int id)
        {
            return "EXEC Movie.FetchProductionCompany " + id;
        }

        public static string GetDirector(string director)
        {
            return "EXEC Movie.GetDirectors '" + director + "'";
        }

        public static string GetStudio(string studio)
        {
            return "EXEC Movie.GetProductionCompanies '" + studio + "'";
        }

        public static string RetrieveDirectors()
        {
            return "EXEC Movie.RetrieveDirectors";
        }

        public static string RetrieveStudios()
        {
            return "EXEC Movie.RetrieveProductionCompanies";
        }

        public static string RetrieveGenres()
        {
            return "EXEC Movie.RetrieveGenres";
        }
    }
}
