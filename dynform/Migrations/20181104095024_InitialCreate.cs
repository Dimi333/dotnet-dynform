using Microsoft.EntityFrameworkCore.Migrations;

namespace dynform.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Formulare",
                columns: table => new
                {
                    FormularId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Datum = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formulare", x => x.FormularId);
                });

            migrationBuilder.CreateTable(
                name: "Typy",
                columns: table => new
                {
                    TypId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nazov = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Typy", x => x.TypId);
                });

            migrationBuilder.CreateTable(
                name: "Zaznamy",
                columns: table => new
                {
                    ZaznamId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Obsah = table.Column<string>(nullable: true),
                    FormularId = table.Column<int>(nullable: false),
                    TypId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zaznamy", x => x.ZaznamId);
                    table.ForeignKey(
                        name: "FK_Zaznamy_Formulare_FormularId",
                        column: x => x.FormularId,
                        principalTable: "Formulare",
                        principalColumn: "FormularId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Zaznamy_FormularId",
                table: "Zaznamy",
                column: "FormularId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Typy");

            migrationBuilder.DropTable(
                name: "Zaznamy");

            migrationBuilder.DropTable(
                name: "Formulare");
        }
    }
}
