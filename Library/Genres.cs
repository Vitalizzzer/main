
using System.Collections.Generic;

namespace Library
{
    public static class Genres
    {
        /// <summary>
        /// Fields
        /// </summary>
        private const string Drama = "Drama";
        private const string Adventures = "Adventures";
        private const string SciFi = "Science Fiction";
        private const string Biography = @"Biography /Historic";
        private const string Child = @"For Children";
        private const string Reference = @"Reference /Guides";
        private const string Educational = "Educational";
        private const string Religious = "Religious";
        private const string Military = @"Military Literature";
        private const string Poetry = "Poetry";

        /// <summary>
        /// Store genres into a dictionary
        /// </summary>
        /// <returns>dictionary of genres</returns>
        public static Dictionary<string, object> GenresDictionary()
        {
            var genresDictionary = new Dictionary<string, object>
            {
                {"drama", Drama},
                {"adventures", Adventures},
                {"scifi", SciFi},
                {"biography", Biography},
                {"child", Child},
                {"reference", Reference},
                {"educational", Educational},
                {"religious", Religious},
                {"military", Military},
                {"poetry", Poetry}
            };
            return genresDictionary;
        }
    }
}
