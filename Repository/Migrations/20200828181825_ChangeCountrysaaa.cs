using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class ChangeCountrysaaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "JobId",
                table: "Countries",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Countries_JobId",
                table: "Countries",
                column: "JobId");

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_Jobs_JobId",
                table: "Countries",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_Jobs_JobId",
                table: "Countries");

            migrationBuilder.DropIndex(
                name: "IX_Countries_JobId",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "JobId",
                table: "Countries");
        }
    }
}
