using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SoleMatesWA.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedEventDates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Date", "Description", "EndTime", "Location", "StartTime", "Title", "Venue" },
                values: new object[,]
                {
                    { new Guid("e1e1a1b1-c1d1-4e1f-8a1b-1c1d1e1f1a1b"), new DateOnly(2025, 4, 10), "Explore the history of sneakers with our curated exhibit featuring rare and iconic pairs.", new TimeSpan(0, 17, 0, 0, 0), "Johannesburg", new TimeSpan(0, 10, 0, 0, 0), "Sneaker History Exhibit", "Apartheid Museum" },
                    { new Guid("e2e2a2b2-c2d2-4e2f-8a2b-2c2d2e2f2a2b"), new DateOnly(2025, 5, 15), "Learn the best tips and tricks to keep your sneakers looking fresh and new.", new TimeSpan(0, 16, 0, 0, 0), "Soweto", new TimeSpan(0, 14, 0, 0, 0), "Sneaker Maintenance Tips & Tricks", "Walter Sisulu Square" },
                    { new Guid("e3e3a3b3-c3d3-4e3f-8a3b-3c3d3e3f3a3b"), new DateOnly(2025, 6, 20), "Show off your sneaker cleaning skills in our fun and friendly competition. Prizes for the best cleaned sneakers!", new TimeSpan(0, 15, 0, 0, 0), "Johannesburg", new TimeSpan(0, 12, 0, 0, 0), "Sneaker Cleaning Competition", "Johannesburg Expo Centre" },
                    { new Guid("e4e4a4b4-c4d4-4e4f-8a4b-4c4d4e4f4a4b"), new DateOnly(2025, 12, 13), "Celebrate the holiday season with our sneaker giveaway event. Free sneakers for those in need.", new TimeSpan(0, 13, 0, 0, 0), "Pretoria", new TimeSpan(0, 10, 0, 0, 0), "Holiday Sneaker Giveaway", "Union Buildings" },
                    { new Guid("e5e5a5b5-c5d5-4e5f-8a5b-5c5d5e5f5a5b"), new DateOnly(2025, 7, 15), "Join us for a hands-on workshop where you'll learn the best techniques to clean and maintain your sneakers.", new TimeSpan(0, 12, 0, 0, 0), "Johannesburg", new TimeSpan(0, 10, 0, 0, 0), "Sneaker Cleaning Workshop", "Sandton Community Center" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("e1e1a1b1-c1d1-4e1f-8a1b-1c1d1e1f1a1b"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("e2e2a2b2-c2d2-4e2f-8a2b-2c2d2e2f2a2b"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("e3e3a3b3-c3d3-4e3f-8a3b-3c3d3e3f3a3b"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("e4e4a4b4-c4d4-4e4f-8a4b-4c4d4e4f4a4b"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("e5e5a5b5-c5d5-4e5f-8a5b-5c5d5e5f5a5b"));
        }
    }
}
