using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Building_Cost_Mngt_Sys.Migrations
{
    /// <inheritdoc />
    public partial class changeinmodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Project_Type_Projects_Projects_Id",
                table: "User_Project_Type");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Project_Type_user_Types_User_Type_Id",
                table: "User_Project_Type");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Project_Type_users_UsersUser_Id",
                table: "User_Project_Type");

            migrationBuilder.RenameColumn(
                name: "UsersUser_Id",
                table: "User_Project_Type",
                newName: "usersUser_Id");

            migrationBuilder.RenameIndex(
                name: "IX_User_Project_Type_UsersUser_Id",
                table: "User_Project_Type",
                newName: "IX_User_Project_Type_usersUser_Id");

            migrationBuilder.AlterColumn<Guid>(
                name: "usersUser_Id",
                table: "User_Project_Type",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "User_Type_Id",
                table: "User_Project_Type",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "Projects_Id",
                table: "User_Project_Type",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Project_Type_Projects_Projects_Id",
                table: "User_Project_Type",
                column: "Projects_Id",
                principalTable: "Projects",
                principalColumn: "Projects_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Project_Type_user_Types_User_Type_Id",
                table: "User_Project_Type",
                column: "User_Type_Id",
                principalTable: "user_Types",
                principalColumn: "User_Type_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Project_Type_users_usersUser_Id",
                table: "User_Project_Type",
                column: "usersUser_Id",
                principalTable: "users",
                principalColumn: "User_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Project_Type_Projects_Projects_Id",
                table: "User_Project_Type");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Project_Type_user_Types_User_Type_Id",
                table: "User_Project_Type");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Project_Type_users_usersUser_Id",
                table: "User_Project_Type");

            migrationBuilder.RenameColumn(
                name: "usersUser_Id",
                table: "User_Project_Type",
                newName: "UsersUser_Id");

            migrationBuilder.RenameIndex(
                name: "IX_User_Project_Type_usersUser_Id",
                table: "User_Project_Type",
                newName: "IX_User_Project_Type_UsersUser_Id");

            migrationBuilder.AlterColumn<Guid>(
                name: "UsersUser_Id",
                table: "User_Project_Type",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "User_Type_Id",
                table: "User_Project_Type",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "Projects_Id",
                table: "User_Project_Type",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Project_Type_Projects_Projects_Id",
                table: "User_Project_Type",
                column: "Projects_Id",
                principalTable: "Projects",
                principalColumn: "Projects_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Project_Type_user_Types_User_Type_Id",
                table: "User_Project_Type",
                column: "User_Type_Id",
                principalTable: "user_Types",
                principalColumn: "User_Type_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Project_Type_users_UsersUser_Id",
                table: "User_Project_Type",
                column: "UsersUser_Id",
                principalTable: "users",
                principalColumn: "User_Id");
        }
    }
}
