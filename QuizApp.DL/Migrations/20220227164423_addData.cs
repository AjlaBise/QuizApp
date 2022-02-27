using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizApp.DL.Migrations
{
    public partial class addData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Correct = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserQuestions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QuestionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Points = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserQuestions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nickname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalPoints = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "Correct", "QuestionId", "Text" },
                values: new object[,]
                {
                    { new Guid("5c7d1550-90df-467d-bc83-26435548eef5"), false, new Guid("6cf76c06-901d-40b2-8ba7-7d12506a4faa"), "18 Months" },
                    { new Guid("6e6e2ef9-22d6-4e0d-bbe7-8f430b700307"), true, new Guid("6cf76c06-901d-40b2-8ba7-7d12506a4faa"), "22 Months" },
                    { new Guid("e4570234-10ea-4698-85d8-9a58923a42a8"), false, new Guid("6cf76c06-901d-40b2-8ba7-7d12506a4faa"), "28 Months" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0022ede5-f8f5-4de3-9db0-7742f9c9b933"), "Animal" },
                    { new Guid("271df7c1-6b22-416e-95b1-8dee7e27486d"), "Music" },
                    { new Guid("a8499f2f-a23d-428d-9369-8f8b7e2b4085"), "Sport" },
                    { new Guid("e7776350-4164-4176-9a87-15a32990ef66"), "Geography" }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "CategoryId", "Text" },
                values: new object[,]
                {
                    { new Guid("034a693c-dc37-464c-b61d-5b1a8a12aeaf"), new Guid("0022ede5-f8f5-4de3-9db0-7742f9c9b933"), "Which animal is known to spend 90% of its day, sleeping?" },
                    { new Guid("6cf76c06-901d-40b2-8ba7-7d12506a4faa"), new Guid("0022ede5-f8f5-4de3-9db0-7742f9c9b933"), "How long is an elephant pregnant before it gives birth?" },
                    { new Guid("e42b3dd0-336f-45cc-ac48-78c6a4775717"), new Guid("0022ede5-f8f5-4de3-9db0-7742f9c9b933"), "How far away can a wolf smell its prey?" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Nickname", "TotalPoints" },
                values: new object[,]
                {
                    { new Guid("548fc16c-36f3-472b-997a-6c4a75f9c9f3"), "GargEvil", 150 },
                    { new Guid("664d038a-90b0-4c88-baaf-8da05b9ab304"), "AjlaBise", 150 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "UserQuestions");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
