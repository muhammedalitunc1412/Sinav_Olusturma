using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SınavOluşturma.Data.Migrations
{
    public partial class InititalCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tests",
                columns: table => new
                {
                    testId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    content = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    userId = table.Column<int>(type: "int", nullable: false),
                    key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tests", x => x.testId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    userId = table.Column<int>(type: "int", nullable: false),
                    userName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.userId);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    questionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    testId = table.Column<int>(type: "int", nullable: false),
                    question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    selectedFirst = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    selectedSecond = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    selectedThird = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    selectedFourth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.questionId);
                    table.ForeignKey(
                        name: "FK_Questions_Tests_testId",
                        column: x => x.testId,
                        principalTable: "Tests",
                        principalColumn: "testId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "testId", "IsDeleted", "content", "createdDate", "key", "title", "userId" },
                values: new object[] { 1, false, "muhammedalitunc", new DateTime(2021, 7, 4, 13, 11, 17, 118, DateTimeKind.Local).AddTicks(5804), "key", "muhammedalitunc", 1 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "IsDeleted", "userName", "userPassword" },
                values: new object[] { 1, false, "muhammedalitunc", "muhammedalitunc" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "questionId", "Answer", "IsDeleted", "question", "selectedFirst", "selectedFourth", "selectedSecond", "selectedThird", "testId" },
                values: new object[] { 1, "question", false, "question", "question", "question", "question", "question", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Questions_testId",
                table: "Questions",
                column: "testId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Tests");
        }
    }
}
