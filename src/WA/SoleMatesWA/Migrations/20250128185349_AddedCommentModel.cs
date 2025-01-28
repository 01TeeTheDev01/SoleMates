using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SoleMatesWA.Migrations
{
    /// <inheritdoc />
    public partial class AddedCommentModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Comment = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    User = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    EventId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Comment", "Date", "EventId", "User" },
                values: new object[,]
                {
                    { new Guid("a1e1a1b1-c1d1-4e1f-8a1b-1c1d1e1f1a1b"), "Great event! Learned a lot about sneaker cleaning.", new DateOnly(2024, 1, 15), new Guid("d1e1a1b1-c1d1-4e1f-8a1b-1c1d1e1f1a1b"), "JohnDoe" },
                    { new Guid("a2e2a2b2-c2d2-4e2f-8a2b-2c2d2e2f2a2b"), "Had a fantastic time at the Sneaker Swap Meet!", new DateOnly(2024, 2, 20), new Guid("d2e2a2b2-c2d2-4e2f-8a2b-2c2d2e2f2a2b"), "JaneSmith" },
                    { new Guid("a3e3a3b3-c3d3-4e3f-8a3b-3c3d3e3f3a3b"), "Loved customizing my sneakers at the art event.", new DateOnly(2024, 3, 25), new Guid("d3e3a3b3-c3d3-4e3f-8a3b-3c3d3e3f3a3b"), "MikeJohnson" },
                    { new Guid("a4e4a4b4-c4d4-4e4f-8a4b-4c4d4e4f4a4b"), "The Sneaker History Exhibit was very informative.", new DateOnly(2024, 4, 10), new Guid("d4e4a4b4-c4d4-4e4f-8a4b-4c4d4e4f4a4b"), "EmilyDavis" },
                    { new Guid("a5e5a5b5-c5d5-4e5f-8a5b-5c5d5e5f5a5b"), "Got some great tips on sneaker maintenance.", new DateOnly(2024, 5, 15), new Guid("d5e5a5b5-c5d5-4e5f-8a5b-5c5d5e5f5a5b"), "ChrisBrown" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_EventId",
                table: "Comments",
                column: "EventId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");
        }
    }
}
