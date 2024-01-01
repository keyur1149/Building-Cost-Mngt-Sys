using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Building_Cost_Mngt_Sys.Migrations
{
    /// <inheritdoc />
    public partial class changeinmodelId : Migration
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
                name: "FK_User_Project_Type_users_usersUser_Id",
                table: "User_Project_Type");

            migrationBuilder.RenameColumn(
                name: "User_Id",
                table: "users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "User_Type_Id",
                table: "user_Types",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "usersUser_Id",
                table: "User_Project_Type",
                newName: "usersId");

            migrationBuilder.RenameColumn(
                name: "User_Type_Id",
                table: "User_Project_Type",
                newName: "user_typeId");

            migrationBuilder.RenameColumn(
                name: "Projects_Id",
                table: "User_Project_Type",
                newName: "projectId");

            migrationBuilder.RenameIndex(
                name: "IX_User_Project_Type_usersUser_Id",
                table: "User_Project_Type",
                newName: "IX_User_Project_Type_usersId");

            migrationBuilder.RenameIndex(
                name: "IX_User_Project_Type_User_Type_Id",
                table: "User_Project_Type",
                newName: "IX_User_Project_Type_user_typeId");

            migrationBuilder.RenameIndex(
                name: "IX_User_Project_Type_Projects_Id",
                table: "User_Project_Type",
                newName: "IX_User_Project_Type_projectId");

            migrationBuilder.RenameColumn(
                name: "Projects_Id",
                table: "Projects",
                newName: "Id");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "users",
                newName: "User_Id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "user_Types",
                newName: "User_Type_Id");

            migrationBuilder.RenameColumn(
                name: "usersId",
                table: "User_Project_Type",
                newName: "usersUser_Id");

            migrationBuilder.RenameColumn(
                name: "user_typeId",
                table: "User_Project_Type",
                newName: "User_Type_Id");

            migrationBuilder.RenameColumn(
                name: "projectId",
                table: "User_Project_Type",
                newName: "Projects_Id");

            migrationBuilder.RenameIndex(
                name: "IX_User_Project_Type_usersId",
                table: "User_Project_Type",
                newName: "IX_User_Project_Type_usersUser_Id");

            migrationBuilder.RenameIndex(
                name: "IX_User_Project_Type_user_typeId",
                table: "User_Project_Type",
                newName: "IX_User_Project_Type_User_Type_Id");

            migrationBuilder.RenameIndex(
                name: "IX_User_Project_Type_projectId",
                table: "User_Project_Type",
                newName: "IX_User_Project_Type_Projects_Id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Projects",
                newName: "Projects_Id");

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
    }
}
