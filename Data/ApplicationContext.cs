using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Webshop.Models;


namespace Webshop.Data
{
    public class ApplicationContext : IdentityDbContext
    {
        public DbSet<BookingRequest> BookingRequests { get; set; }
        public DbSet<EventType> EventTypes { get; set; }
        public DbSet<User> Users { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<EventType>().HasData(new EventType { EventTypeId = 1, Event = "Proposal" });
            modelBuilder.Entity<EventType>().HasData(new EventType { EventTypeId = 2, Event = "Wedding" });
            modelBuilder.Entity<EventType>().HasData(new EventType { EventTypeId = 3, Event = "Birthday" });
            modelBuilder.Entity<EventType>().HasData(new EventType { EventTypeId = 4, Event = "Private Dinner Party" });
            modelBuilder.Entity<EventType>().HasData(new EventType { EventTypeId = 5, Event = "Baby Shower" });
            modelBuilder.Entity<EventType>().HasData(new EventType { EventTypeId = 6, Event = "Bridal Shower" });
            modelBuilder.Entity<EventType>().HasData(new EventType { EventTypeId = 7, Event = "Something Else" });
            modelBuilder.Entity<EventType>().HasData(new EventType { EventTypeId = 8, Event = "Brand Event" });

            this.SeedUsers(modelBuilder);

        }

        private void SeedUsers(ModelBuilder builder)
        {
            User user = new User()
            {
                Id = "b74ddd14-6340-4840-95c2-db12554843e5",
                UserName = "admin@random.com",
                Email = "admin@random.com",
                LockoutEnabled = false,
                NormalizedEmail = "ADMIN@RANDOM.COM",
                NormalizedUserName = "ADMIN@RANDOM.COM",

            };

            PasswordHasher<User> passwordHasher = new PasswordHasher<User>();
            user.PasswordHash = passwordHasher.HashPassword(user, "Admin*123");

            builder.Entity<User>().HasData(user);
        }
    }
}
