using Microsoft.EntityFrameworkCore.Migrations;

namespace GramTrainingCoreAngular.Migrations
{
    public partial class FixQuestionAnswerForeignKey_SeedQuestionAnswer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionAnswer_Question_AnswerId",
                table: "QuestionAnswer");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionAnswer_Answer_QuestionId",
                table: "QuestionAnswer");

            migrationBuilder.InsertData(
                table: "QuestionAnswer",
                columns: new[] { "QuestionId", "AnswerId", "Id" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 1, 2, 2 },
                    { 1, 3, 3 },
                    { 1, 4, 4 },
                    { 1, 5, 5 },
                    { 1, 6, 6 },
                    { 1, 7, 7 },
                    { 1, 8, 8 },
                    { 2, 1, 9 },
                    { 2, 2, 10 },
                    { 2, 3, 11 },
                    { 2, 4, 12 },
                    { 2, 5, 13 },
                    { 2, 6, 14 },
                    { 2, 7, 15 },
                    { 2, 8, 16 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionAnswer_Answer_AnswerId",
                table: "QuestionAnswer",
                column: "AnswerId",
                principalTable: "Answer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionAnswer_Question_QuestionId",
                table: "QuestionAnswer",
                column: "QuestionId",
                principalTable: "Question",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionAnswer_Answer_AnswerId",
                table: "QuestionAnswer");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionAnswer_Question_QuestionId",
                table: "QuestionAnswer");

            migrationBuilder.DeleteData(
                table: "QuestionAnswer",
                keyColumns: new[] { "QuestionId", "AnswerId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "QuestionAnswer",
                keyColumns: new[] { "QuestionId", "AnswerId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "QuestionAnswer",
                keyColumns: new[] { "QuestionId", "AnswerId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "QuestionAnswer",
                keyColumns: new[] { "QuestionId", "AnswerId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "QuestionAnswer",
                keyColumns: new[] { "QuestionId", "AnswerId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "QuestionAnswer",
                keyColumns: new[] { "QuestionId", "AnswerId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "QuestionAnswer",
                keyColumns: new[] { "QuestionId", "AnswerId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "QuestionAnswer",
                keyColumns: new[] { "QuestionId", "AnswerId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "QuestionAnswer",
                keyColumns: new[] { "QuestionId", "AnswerId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "QuestionAnswer",
                keyColumns: new[] { "QuestionId", "AnswerId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "QuestionAnswer",
                keyColumns: new[] { "QuestionId", "AnswerId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "QuestionAnswer",
                keyColumns: new[] { "QuestionId", "AnswerId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "QuestionAnswer",
                keyColumns: new[] { "QuestionId", "AnswerId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "QuestionAnswer",
                keyColumns: new[] { "QuestionId", "AnswerId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "QuestionAnswer",
                keyColumns: new[] { "QuestionId", "AnswerId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "QuestionAnswer",
                keyColumns: new[] { "QuestionId", "AnswerId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionAnswer_Question_AnswerId",
                table: "QuestionAnswer",
                column: "AnswerId",
                principalTable: "Question",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionAnswer_Answer_QuestionId",
                table: "QuestionAnswer",
                column: "QuestionId",
                principalTable: "Answer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
