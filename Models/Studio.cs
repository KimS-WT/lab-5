using System;
using System.Collections.Generic;

namespace MovieStreamingService
{
    public class Studio
    {
        public int StudioId {get; set;} // Primary Key
        public string Name {get; set;} = string.Empty;
        // One-to-many relationships
        // Setup navigation property on ONE side, List of MANY side
        public List<Movie> Movies {get; set;} = new List<Movie>();
        public override string ToString()
        {
            return $"({StudioId}) - {Name}";
        }
    }
}
