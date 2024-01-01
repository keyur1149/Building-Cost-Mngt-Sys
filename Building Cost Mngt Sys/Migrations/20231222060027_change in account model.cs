using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Building_Cost_Mngt_Sys.Migrations
{
    /// <inheritdoc />
    public partial class changeinaccountmodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateTime",
                table: "Accounts");

            migrationBuilder.AddColumn<string>(
                name: "Date",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Time",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "Accounts");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTime",
                table: "Accounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
