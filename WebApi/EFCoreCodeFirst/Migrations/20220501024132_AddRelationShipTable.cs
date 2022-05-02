using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreCodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class AddRelationShipTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "StudentInfo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GradeId",
                table: "StudentInfo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_StudentInfo_AddressId",
                table: "StudentInfo",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentInfo_GradeId",
                table: "StudentInfo",
                column: "GradeId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentInfo_Addresss_AddressId",
                table: "StudentInfo",
                column: "AddressId",
                principalTable: "Addresss",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentInfo_Grades_GradeId",
                table: "StudentInfo",
                column: "GradeId",
                principalTable: "Grades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentInfo_Addresss_AddressId",
                table: "StudentInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentInfo_Grades_GradeId",
                table: "StudentInfo");

            migrationBuilder.DropIndex(
                name: "IX_StudentInfo_AddressId",
                table: "StudentInfo");

            migrationBuilder.DropIndex(
                name: "IX_StudentInfo_GradeId",
                table: "StudentInfo");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "StudentInfo");

            migrationBuilder.DropColumn(
                name: "GradeId",
                table: "StudentInfo");
        }
    }
}
