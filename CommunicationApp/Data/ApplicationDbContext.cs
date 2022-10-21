using CommunicationApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CommunicationApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Person> Persons { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<MeetingDate> MeetingDates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Meeting>()
                .HasMany(m => m.Recipients)
                .WithMany(p => p.MeetingRequests);

            modelBuilder.Entity<Person>()
                .HasMany(p => p.HostMeetings)
                .WithOne(m => m.Host);

            modelBuilder.Entity<Person>()
                .HasMany(p => p.CategoryCreations)
                .WithOne(cc => cc.Creator);

            modelBuilder.Entity<Person>()
                .HasMany(p => p.CategoryAccessList)
                .WithMany(c => c.Participants);

            modelBuilder.Entity<Person>()
                .HasMany(p => p.NotAttending)
                .WithMany(m => m.NonAttenders);

            base.OnModelCreating(modelBuilder);

            modelBuilder.SeedDatabase();
        }
    }
}