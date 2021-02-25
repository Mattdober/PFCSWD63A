using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class rectifyingPostsMistake : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Postss_Blogs_BlogId",
                table: "Postss");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Postss",
                table: "Postss");

            migrationBuilder.RenameTable(
                name: "Postss",
                newName: "Posts");

            migrationBuilder.RenameIndex(
                name: "IX_Postss_BlogId",
                table: "Posts",
                newName: "IX_Posts_BlogId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Posts",
                table: "Posts",
                column: "PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Blogs_BlogId",
                table: "Posts",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "BlogId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Blogs_BlogId",
                table: "Posts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Posts",
                table: "Posts");

            migrationBuilder.RenameTable(
                name: "Posts",
                newName: "Postss");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_BlogId",
                table: "Postss",
                newName: "IX_Postss_BlogId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Postss",
                table: "Postss",
                column: "PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_Postss_Blogs_BlogId",
                table: "Postss",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "BlogId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
