using Microsoft.EntityFrameworkCore;

using SoleMatesWA.Models;

namespace SoleMatesWA.Data;

public class SoleMatesWAContext : DbContext
{
    public DbSet<EventModel> Events { get; set; }
    public DbSet<CommentModel> Comments { get; set; }

    public SoleMatesWAContext(DbContextOptions<SoleMatesWAContext> options) : base(options)
    {
        Events = Set<EventModel>();
        Comments = Set<CommentModel>();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EventModel>(entity =>
        {
            entity.HasKey(e => e.Id); // Set Id as the primary key

            entity.Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(500);

            entity.Property(e => e.Date)
                .IsRequired();

            entity.Property(e => e.Location)
                .IsRequired()
                .HasMaxLength(200);

            entity.Property(e => e.Venue)
                .IsRequired()
                .HasMaxLength(200);

            entity.Property(e => e.StartTime)
                .IsRequired();

            entity.Property(e => e.EndTime)
                .IsRequired();

            entity.HasMany(e => e.Comments)
                .WithOne(c => c.Event)
                .HasForeignKey(c => c.EventId);
        });

        modelBuilder.Entity<CommentModel>(entity =>
        {
            entity.HasKey(c => c.Id); // Set Id as the primary key

            entity.Property(c => c.Comment)
                .IsRequired()
                .HasMaxLength(1000);

            entity.Property(c => c.User)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(c => c.Date)
                .IsRequired();

            entity.Property(c => c.Time)
                .IsRequired();

            entity.Property(c => c.EventId)
                .IsRequired();
        });

        modelBuilder.Entity<EventModel>().HasData(
        new EventModel
        {
            Id = new Guid("d1e1a1b1-c1d1-4e1f-8a1b-1c1d1e1f1a1b"),
            Title = "Sneaker Cleaning Workshop",
            Description = "Join us for a hands-on workshop where you'll learn the best techniques to clean and maintain your sneakers.",
            Date = new DateOnly(2024, 1, 15),
            Location = "Johannesburg",
            Venue = "Sandton Community Center",
            StartTime = new TimeSpan(10, 0, 0),
            EndTime = new TimeSpan(12, 0, 0)
        },
            new EventModel
            {
                Id = new Guid("d2e2a2b2-c2d2-4e2f-8a2b-2c2d2e2f2a2b"),
                Title = "Sneaker Swap Meet",
                Description = "Bring your old sneakers and swap them with others. A great way to refresh your collection!",
                Date = new DateOnly(2024, 2, 20),
                Location = "Pretoria",
                Venue = "Menlyn Park",
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(14, 0, 0)
            },
            new EventModel
            {
                Id = new Guid("d3e3a3b3-c3d3-4e3f-8a3b-3c3d3e3f3a3b"),
                Title = "Sneaker Art Customization",
                Description = "Express your creativity by customizing your sneakers with our art supplies and guidance from local artists.",
                Date = new DateOnly(2024, 3, 25),
                Location = "Midrand",
                Venue = "Mall of Africa",
                StartTime = new TimeSpan(13, 0, 0),
                EndTime = new TimeSpan(16, 0, 0)
            },
            new EventModel
            {
                Id = new Guid("d4e4a4b4-c4d4-4e4f-8a4b-4c4d4e4f4a4b"),
                Title = "Sneaker History Exhibit",
                Description = "Explore the history of sneakers with our curated exhibit featuring rare and iconic pairs.",
                Date = new DateOnly(2024, 4, 10),
                Location = "Johannesburg",
                Venue = "Apartheid Museum",
                StartTime = new TimeSpan(10, 0, 0),
                EndTime = new TimeSpan(17, 0, 0)
            },
            new EventModel
            {
                Id = new Guid("d5e5a5b5-c5d5-4e5f-8a5b-5c5d5e5f5a5b"),
                Title = "Sneaker Maintenance Tips & Tricks",
                Description = "Learn the best tips and tricks to keep your sneakers looking fresh and new.",
                Date = new DateOnly(2024, 5, 15),
                Location = "Soweto",
                Venue = "Walter Sisulu Square",
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0)
            },
            new EventModel
            {
                Id = new Guid("d6e6a6b6-c6d6-4e6f-8a6b-6c6d6e6f6a6b"),
                Title = "Sneaker Cleaning Competition",
                Description = "Show off your sneaker cleaning skills in our fun and friendly competition. Prizes for the best cleaned sneakers!",
                Date = new DateOnly(2024, 6, 20),
                Location = "Johannesburg",
                Venue = "Johannesburg Expo Centre",
                StartTime = new TimeSpan(12, 0, 0),
                EndTime = new TimeSpan(15, 0, 0)
            },
            new EventModel
            {
                Id = new Guid("d7e7a7b7-c7d7-4e7f-8a7b-7c7d7e7f7a7b"),
                Title = "Holiday Sneaker Giveaway",
                Description = "Celebrate the holiday season with our sneaker giveaway event. Free sneakers for those in need.",
                Date = new DateOnly(2024, 12, 13),
                Location = "Pretoria",
                Venue = "Union Buildings",
                StartTime = new TimeSpan(10, 0, 0),
                EndTime = new TimeSpan(13, 0, 0)
            },
            new EventModel
            {
                Id = new Guid("d8e8a8b8-c8d8-4e8f-8a8b-8c8d8e8f8a8b"),
                Title = "Sneaker Cleaning Workshop",
                Description = "Join us for a hands-on workshop where you'll learn the best techniques to clean and maintain your sneakers.",
                Date = new DateOnly(2025, 1, 15),
                Location = "Johannesburg",
                Venue = "Sandton Community Center",
                StartTime = new TimeSpan(10, 0, 0),
                EndTime = new TimeSpan(12, 0, 0)
            },
            new EventModel
            {
                Id = new Guid("d9e9a9b9-c9d9-4e9f-8a9b-9c9d9e9f9a9b"),
                Title = "Sneaker Swap Meet",
                Description = "Bring your old sneakers and swap them with others. A great way to refresh your collection!",
                Date = new DateOnly(2025, 2, 20),
                Location = "Pretoria",
                Venue = "Menlyn Park",
                StartTime = new TimeSpan(11, 0, 0),
                EndTime = new TimeSpan(14, 0, 0)
            },
            new EventModel
            {
                Id = new Guid("d0e0a0b0-c0d0-4e0f-8a0b-0c0d0e0f0a0b"),
                Title = "Sneaker Art Customization",
                Description = "Express your creativity by customizing your sneakers with our art supplies and guidance from local artists.",
                Date = new DateOnly(2025, 3, 25),
                Location = "Midrand",
                Venue = "Mall of Africa",
                StartTime = new TimeSpan(13, 0, 0),
                EndTime = new TimeSpan(16, 0, 0)
            },
            new EventModel
            {
                Id = new Guid("e1e1a1b1-c1d1-4e1f-8a1b-1c1d1e1f1a1b"),
                Title = "Sneaker History Exhibit",
                Description = "Explore the history of sneakers with our curated exhibit featuring rare and iconic pairs.",
                Date = new DateOnly(2025, 4, 10),
                Location = "Johannesburg",
                Venue = "Apartheid Museum",
                StartTime = new TimeSpan(10, 0, 0),
                EndTime = new TimeSpan(17, 0, 0)
            },
            new EventModel
            {
                Id = new Guid("e2e2a2b2-c2d2-4e2f-8a2b-2c2d2e2f2a2b"),
                Title = "Sneaker Maintenance Tips & Tricks",
                Description = "Learn the best tips and tricks to keep your sneakers looking fresh and new.",
                Date = new DateOnly(2025, 5, 15),
                Location = "Soweto",
                Venue = "Walter Sisulu Square",
                StartTime = new TimeSpan(14, 0, 0),
                EndTime = new TimeSpan(16, 0, 0)
            },
            new EventModel
            {
                Id = new Guid("e3e3a3b3-c3d3-4e3f-8a3b-3c3d3e3f3a3b"),
                Title = "Sneaker Cleaning Competition",
                Description = "Show off your sneaker cleaning skills in our fun and friendly competition. Prizes for the best cleaned sneakers!",
                Date = new DateOnly(2025, 6, 20),
                Location = "Johannesburg",
                Venue = "Johannesburg Expo Centre",
                StartTime = new TimeSpan(12, 0, 0),
                EndTime = new TimeSpan(15, 0, 0)
            },
            new EventModel
            {
                Id = new Guid("e4e4a4b4-c4d4-4e4f-8a4b-4c4d4e4f4a4b"),
                Title = "Holiday Sneaker Giveaway",
                Description = "Celebrate the holiday season with our sneaker giveaway event. Free sneakers for those in need.",
                Date = new DateOnly(2025, 12, 13),
                Location = "Pretoria",
                Venue = "Union Buildings",
                StartTime = new TimeSpan(10, 0, 0),
                EndTime = new TimeSpan(13, 0, 0)
            },
            new EventModel
            {
                Id = new Guid("e5e5a5b5-c5d5-4e5f-8a5b-5c5d5e5f5a5b"),
                Title = "Sneaker Cleaning Workshop",
                Description = "Join us for a hands-on workshop where you'll learn the best techniques to clean and maintain your sneakers.",
                Date = new DateOnly(2025, 7, 15),
                Location = "Johannesburg",
                Venue = "Sandton Community Center",
                StartTime = new TimeSpan(10, 0, 0),
                EndTime = new TimeSpan(12, 0, 0)
            }
        );

        modelBuilder.Entity<CommentModel>().HasData(
            new CommentModel
            {
                Id = new Guid("a1e1a1b1-c1d1-4e1f-8a1b-1c1d1e1f1a1b"),
                Comment = "Great event! Learned a lot about sneaker cleaning. The tips were very practical and easy to follow.",
                User = "JohnDoe",
                Date = new DateOnly(2024, 1, 15),
                Time = new TimeSpan(10, 30, 0),
                EventId = new Guid("d1e1a1b1-c1d1-4e1f-8a1b-1c1d1e1f1a1b")
            },
            new CommentModel
            {
                Id = new Guid("a2e2a2b2-c2d2-4e2f-8a2b-2c2d2e2f2a2b"),
                Comment = "Had a fantastic time at the Sneaker Swap Meet! Met some great people and found some awesome sneakers.",
                User = "JaneSmith",
                Date = new DateOnly(2024, 2, 20),
                Time = new TimeSpan(12, 0, 0),
                EventId = new Guid("d2e2a2b2-c2d2-4e2f-8a2b-2c2d2e2f2a2b")
            },
            new CommentModel
            {
                Id = new Guid("a3e3a3b3-c3d3-4e3f-8a3b-3c3d3e3f3a3b"),
                Comment = "Loved customizing my sneakers at the art event. The artists were very helpful and inspiring.",
                User = "MikeJohnson",
                Date = new DateOnly(2024, 3, 25),
                Time = new TimeSpan(14, 0, 0),
                EventId = new Guid("d3e3a3b3-c3d3-4e3f-8a3b-3c3d3e3f3a3b")
            },
            new CommentModel
            {
                Id = new Guid("a4e4a4b4-c4d4-4e4f-8a4b-4c4d4e4f4a4b"),
                Comment = "The Sneaker History Exhibit was very informative. I learned so much about the evolution of sneakers.",
                User = "EmilyDavis",
                Date = new DateOnly(2024, 4, 10),
                Time = new TimeSpan(11, 0, 0),
                EventId = new Guid("d4e4a4b4-c4d4-4e4f-8a4b-4c4d4e4f4a4b")
            },
            new CommentModel
            {
                Id = new Guid("a5e5a5b5-c5d5-4e5f-8a5b-5c5d5e5f5a5b"),
                Comment = "Got some great tips on sneaker maintenance. My sneakers have never looked better!",
                User = "ChrisBrown",
                Date = new DateOnly(2024, 5, 15),
                Time = new TimeSpan(15, 0, 0),
                EventId = new Guid("d5e5a5b5-c5d5-4e5f-8a5b-5c5d5e5f5a5b")
            },
            new CommentModel
            {
                Id = new Guid("a6e6a6b6-c6d6-4e6f-8a6b-6c6d6e6f6a6b"),
                Comment = "The competition was intense but fun! I didn't win, but I learned a lot about cleaning techniques.",
                User = "SarahConnor",
                Date = new DateOnly(2024, 6, 20),
                Time = new TimeSpan(13, 0, 0),
                EventId = new Guid("d6e6a6b6-c6d6-4e6f-8a6b-6c6d6e6f6a6b")
            },
            new CommentModel
            {
                Id = new Guid("a7e7a7b7-c7d7-4e7f-8a7b-7c7d7e7f7a7b"),
                Comment = "The sneaker giveaway was heartwarming. It was great to see so many people getting new sneakers.",
                User = "TomHanks",
                Date = new DateOnly(2024, 12, 13),
                Time = new TimeSpan(11, 0, 0),
                EventId = new Guid("d7e7a7b7-c7d7-4e7f-8a7b-7c7d7e7f7a7b")
            },
            new CommentModel
            {
                Id = new Guid("a8e8a8b8-c8d8-4e8f-8a8b-8c8d8e8f8a8b"),
                Comment = "Learned so much at the workshop! The instructors were very knowledgeable and helpful.",
                User = "AliceWalker",
                Date = new DateOnly(2025, 1, 15),
                Time = new TimeSpan(11, 30, 0),
                EventId = new Guid("d8e8a8b8-c8d8-4e8f-8a8b-8c8d8e8f8a8b")
            },
            new CommentModel
            {
                Id = new Guid("a9e9a9b9-c9d9-4e9f-8a9b-9c9d9e9f9a9b"),
                Comment = "Swapped some great sneakers! The event was well organized and everyone was very friendly.",
                User = "BobMarley",
                Date = new DateOnly(2025, 2, 20),
                Time = new TimeSpan(12, 30, 0),
                EventId = new Guid("d9e9a9b9-c9d9-4e9f-8a9b-9c9d9e9f9a9b")
            },
            new CommentModel
            {
                Id = new Guid("a0e0a0b0-c0d0-4e0f-8a0b-0c0d0e0f0a0b"),
                Comment = "The customization event was amazing! I created a unique pair of sneakers that I'm really proud of.",
                User = "CharlieBrown",
                Date = new DateOnly(2025, 3, 25),
                Time = new TimeSpan(14, 30, 0),
                EventId = new Guid("d0e0a0b0-c0d0-4e0f-8a0b-0c0d0e0f0a0b")
            }
        );
    }
}