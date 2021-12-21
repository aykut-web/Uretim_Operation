using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Uretim_Operation.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsNo = table.Column<int>(nullable: false),
                    BaslangicTarihi = table.Column<DateTime>(nullable: false),
                    BitisTarihi = table.Column<DateTime>(nullable: false),
                    ToplamSure = table.Column<TimeSpan>(nullable: false),
                    Statu = table.Column<string>(nullable: true),
                    DurusNedeni = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notifications");
        }
    }
}
