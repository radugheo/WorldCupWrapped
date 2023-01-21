using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorldCupWrapped.Migrations
{
    /// <inheritdoc />
    public partial class AddCountInTeamTrophy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "TeamTrophies",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Count",
                table: "TeamTrophies");
        }
    }
}
