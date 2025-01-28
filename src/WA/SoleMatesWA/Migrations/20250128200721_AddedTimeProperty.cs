using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SoleMatesWA.Migrations
{
    /// <inheritdoc />
    public partial class AddedTimeProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("e6e6a6b6-c6d6-4e6f-8a6b-6c6d6e6f6a6b"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("e7e7a7b7-c7d7-4e7f-8a7b-7c7d7e7f7a7b"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("e8e8a8b8-c8d8-4e8f-8a8b-8c8d8e8f8a8b"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("e9e9a9b9-c9d9-4e9f-8a9b-9c9d9e9f9a9b"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("f0e0a0b0-c0d0-4e0f-8a0b-0c0d0e0f0a0b"));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "Time",
                table: "Comments",
                type: "interval",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("a1e1a1b1-c1d1-4e1f-8a1b-1c1d1e1f1a1b"),
                column: "Time",
                value: new TimeSpan(0, 10, 30, 0, 0));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("a2e2a2b2-c2d2-4e2f-8a2b-2c2d2e2f2a2b"),
                column: "Time",
                value: new TimeSpan(0, 12, 0, 0, 0));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("a3e3a3b3-c3d3-4e3f-8a3b-3c3d3e3f3a3b"),
                column: "Time",
                value: new TimeSpan(0, 14, 0, 0, 0));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("a4e4a4b4-c4d4-4e4f-8a4b-4c4d4e4f4a4b"),
                column: "Time",
                value: new TimeSpan(0, 11, 0, 0, 0));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("a5e5a5b5-c5d5-4e5f-8a5b-5c5d5e5f5a5b"),
                column: "Time",
                value: new TimeSpan(0, 15, 0, 0, 0));

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Comment", "Date", "EventId", "Time", "User" },
                values: new object[,]
                {
                    { new Guid("a0e0a0b0-c0d0-4e0f-8a0b-0c0d0e0f0a0b"), "The customization event was amazing!", new DateOnly(2025, 3, 25), new Guid("d0e0a0b0-c0d0-4e0f-8a0b-0c0d0e0f0a0b"), new TimeSpan(0, 14, 30, 0, 0), "CharlieBrown" },
                    { new Guid("a6e6a6b6-c6d6-4e6f-8a6b-6c6d6e6f6a6b"), "The competition was intense but fun!", new DateOnly(2024, 6, 20), new Guid("d6e6a6b6-c6d6-4e6f-8a6b-6c6d6e6f6a6b"), new TimeSpan(0, 13, 0, 0, 0), "SarahConnor" },
                    { new Guid("a7e7a7b7-c7d7-4e7f-8a7b-7c7d7e7f7a7b"), "The sneaker giveaway was heartwarming.", new DateOnly(2024, 12, 13), new Guid("d7e7a7b7-c7d7-4e7f-8a7b-7c7d7e7f7a7b"), new TimeSpan(0, 11, 0, 0, 0), "TomHanks" },
                    { new Guid("a8e8a8b8-c8d8-4e8f-8a8b-8c8d8e8f8a8b"), "Learned so much at the workshop!", new DateOnly(2025, 1, 15), new Guid("d8e8a8b8-c8d8-4e8f-8a8b-8c8d8e8f8a8b"), new TimeSpan(0, 11, 30, 0, 0), "AliceWalker" },
                    { new Guid("a9e9a9b9-c9d9-4e9f-8a9b-9c9d9e9f9a9b"), "Swapped some great sneakers!", new DateOnly(2025, 2, 20), new Guid("d9e9a9b9-c9d9-4e9f-8a9b-9c9d9e9f9a9b"), new TimeSpan(0, 12, 30, 0, 0), "BobMarley" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("a0e0a0b0-c0d0-4e0f-8a0b-0c0d0e0f0a0b"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("a6e6a6b6-c6d6-4e6f-8a6b-6c6d6e6f6a6b"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("a7e7a7b7-c7d7-4e7f-8a7b-7c7d7e7f7a7b"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("a8e8a8b8-c8d8-4e8f-8a8b-8c8d8e8f8a8b"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("a9e9a9b9-c9d9-4e9f-8a9b-9c9d9e9f9a9b"));

            migrationBuilder.DropColumn(
                name: "Time",
                table: "Comments");

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Date", "Description", "EndTime", "Location", "StartTime", "Title", "Venue" },
                values: new object[,]
                {
                    { new Guid("e1e1a1b1-c1d1-4e1f-8a1b-1c1d1e1f1a1b"), new DateOnly(2025, 4, 10), "Explore the history of sneakers with our curated exhibit featuring rare and iconic pairs.", new TimeSpan(0, 17, 0, 0, 0), "Johannesburg", new TimeSpan(0, 10, 0, 0, 0), "Sneaker History Exhibit", "Apartheid Museum" },
                    { new Guid("e2e2a2b2-c2d2-4e2f-8a2b-2c2d2e2f2a2b"), new DateOnly(2025, 5, 15), "Learn the best tips and tricks to keep your sneakers looking fresh and new.", new TimeSpan(0, 16, 0, 0, 0), "Soweto", new TimeSpan(0, 14, 0, 0, 0), "Sneaker Maintenance Tips & Tricks", "Walter Sisulu Square" },
                    { new Guid("e3e3a3b3-c3d3-4e3f-8a3b-3c3d3e3f3a3b"), new DateOnly(2025, 6, 20), "Show off your sneaker cleaning skills in our fun and friendly competition. Prizes for the best cleaned sneakers!", new TimeSpan(0, 15, 0, 0, 0), "Johannesburg", new TimeSpan(0, 12, 0, 0, 0), "Sneaker Cleaning Competition", "Johannesburg Expo Centre" },
                    { new Guid("e4e4a4b4-c4d4-4e4f-8a4b-4c4d4e4f4a4b"), new DateOnly(2025, 12, 13), "Celebrate the holiday season with our sneaker giveaway event. Free sneakers for those in need.", new TimeSpan(0, 13, 0, 0, 0), "Pretoria", new TimeSpan(0, 10, 0, 0, 0), "Holiday Sneaker Giveaway", "Union Buildings" },
                    { new Guid("e5e5a5b5-c5d5-4e5f-8a5b-5c5d5e5f5a5b"), new DateOnly(2025, 7, 15), "Join us for a hands-on workshop where you'll learn the best techniques to clean and maintain your sneakers.", new TimeSpan(0, 12, 0, 0, 0), "Johannesburg", new TimeSpan(0, 10, 0, 0, 0), "Sneaker Cleaning Workshop", "Sandton Community Center" },
                    { new Guid("e6e6a6b6-c6d6-4e6f-8a6b-6c6d6e6f6a6b"), new DateOnly(2025, 8, 20), "Bring your old sneakers and swap them with others. A great way to refresh your collection!", new TimeSpan(0, 14, 0, 0, 0), "Pretoria", new TimeSpan(0, 11, 0, 0, 0), "Sneaker Swap Meet", "Menlyn Park" },
                    { new Guid("e7e7a7b7-c7d7-4e7f-8a7b-7c7d7e7f7a7b"), new DateOnly(2025, 9, 25), "Express your creativity by customizing your sneakers with our art supplies and guidance from local artists.", new TimeSpan(0, 16, 0, 0, 0), "Midrand", new TimeSpan(0, 13, 0, 0, 0), "Sneaker Art Customization", "Mall of Africa" },
                    { new Guid("e8e8a8b8-c8d8-4e8f-8a8b-8c8d8e8f8a8b"), new DateOnly(2025, 10, 10), "Explore the history of sneakers with our curated exhibit featuring rare and iconic pairs.", new TimeSpan(0, 17, 0, 0, 0), "Johannesburg", new TimeSpan(0, 10, 0, 0, 0), "Sneaker History Exhibit", "Apartheid Museum" },
                    { new Guid("e9e9a9b9-c9d9-4e9f-8a9b-9c9d9e9f9a9b"), new DateOnly(2025, 11, 15), "Learn the best tips and tricks to keep your sneakers looking fresh and new.", new TimeSpan(0, 16, 0, 0, 0), "Soweto", new TimeSpan(0, 14, 0, 0, 0), "Sneaker Maintenance Tips & Tricks", "Walter Sisulu Square" },
                    { new Guid("f0e0a0b0-c0d0-4e0f-8a0b-0c0d0e0f0a0b"), new DateOnly(2025, 12, 20), "Show off your sneaker cleaning skills in our fun and friendly competition. Prizes for the best cleaned sneakers!", new TimeSpan(0, 15, 0, 0, 0), "Johannesburg", new TimeSpan(0, 12, 0, 0, 0), "Sneaker Cleaning Competition", "Johannesburg Expo Centre" }
                });
        }
    }
}
