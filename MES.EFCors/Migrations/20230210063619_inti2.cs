using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MES.EFCors.Migrations
{
    public partial class inti2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "production");

            migrationBuilder.DropColumn(
                name: "MoldStatus",
                table: "production");

            migrationBuilder.AddColumn<int>(
                name: "ProductionsStatusId",
                table: "production",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductionsTypeId",
                table: "production",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "MaterielName",
                table: "meteriel",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "productionsStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductionsStatusName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productionsStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "productionsType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductionsTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productionsType", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "productionsStatus");

            migrationBuilder.DropTable(
                name: "productionsType");

            migrationBuilder.DropColumn(
                name: "ProductionsStatusId",
                table: "production");

            migrationBuilder.DropColumn(
                name: "ProductionsTypeId",
                table: "production");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "production",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MoldStatus",
                table: "production",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MaterielName",
                table: "meteriel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
