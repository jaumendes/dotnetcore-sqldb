using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetCoreSqlDb.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Food",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Calories = table.Column<int>(nullable: true),
                    Carbs    = table.Column<double>(nullable: true),
                    Fats     = table.Column<double>(nullable: true),
                    Proteins = table.Column<double>(nullable: true),
                    Sugars   = table.Column<double>(nullable: true),
                    SatFats  = table.Column<double>(nullable: true),
                    Vitamins  = table.Column<string>(nullable: true),
                    Source     = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Food", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Food");
        }
    }
}
