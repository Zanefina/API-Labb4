using API_Labb4_ClassLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace API_Labb4.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<Person> Person { get; set; }
        public DbSet<Interest> Interest { get; set; }
        public DbSet<Link> Link { get; set; }
        public DbSet<PersonInterest> PersonInterest { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Person>().HasData(
                new Person { PersonID = 1, PersonName = "John", PersonLName = "Smith", PhoneNumber="555-123" },
                new Person { PersonID = 2, PersonName = "Jane", PersonLName = "Doe", PhoneNumber = "555-678" },
                new Person { PersonID = 3, PersonName = "David", PersonLName = "Johnsson", PhoneNumber = "555-345" },
                new Person { PersonID = 4, PersonName = "Emily", PersonLName = "Johnson", PhoneNumber = "555-987" },
                new Person { PersonID = 5, PersonName = "Michael", PersonLName = "Brown", PhoneNumber = "555-456" },
                new Person { PersonID = 6, PersonName = "Olivia", PersonLName = "Davis", PhoneNumber = "555-789" }
                );
            modelBuilder.Entity<Interest>().HasData(
                new Interest { InterestID = 1, Title = "Photography", Description = "Capturing moments throught pictures" },
                new Interest { InterestID = 2, Title = "Travel", Description = "Exploring new places and new cultures" },
                new Interest { InterestID = 3, Title = "Cooking", Description = "Preparing and sharing delicious meals" },
                new Interest { InterestID = 4, Title = "Reading", Description = "Escaping the real world for some time" },
                new Interest { InterestID = 5, Title = "Painting", Description = "Expressing creativity through colors and brushstrokes" },
                new Interest { InterestID = 6, Title = "Writing", Description = "Crafting stories, poems, or articles to convey thoughts and emotions" },
                new Interest { InterestID = 7, Title = "Sports", Description = "Engaging in physical activities to stay fit and competitive" },
                new Interest { InterestID = 8, Title = "Gardening", Description = "Cultivating plants and flowers to create beautiful outdoor spaces" },
                new Interest { InterestID = 9, Title = "Music", Description = "Playing instruments or singing to create melodies and evoke emotions" },
                new Interest { InterestID = 10, Title = "Dancing", Description = "Moving rhythmically to music, expressing oneself through body movements" },
                new Interest { InterestID = 11, Title = "Hiking", Description = "Exploring natural landscapes on foot, enjoying scenic views and fresh air" },
                new Interest { InterestID = 12, Title = "Yoga", Description = "Practicing mindfulness, flexibility, and relaxation through physical postures and breathing exercises" }
                );
            modelBuilder.Entity<Link>().HasData(
                new Link { LinkID = 1, LinkName = "Instagram Profile", LinkURL = "https://www.instagram.com" },
                new Link { LinkID = 2, LinkName = "Lonely Planet Website", LinkURL = "https://www.lonelyplanter.com" },
                new Link { LinkID = 3, LinkName = "Food Website", LinkURL = "https://www.foodnetwork.com" },
                new Link { LinkID = 4, LinkName = "Goodreads", LinkURL = "https://www.goodreads.com" },
                new Link { LinkID = 5, LinkName = "Artists Network", LinkURL = "https://www.artistsnetwork.com" },
                new Link { LinkID = 6, LinkName = "Medium", LinkURL = "https://medium.com" },
                new Link { LinkID = 7, LinkName = "ESPN", LinkURL = "https://www.espn.com" },
                new Link { LinkID = 8, LinkName = "The Spruce", LinkURL = "https://www.thespruce.com" },
                new Link { LinkID = 9, LinkName = "Spotify", LinkURL = "https://www.spotify.com" },
                new Link { LinkID = 10, LinkName = "Dance Spirit", LinkURL = "https://www.dancespirit.com" }
                );
            modelBuilder.Entity<PersonInterest>().HasData(
                new PersonInterest { ID = 1, InterestID = 1, PersonID = 1, LinkID = 1},
                new PersonInterest { ID = 2, InterestID = 2, PersonID = 2, LinkID = 2 },
                new PersonInterest { ID = 3, InterestID = 3, PersonID = 3, LinkID = 3 }
                );


        }
    }
}
