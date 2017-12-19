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
        public static List<string> GenreList { get; set; }
        
        /// <summary>
        /// Store genres into a List
        /// </summary>
        /// <returns>list of genres</returns>
        public static List<string> GenresList()
        {
            GenreList = new List<string>
            {
                Drama,
                Adventures,
                SciFi,
                Biography,
                Child,
                Reference,
                Educational,
                Religious,
                Military,
                Poetry
            };
            return GenreList;
        }
    }
}
