using Microsoft.EntityFrameworkCore;

namespace Avancerad.Net_Labb3_API.Models
{
    public class UserDbcontext : DbContext
    {

        public UserDbcontext(DbContextOptions<UserDbcontext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<UserInterest> UserInterests { get; set; }
        public DbSet<Link> Links { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
        new User { Id = 1, Name = "Anna Andersson", PhoneNumber = "0701234567", Email = "anna@example.com" },
            new User { Id = 2, Name = "Björn Borg", PhoneNumber = "0709876543", Email = "bjorn@example.com" }
    );

            modelBuilder.Entity<Interest>().HasData(
                new Interest { Id = 1, Title = "Programmering", Description = "Koda och bygga system" },
                new Interest { Id = 2, Title = "Bilar", Description = "Snabba sportbilar" }
            );

            modelBuilder.Entity<UserInterest>().HasData(
                new UserInterest { Id = 1, UserId = 1, InterestId = 1 },
                new UserInterest { Id = 2, UserId = 1, InterestId = 2 }, 
                new UserInterest { Id = 3, UserId = 2, InterestId = 1 }  
            );

            modelBuilder.Entity<Link>().HasData(
                new Link { Id = 1, Url = "https://learn.microsoft.com", UserId = 1, InterestId = 1 },
                new Link { Id = 2, Url = "https://www.topgear.com", UserId = 1, InterestId = 2 },
                new Link { Id = 3, Url = "https://stackoverflow.com", UserId = 2, InterestId = 1 }
            );
        }
    }
}
