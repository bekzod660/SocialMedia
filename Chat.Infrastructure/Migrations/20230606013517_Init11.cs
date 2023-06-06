using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Chat.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Init11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Comments_CommentsId",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "CommentsId",
                table: "Comments",
                newName: "CommentId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_CommentsId",
                table: "Comments",
                newName: "IX_Comments_CommentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Comments_CommentId",
                table: "Comments",
                column: "CommentId",
                principalTable: "Comments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Comments_CommentId",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "CommentId",
                table: "Comments",
                newName: "CommentsId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_CommentId",
                table: "Comments",
                newName: "IX_Comments_CommentsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Comments_CommentsId",
                table: "Comments",
                column: "CommentsId",
                principalTable: "Comments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
