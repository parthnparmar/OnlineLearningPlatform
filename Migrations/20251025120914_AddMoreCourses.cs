using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineLearningPlatform300.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreCourses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2025, 10, 25, 17, 39, 13, 855, DateTimeKind.Local).AddTicks(5638), 8299m });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2025, 10, 25, 17, 39, 13, 857, DateTimeKind.Local).AddTicks(7282), 10799m });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2025, 10, 25, 17, 39, 13, 857, DateTimeKind.Local).AddTicks(7317), 6599m });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "CreatedAt", "Description", "Duration", "ImageUrl", "Level", "Price", "Title" },
                values: new object[,]
                {
                    { 4, "Mobile Development", new DateTime(2025, 10, 25, 17, 39, 13, 857, DateTimeKind.Local).AddTicks(7358), "Build cross-platform mobile apps using Flutter and Dart", 45, "https://images.unsplash.com/photo-1512941937669-90a1b58e7e9c", "Intermediate", 9499m, "Mobile App Development with Flutter" },
                    { 5, "Cloud Computing", new DateTime(2025, 10, 25, 17, 39, 13, 857, DateTimeKind.Local).AddTicks(7398), "Master Amazon Web Services and cloud architecture", 50, "https://images.unsplash.com/photo-1451187580459-43490279c0fa", "Advanced", 12999m, "Cloud Computing with AWS" },
                    { 6, "Design", new DateTime(2025, 10, 25, 17, 39, 13, 857, DateTimeKind.Local).AddTicks(7403), "Learn design principles, Figma, and user experience design", 30, "https://images.unsplash.com/photo-1581291518857-4e27b48ff24e", "Beginner", 7299m, "UI/UX Design Fundamentals" },
                    { 7, "Cybersecurity", new DateTime(2025, 10, 25, 17, 39, 13, 857, DateTimeKind.Local).AddTicks(7407), "Protect systems and networks from digital attacks", 38, "https://images.unsplash.com/photo-1550751827-4bd374c3f58b", "Intermediate", 11499m, "Cybersecurity Essentials" },
                    { 8, "Blockchain", new DateTime(2025, 10, 25, 17, 39, 13, 857, DateTimeKind.Local).AddTicks(7412), "Build decentralized applications with Ethereum and Solidity", 42, "https://images.unsplash.com/photo-1639762681485-074b7f938ba0", "Advanced", 13799m, "Blockchain Development" },
                    { 9, "Artificial Intelligence", new DateTime(2025, 10, 25, 17, 39, 13, 857, DateTimeKind.Local).AddTicks(7416), "Deep learning, neural networks, and AI applications", 55, "https://images.unsplash.com/photo-1677442136019-21780ecad995", "Advanced", 14999m, "Artificial Intelligence with Python" },
                    { 10, "DevOps", new DateTime(2025, 10, 25, 17, 39, 13, 857, DateTimeKind.Local).AddTicks(7420), "Automate deployment with Docker, Kubernetes, and Jenkins", 40, "https://images.unsplash.com/photo-1618401471353-b98afee0b2eb", "Intermediate", 10299m, "DevOps and CI/CD Pipeline" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2025, 10, 25, 17, 28, 11, 846, DateTimeKind.Local).AddTicks(5552), 99m });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2025, 10, 25, 17, 28, 11, 847, DateTimeKind.Local).AddTicks(8177), 129m });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2025, 10, 25, 17, 28, 11, 847, DateTimeKind.Local).AddTicks(8201), 79m });
        }
    }
}
