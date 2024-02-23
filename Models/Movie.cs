using System;
using System.Collections.Generic;

namespace MovieStreamingService
{
    public class Movie
    {
        public int MovieId {get; set;} // Primary Key
        public string Title {get; set;} = string.Empty;
        public string Genre {get; set;} = string.Empty;
        
        // Add navigation property to MANY side
        // Each Movie belongs to ONE Studio
        public Studio Studio {get; set;} = null; // Navigation property
        public int StudioId {get; set;} // Foreign Key

        public override string ToString()
        {
            return $"({MovieId}) - {Title}";
        }

    }
}