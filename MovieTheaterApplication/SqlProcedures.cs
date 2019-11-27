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

        /*
        
        public static string GetFilteredMoviesByDirector(string FullName, bool IsRemoved)
        {
            int num;
            if (IsRemoved)
                num = 1;
            else
                num = 0;
            return "EXEC Movie.GetFilteredMoviesByDirector \"" + FullName + "\", " + num + ";"; 
        }

        */
    }
}
