using MovieStreamingService;
using Microsoft.EntityFrameworkCore;

// Add Studio with Movies
Studio studio1 = new Studio {
    Name = "20th Century Fox", 
    Movies = new List<Movie> {
        new Movie {Title = "Avatar", Genre = "Action"},
        new Movie {Title = "Deadpool", Genre = "Action"},
        new Movie {Title = "Apollo 13", Genre = "Drama"},
        new Movie {Title = "The Martian", Genre = "Sci-Fi"}
    }
};
Studio studio2 = new Studio {Name = "Universal Pictures"};

// Create Database With 2 Studios 
using (var db = new AppDbContext()) // Logs into Database
{
    if (db.Database.EnsureCreated()) // Returns true if database D.N.E
    {
        db.Add(studio1);
        db.Add(studio2);
        db.SaveChanges();
    }
}

// Print Initial Output
using (var db = new AppDbContext())
{
    // List all studios with their movies
    // Use .Include() to bring in the Movies                
    var studios = db.Studios.Include(s => s.Movies);
    foreach (Studio studio in studios)
    {
        Console.WriteLine(studio);
        foreach (var movie in studio.Movies)
        {
            Console.WriteLine($"\t{movie}");
        }
    }
} 

// Add Jurassic Park to Universal Pictures Studio
using (var db = new AppDbContext())
{
    var studio = db.Studios.FirstOrDefault(s => s.Name == "Universal Pictures"); // Find Studio
    if (studio != null)
    {
        studio.Movies.Add(new Movie { Title = "Jurassic Park", Genre = "Action" }); // Add movie
        db.SaveChanges();
    }
}

// Remove Deadpool
using (var db = new AppDbContext())
{
    // Remove a movie from the database
    Movie? movieToRemove = db.Movies.Where(m => m.Title == "Deadpool").SingleOrDefault(); // ? changes to nullable type
    if (movieToRemove != null)
    {
        db.Movies.Remove(movieToRemove);
        db.SaveChanges();
    }

// Print Final Output
}
using (var db = new AppDbContext())
{
    // List all studios with their movies
    // Use .Include() to bring in the Movies                
    var studios = db.Studios.Include(s => s.Movies);
    foreach (Studio studio in studios)
    {
        Console.WriteLine(studio);
        foreach (var movie in studio.Movies)
        {
            Console.WriteLine($"\t{movie}");
        }
    }
} 