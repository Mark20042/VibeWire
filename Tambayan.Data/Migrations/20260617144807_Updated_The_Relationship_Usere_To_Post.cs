using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tambayan.Migrations
{
    /// <inheritdoc />
    public partial class Updated_The_Relationship_Usere_To_Post : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostImage_Posts_PostId",
                table: "PostImage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PostImage",
                table: "PostImage");

            migrationBuilder.RenameTable(
                name: "PostImage",
                newName: "PostImages");

            migrationBuilder.RenameIndex(
                name: "IX_PostImage_PostId",
                table: "PostImages",
                newName: "IX_PostImages_PostId");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostImages",
                table: "PostImages",
                column: "PostImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserId",
                table: "Posts",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PostImages_Posts_PostId",
                table: "PostImages",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Users_UserId",
                table: "Posts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostImages_Posts_PostId",
                table: "PostImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Users_UserId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_UserId",
                table: "Posts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PostImages",
                table: "PostImages");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Posts");

            migrationBuilder.RenameTable(
                name: "PostImages",
                newName: "PostImage");

            migrationBuilder.RenameIndex(
                name: "IX_PostImages_PostId",
                table: "PostImage",
                newName: "IX_PostImage_PostId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostImage",
                table: "PostImage",
                column: "PostImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_PostImage_Posts_PostId",
                table: "PostImage",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
