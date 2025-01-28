using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoleMatesWA.Migrations
{
    /// <inheritdoc />
    public partial class AddedMoreDetailToComments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("a0e0a0b0-c0d0-4e0f-8a0b-0c0d0e0f0a0b"),
                column: "Comment",
                value: "The customization event was amazing! I created a unique pair of sneakers that I'm really proud of.");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("a1e1a1b1-c1d1-4e1f-8a1b-1c1d1e1f1a1b"),
                column: "Comment",
                value: "Great event! Learned a lot about sneaker cleaning. The tips were very practical and easy to follow.");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("a2e2a2b2-c2d2-4e2f-8a2b-2c2d2e2f2a2b"),
                column: "Comment",
                value: "Had a fantastic time at the Sneaker Swap Meet! Met some great people and found some awesome sneakers.");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("a3e3a3b3-c3d3-4e3f-8a3b-3c3d3e3f3a3b"),
                column: "Comment",
                value: "Loved customizing my sneakers at the art event. The artists were very helpful and inspiring.");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("a4e4a4b4-c4d4-4e4f-8a4b-4c4d4e4f4a4b"),
                column: "Comment",
                value: "The Sneaker History Exhibit was very informative. I learned so much about the evolution of sneakers.");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("a5e5a5b5-c5d5-4e5f-8a5b-5c5d5e5f5a5b"),
                column: "Comment",
                value: "Got some great tips on sneaker maintenance. My sneakers have never looked better!");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("a6e6a6b6-c6d6-4e6f-8a6b-6c6d6e6f6a6b"),
                column: "Comment",
                value: "The competition was intense but fun! I didn't win, but I learned a lot about cleaning techniques.");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("a7e7a7b7-c7d7-4e7f-8a7b-7c7d7e7f7a7b"),
                column: "Comment",
                value: "The sneaker giveaway was heartwarming. It was great to see so many people getting new sneakers.");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("a8e8a8b8-c8d8-4e8f-8a8b-8c8d8e8f8a8b"),
                column: "Comment",
                value: "Learned so much at the workshop! The instructors were very knowledgeable and helpful.");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("a9e9a9b9-c9d9-4e9f-8a9b-9c9d9e9f9a9b"),
                column: "Comment",
                value: "Swapped some great sneakers! The event was well organized and everyone was very friendly.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("a0e0a0b0-c0d0-4e0f-8a0b-0c0d0e0f0a0b"),
                column: "Comment",
                value: "The customization event was amazing!");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("a1e1a1b1-c1d1-4e1f-8a1b-1c1d1e1f1a1b"),
                column: "Comment",
                value: "Great event! Learned a lot about sneaker cleaning.");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("a2e2a2b2-c2d2-4e2f-8a2b-2c2d2e2f2a2b"),
                column: "Comment",
                value: "Had a fantastic time at the Sneaker Swap Meet!");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("a3e3a3b3-c3d3-4e3f-8a3b-3c3d3e3f3a3b"),
                column: "Comment",
                value: "Loved customizing my sneakers at the art event.");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("a4e4a4b4-c4d4-4e4f-8a4b-4c4d4e4f4a4b"),
                column: "Comment",
                value: "The Sneaker History Exhibit was very informative.");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("a5e5a5b5-c5d5-4e5f-8a5b-5c5d5e5f5a5b"),
                column: "Comment",
                value: "Got some great tips on sneaker maintenance.");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("a6e6a6b6-c6d6-4e6f-8a6b-6c6d6e6f6a6b"),
                column: "Comment",
                value: "The competition was intense but fun!");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("a7e7a7b7-c7d7-4e7f-8a7b-7c7d7e7f7a7b"),
                column: "Comment",
                value: "The sneaker giveaway was heartwarming.");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("a8e8a8b8-c8d8-4e8f-8a8b-8c8d8e8f8a8b"),
                column: "Comment",
                value: "Learned so much at the workshop!");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("a9e9a9b9-c9d9-4e9f-8a9b-9c9d9e9f9a9b"),
                column: "Comment",
                value: "Swapped some great sneakers!");
        }
    }
}
