using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogMedia.Migrations
{
    /// <inheritdoc />
    public partial class SeedingInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, null, "Technology" },
                    { 2, null, "Heath" },
                    { 3, null, "LifeStyle" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Author", "CategoryId", "Content", "FeatureImagePath", "PublishDate", "Title" },
                values: new object[,]
                {
                    { 1, "Maksud Mubin", 1, "Artificial intelligence (AI) is rapidly transforming the way we live and work. From self-driving cars to virtual assistants, AI is becoming an integral part of our daily lives. In this article, we will explore the future of AI and how it is changing the world.", "tech_image.jpg", new DateTime(2026, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Future of AI: How Artificial Intelligence is Changing the World" },
                    { 2, "Afsin Binte", 2, "A healthy lifestyle includes eating balanced meals, exercising regularly, and maintaining proper hydration.", "health_image.jpg", new DateTime(2026, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "How To Eat Healthy" },
                    { 3, "Nahar", 3, "Japanese cuisine is famous for its fresh ingredients, unique flavors, and artistic presentation.", "lifestyle_image.jpg", new DateTime(2026, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Exploring Japanese Cuisine" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
