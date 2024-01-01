using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Building_Cost_Mngt_Sys.Migrations
{
    /// <inheritdoc />
    public partial class allModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Projects_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    no_of_floors = table.Column<int>(type: "int", nullable: false),
                    no_of_house_per_floor = table.Column<int>(type: "int", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Projects_Id);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    State_Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "user_Types",
                columns: table => new
                {
                    User_Type_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    User_Type_Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_Types", x => x.User_Type_Id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    User_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    User_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordModified = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.User_Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User_Project_Type",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Projects_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    User_Type_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UsersUser_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Project_Type", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Project_Type_Projects_Projects_Id",
                        column: x => x.Projects_Id,
                        principalTable: "Projects",
                        principalColumn: "Projects_Id");
                    table.ForeignKey(
                        name: "FK_User_Project_Type_user_Types_User_Type_Id",
                        column: x => x.User_Type_Id,
                        principalTable: "user_Types",
                        principalColumn: "User_Type_Id");
                    table.ForeignKey(
                        name: "FK_User_Project_Type_users_UsersUser_Id",
                        column: x => x.UsersUser_Id,
                        principalTable: "users",
                        principalColumn: "User_Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_StateId",
                table: "Cities",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Project_Type_Projects_Id",
                table: "User_Project_Type",
                column: "Projects_Id");

            migrationBuilder.CreateIndex(
                name: "IX_User_Project_Type_User_Type_Id",
                table: "User_Project_Type",
                column: "User_Type_Id");

            migrationBuilder.CreateIndex(
                name: "IX_User_Project_Type_UsersUser_Id",
                table: "User_Project_Type",
                column: "UsersUser_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "User_Project_Type");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "user_Types");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
