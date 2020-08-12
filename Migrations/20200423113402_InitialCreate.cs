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
                    Proteins = table.Column<float>(nullable: true),
                    Fats     = table.Column<float>(nullable: true),
                    SatFats  = table.Column<float>(nullable: true),              
                    Carbs    = table.Column<float>(nullable: true),
                    Sugars   = table.Column<float>(nullable: true),
                    Fibers   = table.Column<float>(nullable: true),
                    Vitamins  = table.Column<string>(nullable: true),
                    Minerals  = table.Column<string>(nullable: true),
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
