using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MovieApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Movie> Movies { get; set; } = null!;
        public DbSet<UserMovie> UserMovies { get; set; } = null!;
    }

    public class Movie
    {
        public int Id { get; set; }
        public string ImdbID { get; set; } = string.Empty; // Unique identifier from imdb
        public string Title { get; set; } = string.Empty;
        public string Year { get; set; } = string.Empty;
        public string Rated { get; set; } = string.Empty;
        public string Released { get; set; } = string.Empty;
        public string Runtime { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public string Director { get; set; } = string.Empty;
        public string Writer { get; set; } = string.Empty;
        public string Actors { get; set; } = string.Empty;
        public string Plot { get; set; } = string.Empty;
        public string Language { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string Awards { get; set; } = string.Empty;
        public string Poster { get; set; } = string.Empty;
        public string ImdbRating { get; set; } = string.Empty;
        public string ImdbVotes { get; set; } = string.Empty;
        public string Metascore { get; set; } = string.Empty;
        public string BoxOffice { get; set; } = string.Empty;
    
        // Navigation property
        public List<UserMovie> UserMovies { get; set; } = new();
    }
    
    public class UserMovie
    {
        public int Id { get; set; }
        public string UserId { get; set; } = string.Empty;
        public int MovieId { get; set; }
        public int UserRating { get; set; } // 1-10
        public string UserDescription { get; set; } = string.Empty;
        public int AmountWatched { get; set; } = 1;
        public DateTime FirstWatchedDate { get; set; }
        public DateTime LastWatchedDate { get; set; }
    
        // Navigation properties
        public ApplicationUser User { get; set; } = null!;
        public Movie Movie { get; set; } = null!;
    }
}

