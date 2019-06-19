using Microsoft.EntityFrameworkCore.Migrations;

namespace EFTableRelationships.Migrations
{
    public partial class TeacherContactRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "ContactInfos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ContactInfos_TeacherId",
                table: "ContactInfos",
                column: "TeacherId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ContactInfos_Teachers_TeacherId",
                table: "ContactInfos",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactInfos_Teachers_TeacherId",
                table: "ContactInfos");

            migrationBuilder.DropIndex(
                name: "IX_ContactInfos_TeacherId",
                table: "ContactInfos");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "ContactInfos");
        }
    }
}
