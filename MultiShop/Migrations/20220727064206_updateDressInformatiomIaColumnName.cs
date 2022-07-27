using Microsoft.EntityFrameworkCore.Migrations;

namespace MultiShop.Migrations
{
    public partial class updateDressInformatiomIaColumnName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dresses_DressInformations_DressInformationId",
                table: "Dresses");

            migrationBuilder.DropColumn(
                name: "DresInformationId",
                table: "Dresses");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Dresses",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DressInformationId",
                table: "Dresses",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Desc",
                table: "Dresses",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Dresses_DressInformations_DressInformationId",
                table: "Dresses",
                column: "DressInformationId",
                principalTable: "DressInformations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dresses_DressInformations_DressInformationId",
                table: "Dresses");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Dresses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "DressInformationId",
                table: "Dresses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Desc",
                table: "Dresses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "DresInformationId",
                table: "Dresses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Dresses_DressInformations_DressInformationId",
                table: "Dresses",
                column: "DressInformationId",
                principalTable: "DressInformations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
