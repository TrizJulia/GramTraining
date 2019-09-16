using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GramTrainingCoreAngular.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Answer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Text = table.Column<string>(maxLength: 3000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GrRule",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Language = table.Column<int>(nullable: false),
                    Link = table.Column<string>(nullable: true),
                    IsImage = table.Column<bool>(nullable: false),
                    IsYoutube = table.Column<bool>(nullable: false),
                    Tens = table.Column<int>(nullable: false),
                    RuleText = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrRule", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    QuestionText = table.Column<string>(nullable: false),
                    RightAnswerIndex = table.Column<int>(nullable: false),
                    RuleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Question_GrRule_RuleId",
                        column: x => x.RuleId,
                        principalTable: "GrRule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QuestionAnswer",
                columns: table => new
                {
                    QuestionId = table.Column<int>(nullable: false),
                    AnswerId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionAnswer", x => new { x.QuestionId, x.AnswerId });
                    table.ForeignKey(
                        name: "FK_QuestionAnswer_Question_AnswerId",
                        column: x => x.AnswerId,
                        principalTable: "Question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuestionAnswer_Answer_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Answer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "Id", "Text" },
                values: new object[,]
                {
                    { 1, "What?" },
                    { 2, "Who?" },
                    { 3, "Where?" },
                    { 4, "When?" },
                    { 5, "Why?" },
                    { 6, "Which?" },
                    { 7, "What time?" },
                    { 8, "How much?" }
                });

            migrationBuilder.InsertData(
                table: "GrRule",
                columns: new[] { "Id", "IsImage", "IsYoutube", "Language", "Link", "RuleText", "Tens" },
                values: new object[] { 1, true, false, 0, "./assets/pitalni_slova-.jpg", null, 0 });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "Id", "QuestionText", "RightAnswerIndex", "RuleId" },
                values: new object[,]
                {
                    { 1, "Де?", 2, null },
                    { 2, "Хто?", 1, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Question_RuleId",
                table: "Question",
                column: "RuleId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionAnswer_AnswerId",
                table: "QuestionAnswer",
                column: "AnswerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuestionAnswer");

            migrationBuilder.DropTable(
                name: "Question");

            migrationBuilder.DropTable(
                name: "Answer");

            migrationBuilder.DropTable(
                name: "GrRule");
        }
    }
}
