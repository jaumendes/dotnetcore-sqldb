using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetCoreSqlDb.Migrations
{
    public partial class AddProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    SmallPortionRatio = table.Column<decimal>(nullable: false),
                    MediumPortionRatio = table.Column<decimal>(nullable: false),
                    LargePortionRatio = table.Column<decimal>(nullable: false),
                    Kcals = table.Column<int>(nullable: false),
                    Protein = table.Column<decimal>(nullable: false),
                    Fat = table.Column<decimal>(nullable: false),
                    SaturatedFat = table.Column<decimal>(nullable: false),
                    CarboHidrate = table.Column<decimal>(nullable: false),
                    Sugar = table.Column<decimal>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastModifiedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
