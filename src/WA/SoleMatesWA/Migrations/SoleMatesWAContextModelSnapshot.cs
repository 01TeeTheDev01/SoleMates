﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SoleMatesWA.Data;

#nullable disable

namespace SoleMatesWA.Migrations
{
    [DbContext(typeof(SoleMatesWAContext))]
    partial class SoleMatesWAContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("SoleMatesWA.Models.CommentModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<Guid>("EventId")
                        .HasColumnType("uuid");

                    b.Property<TimeSpan>("Time")
                        .HasColumnType("interval");

                    b.Property<string>("User")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a1e1a1b1-c1d1-4e1f-8a1b-1c1d1e1f1a1b"),
                            Comment = "Great event! Learned a lot about sneaker cleaning. The tips were very practical and easy to follow.",
                            Date = new DateOnly(2024, 1, 15),
                            EventId = new Guid("d1e1a1b1-c1d1-4e1f-8a1b-1c1d1e1f1a1b"),
                            Time = new TimeSpan(0, 10, 30, 0, 0),
                            User = "JohnDoe"
                        },
                        new
                        {
                            Id = new Guid("a2e2a2b2-c2d2-4e2f-8a2b-2c2d2e2f2a2b"),
                            Comment = "Had a fantastic time at the Sneaker Swap Meet! Met some great people and found some awesome sneakers.",
                            Date = new DateOnly(2024, 2, 20),
                            EventId = new Guid("d2e2a2b2-c2d2-4e2f-8a2b-2c2d2e2f2a2b"),
                            Time = new TimeSpan(0, 12, 0, 0, 0),
                            User = "JaneSmith"
                        },
                        new
                        {
                            Id = new Guid("a3e3a3b3-c3d3-4e3f-8a3b-3c3d3e3f3a3b"),
                            Comment = "Loved customizing my sneakers at the art event. The artists were very helpful and inspiring.",
                            Date = new DateOnly(2024, 3, 25),
                            EventId = new Guid("d3e3a3b3-c3d3-4e3f-8a3b-3c3d3e3f3a3b"),
                            Time = new TimeSpan(0, 14, 0, 0, 0),
                            User = "MikeJohnson"
                        },
                        new
                        {
                            Id = new Guid("a4e4a4b4-c4d4-4e4f-8a4b-4c4d4e4f4a4b"),
                            Comment = "The Sneaker History Exhibit was very informative. I learned so much about the evolution of sneakers.",
                            Date = new DateOnly(2024, 4, 10),
                            EventId = new Guid("d4e4a4b4-c4d4-4e4f-8a4b-4c4d4e4f4a4b"),
                            Time = new TimeSpan(0, 11, 0, 0, 0),
                            User = "EmilyDavis"
                        },
                        new
                        {
                            Id = new Guid("a5e5a5b5-c5d5-4e5f-8a5b-5c5d5e5f5a5b"),
                            Comment = "Got some great tips on sneaker maintenance. My sneakers have never looked better!",
                            Date = new DateOnly(2024, 5, 15),
                            EventId = new Guid("d5e5a5b5-c5d5-4e5f-8a5b-5c5d5e5f5a5b"),
                            Time = new TimeSpan(0, 15, 0, 0, 0),
                            User = "ChrisBrown"
                        },
                        new
                        {
                            Id = new Guid("a6e6a6b6-c6d6-4e6f-8a6b-6c6d6e6f6a6b"),
                            Comment = "The competition was intense but fun! I didn't win, but I learned a lot about cleaning techniques.",
                            Date = new DateOnly(2024, 6, 20),
                            EventId = new Guid("d6e6a6b6-c6d6-4e6f-8a6b-6c6d6e6f6a6b"),
                            Time = new TimeSpan(0, 13, 0, 0, 0),
                            User = "SarahConnor"
                        },
                        new
                        {
                            Id = new Guid("a7e7a7b7-c7d7-4e7f-8a7b-7c7d7e7f7a7b"),
                            Comment = "The sneaker giveaway was heartwarming. It was great to see so many people getting new sneakers.",
                            Date = new DateOnly(2024, 12, 13),
                            EventId = new Guid("d7e7a7b7-c7d7-4e7f-8a7b-7c7d7e7f7a7b"),
                            Time = new TimeSpan(0, 11, 0, 0, 0),
                            User = "TomHanks"
                        },
                        new
                        {
                            Id = new Guid("a8e8a8b8-c8d8-4e8f-8a8b-8c8d8e8f8a8b"),
                            Comment = "Learned so much at the workshop! The instructors were very knowledgeable and helpful.",
                            Date = new DateOnly(2025, 1, 15),
                            EventId = new Guid("d8e8a8b8-c8d8-4e8f-8a8b-8c8d8e8f8a8b"),
                            Time = new TimeSpan(0, 11, 30, 0, 0),
                            User = "AliceWalker"
                        },
                        new
                        {
                            Id = new Guid("a9e9a9b9-c9d9-4e9f-8a9b-9c9d9e9f9a9b"),
                            Comment = "Swapped some great sneakers! The event was well organized and everyone was very friendly.",
                            Date = new DateOnly(2025, 2, 20),
                            EventId = new Guid("d9e9a9b9-c9d9-4e9f-8a9b-9c9d9e9f9a9b"),
                            Time = new TimeSpan(0, 12, 30, 0, 0),
                            User = "BobMarley"
                        },
                        new
                        {
                            Id = new Guid("a0e0a0b0-c0d0-4e0f-8a0b-0c0d0e0f0a0b"),
                            Comment = "The customization event was amazing! I created a unique pair of sneakers that I'm really proud of.",
                            Date = new DateOnly(2025, 3, 25),
                            EventId = new Guid("d0e0a0b0-c0d0-4e0f-8a0b-0c0d0e0f0a0b"),
                            Time = new TimeSpan(0, 14, 30, 0, 0),
                            User = "CharlieBrown"
                        });
                });

            modelBuilder.Entity("SoleMatesWA.Models.EventModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("interval");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("interval");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Venue")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("Id");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d1e1a1b1-c1d1-4e1f-8a1b-1c1d1e1f1a1b"),
                            Date = new DateOnly(2024, 1, 15),
                            Description = "Join us for a hands-on workshop where you'll learn the best techniques to clean and maintain your sneakers.",
                            EndTime = new TimeSpan(0, 12, 0, 0, 0),
                            Location = "Johannesburg",
                            StartTime = new TimeSpan(0, 10, 0, 0, 0),
                            Title = "Sneaker Cleaning Workshop",
                            Venue = "Sandton Community Center"
                        },
                        new
                        {
                            Id = new Guid("d2e2a2b2-c2d2-4e2f-8a2b-2c2d2e2f2a2b"),
                            Date = new DateOnly(2024, 2, 20),
                            Description = "Bring your old sneakers and swap them with others. A great way to refresh your collection!",
                            EndTime = new TimeSpan(0, 14, 0, 0, 0),
                            Location = "Pretoria",
                            StartTime = new TimeSpan(0, 11, 0, 0, 0),
                            Title = "Sneaker Swap Meet",
                            Venue = "Menlyn Park"
                        },
                        new
                        {
                            Id = new Guid("d3e3a3b3-c3d3-4e3f-8a3b-3c3d3e3f3a3b"),
                            Date = new DateOnly(2024, 3, 25),
                            Description = "Express your creativity by customizing your sneakers with our art supplies and guidance from local artists.",
                            EndTime = new TimeSpan(0, 16, 0, 0, 0),
                            Location = "Midrand",
                            StartTime = new TimeSpan(0, 13, 0, 0, 0),
                            Title = "Sneaker Art Customization",
                            Venue = "Mall of Africa"
                        },
                        new
                        {
                            Id = new Guid("d4e4a4b4-c4d4-4e4f-8a4b-4c4d4e4f4a4b"),
                            Date = new DateOnly(2024, 4, 10),
                            Description = "Explore the history of sneakers with our curated exhibit featuring rare and iconic pairs.",
                            EndTime = new TimeSpan(0, 17, 0, 0, 0),
                            Location = "Johannesburg",
                            StartTime = new TimeSpan(0, 10, 0, 0, 0),
                            Title = "Sneaker History Exhibit",
                            Venue = "Apartheid Museum"
                        },
                        new
                        {
                            Id = new Guid("d5e5a5b5-c5d5-4e5f-8a5b-5c5d5e5f5a5b"),
                            Date = new DateOnly(2024, 5, 15),
                            Description = "Learn the best tips and tricks to keep your sneakers looking fresh and new.",
                            EndTime = new TimeSpan(0, 16, 0, 0, 0),
                            Location = "Soweto",
                            StartTime = new TimeSpan(0, 14, 0, 0, 0),
                            Title = "Sneaker Maintenance Tips & Tricks",
                            Venue = "Walter Sisulu Square"
                        },
                        new
                        {
                            Id = new Guid("d6e6a6b6-c6d6-4e6f-8a6b-6c6d6e6f6a6b"),
                            Date = new DateOnly(2024, 6, 20),
                            Description = "Show off your sneaker cleaning skills in our fun and friendly competition. Prizes for the best cleaned sneakers!",
                            EndTime = new TimeSpan(0, 15, 0, 0, 0),
                            Location = "Johannesburg",
                            StartTime = new TimeSpan(0, 12, 0, 0, 0),
                            Title = "Sneaker Cleaning Competition",
                            Venue = "Johannesburg Expo Centre"
                        },
                        new
                        {
                            Id = new Guid("d7e7a7b7-c7d7-4e7f-8a7b-7c7d7e7f7a7b"),
                            Date = new DateOnly(2024, 12, 13),
                            Description = "Celebrate the holiday season with our sneaker giveaway event. Free sneakers for those in need.",
                            EndTime = new TimeSpan(0, 13, 0, 0, 0),
                            Location = "Pretoria",
                            StartTime = new TimeSpan(0, 10, 0, 0, 0),
                            Title = "Holiday Sneaker Giveaway",
                            Venue = "Union Buildings"
                        },
                        new
                        {
                            Id = new Guid("d8e8a8b8-c8d8-4e8f-8a8b-8c8d8e8f8a8b"),
                            Date = new DateOnly(2025, 1, 15),
                            Description = "Join us for a hands-on workshop where you'll learn the best techniques to clean and maintain your sneakers.",
                            EndTime = new TimeSpan(0, 12, 0, 0, 0),
                            Location = "Johannesburg",
                            StartTime = new TimeSpan(0, 10, 0, 0, 0),
                            Title = "Sneaker Cleaning Workshop",
                            Venue = "Sandton Community Center"
                        },
                        new
                        {
                            Id = new Guid("d9e9a9b9-c9d9-4e9f-8a9b-9c9d9e9f9a9b"),
                            Date = new DateOnly(2025, 2, 20),
                            Description = "Bring your old sneakers and swap them with others. A great way to refresh your collection!",
                            EndTime = new TimeSpan(0, 14, 0, 0, 0),
                            Location = "Pretoria",
                            StartTime = new TimeSpan(0, 11, 0, 0, 0),
                            Title = "Sneaker Swap Meet",
                            Venue = "Menlyn Park"
                        },
                        new
                        {
                            Id = new Guid("d0e0a0b0-c0d0-4e0f-8a0b-0c0d0e0f0a0b"),
                            Date = new DateOnly(2025, 3, 25),
                            Description = "Express your creativity by customizing your sneakers with our art supplies and guidance from local artists.",
                            EndTime = new TimeSpan(0, 16, 0, 0, 0),
                            Location = "Midrand",
                            StartTime = new TimeSpan(0, 13, 0, 0, 0),
                            Title = "Sneaker Art Customization",
                            Venue = "Mall of Africa"
                        },
                        new
                        {
                            Id = new Guid("e1e1a1b1-c1d1-4e1f-8a1b-1c1d1e1f1a1b"),
                            Date = new DateOnly(2025, 4, 10),
                            Description = "Explore the history of sneakers with our curated exhibit featuring rare and iconic pairs.",
                            EndTime = new TimeSpan(0, 17, 0, 0, 0),
                            Location = "Johannesburg",
                            StartTime = new TimeSpan(0, 10, 0, 0, 0),
                            Title = "Sneaker History Exhibit",
                            Venue = "Apartheid Museum"
                        },
                        new
                        {
                            Id = new Guid("e2e2a2b2-c2d2-4e2f-8a2b-2c2d2e2f2a2b"),
                            Date = new DateOnly(2025, 5, 15),
                            Description = "Learn the best tips and tricks to keep your sneakers looking fresh and new.",
                            EndTime = new TimeSpan(0, 16, 0, 0, 0),
                            Location = "Soweto",
                            StartTime = new TimeSpan(0, 14, 0, 0, 0),
                            Title = "Sneaker Maintenance Tips & Tricks",
                            Venue = "Walter Sisulu Square"
                        },
                        new
                        {
                            Id = new Guid("e3e3a3b3-c3d3-4e3f-8a3b-3c3d3e3f3a3b"),
                            Date = new DateOnly(2025, 6, 20),
                            Description = "Show off your sneaker cleaning skills in our fun and friendly competition. Prizes for the best cleaned sneakers!",
                            EndTime = new TimeSpan(0, 15, 0, 0, 0),
                            Location = "Johannesburg",
                            StartTime = new TimeSpan(0, 12, 0, 0, 0),
                            Title = "Sneaker Cleaning Competition",
                            Venue = "Johannesburg Expo Centre"
                        },
                        new
                        {
                            Id = new Guid("e4e4a4b4-c4d4-4e4f-8a4b-4c4d4e4f4a4b"),
                            Date = new DateOnly(2025, 12, 13),
                            Description = "Celebrate the holiday season with our sneaker giveaway event. Free sneakers for those in need.",
                            EndTime = new TimeSpan(0, 13, 0, 0, 0),
                            Location = "Pretoria",
                            StartTime = new TimeSpan(0, 10, 0, 0, 0),
                            Title = "Holiday Sneaker Giveaway",
                            Venue = "Union Buildings"
                        },
                        new
                        {
                            Id = new Guid("e5e5a5b5-c5d5-4e5f-8a5b-5c5d5e5f5a5b"),
                            Date = new DateOnly(2025, 7, 15),
                            Description = "Join us for a hands-on workshop where you'll learn the best techniques to clean and maintain your sneakers.",
                            EndTime = new TimeSpan(0, 12, 0, 0, 0),
                            Location = "Johannesburg",
                            StartTime = new TimeSpan(0, 10, 0, 0, 0),
                            Title = "Sneaker Cleaning Workshop",
                            Venue = "Sandton Community Center"
                        });
                });

            modelBuilder.Entity("SoleMatesWA.Models.CommentModel", b =>
                {
                    b.HasOne("SoleMatesWA.Models.EventModel", "Event")
                        .WithMany("Comments")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");
                });

            modelBuilder.Entity("SoleMatesWA.Models.EventModel", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
