using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuizAPI.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Participations",
                columns: new[] { "PartipicantId", "Email", "Name", "Score", "TimeTaken" },
                values: new object[] { "ASD", "prtpcnt1@gmail.com", "P1", 3, 500 });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QnId", "Answer", "ImageName", "Option1", "Option2", "Option3", "Option4", "QnInWords" },
                values: new object[,]
                {
                    { 1, 2, "", "Hyper Trainer Marking Language", "Hyper Text Marketing Language", "Hyper Text Markup Leveler", "Hyper Text Markup Language", "What does HTML stand for?" },
                    { 2, 2, "", "ALU", "Memory", "CPU", "Control Unit", "The brain of any computer system is" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Participations",
                keyColumn: "PartipicantId",
                keyValue: "ASD");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QnId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QnId",
                keyValue: 2);
        }
    }
}
