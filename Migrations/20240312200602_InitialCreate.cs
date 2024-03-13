using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NumberSortApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SortModels",
                columns: table => new
                {
                    SortedNumbers = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SortingDirection = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SortingTime = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SortModels", x => x.SortedNumbers);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SortModels");
        }
    }
}
