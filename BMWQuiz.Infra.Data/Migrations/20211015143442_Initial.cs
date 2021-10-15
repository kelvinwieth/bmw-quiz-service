using Microsoft.EntityFrameworkCore.Migrations;

namespace BMWQuiz.Infra.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "answer",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    description = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_answer", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "question",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    description = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_question", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "question_option",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    question_id = table.Column<int>(type: "INTEGER", nullable: false),
                    answer_id = table.Column<int>(type: "INTEGER", nullable: false),
                    is_correct = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_question_option", x => x.id);
                    table.ForeignKey(
                        name: "FK_question_option_answer_answer_id",
                        column: x => x.answer_id,
                        principalTable: "answer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_question_option_question_question_id",
                        column: x => x.question_id,
                        principalTable: "question",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "answer",
                columns: new[] { "id", "description" },
                values: new object[] { 1, "Inglaterra" });

            migrationBuilder.InsertData(
                table: "answer",
                columns: new[] { "id", "description" },
                values: new object[] { 2, "USA" });

            migrationBuilder.InsertData(
                table: "answer",
                columns: new[] { "id", "description" },
                values: new object[] { 3, "Alemanha" });

            migrationBuilder.InsertData(
                table: "answer",
                columns: new[] { "id", "description" },
                values: new object[] { 4, "Japão" });

            migrationBuilder.InsertData(
                table: "question",
                columns: new[] { "id", "description" },
                values: new object[] { 1, "BMW" });

            migrationBuilder.InsertData(
                table: "question",
                columns: new[] { "id", "description" },
                values: new object[] { 2, "Toyota" });

            migrationBuilder.InsertData(
                table: "question",
                columns: new[] { "id", "description" },
                values: new object[] { 3, "Mini" });

            migrationBuilder.InsertData(
                table: "question",
                columns: new[] { "id", "description" },
                values: new object[] { 4, "General Motors" });

            migrationBuilder.InsertData(
                table: "question",
                columns: new[] { "id", "description" },
                values: new object[] { 5, "Rolls-Royce" });

            migrationBuilder.InsertData(
                table: "question_option",
                columns: new[] { "id", "answer_id", "is_correct", "question_id" },
                values: new object[] { 1, 1, false, 1 });

            migrationBuilder.InsertData(
                table: "question_option",
                columns: new[] { "id", "answer_id", "is_correct", "question_id" },
                values: new object[] { 18, 2, false, 5 });

            migrationBuilder.InsertData(
                table: "question_option",
                columns: new[] { "id", "answer_id", "is_correct", "question_id" },
                values: new object[] { 17, 1, true, 5 });

            migrationBuilder.InsertData(
                table: "question_option",
                columns: new[] { "id", "answer_id", "is_correct", "question_id" },
                values: new object[] { 16, 4, false, 4 });

            migrationBuilder.InsertData(
                table: "question_option",
                columns: new[] { "id", "answer_id", "is_correct", "question_id" },
                values: new object[] { 15, 3, false, 4 });

            migrationBuilder.InsertData(
                table: "question_option",
                columns: new[] { "id", "answer_id", "is_correct", "question_id" },
                values: new object[] { 14, 2, true, 4 });

            migrationBuilder.InsertData(
                table: "question_option",
                columns: new[] { "id", "answer_id", "is_correct", "question_id" },
                values: new object[] { 13, 1, false, 4 });

            migrationBuilder.InsertData(
                table: "question_option",
                columns: new[] { "id", "answer_id", "is_correct", "question_id" },
                values: new object[] { 12, 4, false, 3 });

            migrationBuilder.InsertData(
                table: "question_option",
                columns: new[] { "id", "answer_id", "is_correct", "question_id" },
                values: new object[] { 11, 3, false, 3 });

            migrationBuilder.InsertData(
                table: "question_option",
                columns: new[] { "id", "answer_id", "is_correct", "question_id" },
                values: new object[] { 10, 2, false, 3 });

            migrationBuilder.InsertData(
                table: "question_option",
                columns: new[] { "id", "answer_id", "is_correct", "question_id" },
                values: new object[] { 9, 1, true, 3 });

            migrationBuilder.InsertData(
                table: "question_option",
                columns: new[] { "id", "answer_id", "is_correct", "question_id" },
                values: new object[] { 8, 4, true, 2 });

            migrationBuilder.InsertData(
                table: "question_option",
                columns: new[] { "id", "answer_id", "is_correct", "question_id" },
                values: new object[] { 7, 3, false, 2 });

            migrationBuilder.InsertData(
                table: "question_option",
                columns: new[] { "id", "answer_id", "is_correct", "question_id" },
                values: new object[] { 6, 2, false, 2 });

            migrationBuilder.InsertData(
                table: "question_option",
                columns: new[] { "id", "answer_id", "is_correct", "question_id" },
                values: new object[] { 5, 1, false, 2 });

            migrationBuilder.InsertData(
                table: "question_option",
                columns: new[] { "id", "answer_id", "is_correct", "question_id" },
                values: new object[] { 4, 4, false, 1 });

            migrationBuilder.InsertData(
                table: "question_option",
                columns: new[] { "id", "answer_id", "is_correct", "question_id" },
                values: new object[] { 3, 3, true, 1 });

            migrationBuilder.InsertData(
                table: "question_option",
                columns: new[] { "id", "answer_id", "is_correct", "question_id" },
                values: new object[] { 2, 2, false, 1 });

            migrationBuilder.InsertData(
                table: "question_option",
                columns: new[] { "id", "answer_id", "is_correct", "question_id" },
                values: new object[] { 19, 3, false, 5 });

            migrationBuilder.InsertData(
                table: "question_option",
                columns: new[] { "id", "answer_id", "is_correct", "question_id" },
                values: new object[] { 20, 4, false, 5 });

            migrationBuilder.CreateIndex(
                name: "IX_question_option_answer_id",
                table: "question_option",
                column: "answer_id");

            migrationBuilder.CreateIndex(
                name: "IX_question_option_question_id",
                table: "question_option",
                column: "question_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "question_option");

            migrationBuilder.DropTable(
                name: "answer");

            migrationBuilder.DropTable(
                name: "question");
        }
    }
}
