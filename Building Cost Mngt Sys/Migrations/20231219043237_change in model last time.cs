using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Building_Cost_Mngt_Sys.Migrations
{
    /// <inheritdoc />
    public partial class changeinmodellasttime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Project_Type_Projects_projectId",
                table: "User_Project_Type");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Project_Type_user_Types_user_typeId",
                table: "User_Project_Type");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Project_Type_users_usersId",
                table: "User_Project_Type");

            migrationBuilder.DropIndex(
                name: "IX_User_Project_Type_projectId",
                table: "User_Project_Type");

            migrationBuilder.DropIndex(
                name: "IX_User_Project_Type_user_typeId",
                table: "User_Project_Type");

            migrationBuilder.DropIndex(
                name: "IX_User_Project_Type_usersId",
                table: "User_Project_Type");

            migrationBuilder.RenameColumn(
                name: "usersId",
                table: "User_Project_Type",
                newName: "users_Id");

            migrationBuilder.RenameColumn(
                name: "user_typeId",
                table: "User_Project_Type",
                newName: "user_type_Id");

            migrationBuilder.RenameColumn(
                name: "projectId",
                table: "User_Project_Type",
                newName: "project_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "users_Id",
                table: "User_Project_Type",
                newName: "usersId");

            migrationBuilder.RenameColumn(
                name: "user_type_Id",
                table: "User_Project_Type",
                newName: "user_typeId");

            migrationBuilder.RenameColumn(
                name: "project_Id",
                table: "User_Project_Type",
                newName: "projectId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Project_Type_projectId",
                table: "User_Project_Type",
                column: "projectId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Project_Type_user_typeId",
                table: "User_Project_Type",
                column: "user_typeId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Project_Type_usersId",
                table: "User_Project_Type",
                column: "usersId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Project_Type_Projects_projectId",
                table: "User_Project_Type",
                column: "projectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Project_Type_user_Types_user_typeId",
                table: "User_Project_Type",
                column: "user_typeId",
                principalTable: "user_Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Project_Type_users_usersId",
                table: "User_Project_Type",
                column: "usersId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
