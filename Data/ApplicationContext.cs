using Microsoft.EntityFrameworkCore;
using Webshop.Models;

namespace Webshop.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<BookingRequest> BookingRequests { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<EventType> EventTypes { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public ApplicationContext(DbContextOptions options) : base(options)
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
        }
    }
}
