using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiWithEFCoreDemo.Migrations
{
    /// <inheritdoc />
    public partial class updateRelationPosts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostCategories_PostCategories_PostCategoryId",
                table: "PostCategories");

            migrationBuilder.DropIndex(
                name: "IX_PostCategories_PostCategoryId",
                table: "PostCategories");

            migrationBuilder.DropColumn(
                name: "PostCategoryId",
                table: "PostCategories");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PostCategoryId",
                table: "PostCategories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PostCategories_PostCategoryId",
                table: "PostCategories",
                column: "PostCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_PostCategories_PostCategories_PostCategoryId",
                table: "PostCategories",
                column: "PostCategoryId",
                principalTable: "PostCategories",
                principalColumn: "Id");
        }
    }
}
