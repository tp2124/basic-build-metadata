using Microsoft.EntityFrameworkCore.Migrations;

namespace BuildMetadata.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Builds",
                columns: table => new
                {
                    ChangelistNumber = table.Column<uint>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Notes = table.Column<string>(nullable: true),
                    IsNightly = table.Column<bool>(nullable: false),
                    HasPackagedBinaries = table.Column<bool>(nullable: false),
                    QVIsTesting = table.Column<bool>(nullable: false),
                    QVCompleted = table.Column<bool>(nullable: false),
                    KnownGoodClient = table.Column<bool>(nullable: false),
                    KnownGoodEditor = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Builds", x => x.ChangelistNumber);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Builds");
        }
    }
}
