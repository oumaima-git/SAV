using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SAV.infrastructure.Migrations
{
    public partial class intial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tiers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    Intitule = table.Column<string>(type: "text", nullable: false),
                    FormeJuridique = table.Column<string>(type: "text", nullable: false),
                    Adresse = table.Column<string>(type: "text", nullable: false),
                    Complement = table.Column<string>(type: "text", nullable: false),
                    CP = table.Column<int>(type: "integer", nullable: false),
                    Ville = table.Column<string>(type: "text", nullable: false),
                    Gouvernorat = table.Column<string>(type: "text", nullable: false),
                    Pays = table.Column<string>(type: "text", nullable: false),
                    Tel1 = table.Column<int>(type: "integer", nullable: false),
                    Tel2 = table.Column<int>(type: "integer", nullable: false),
                    RegCom = table.Column<string>(type: "text", nullable: false),
                    MatFiscal = table.Column<string>(type: "text", nullable: false),
                    Gsm = table.Column<int>(type: "integer", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Cin = table.Column<int>(type: "integer", nullable: false),
                    Inactif = table.Column<bool>(type: "boolean", nullable: false),
                    FonctionOccupé = table.Column<string>(type: "text", nullable: false),
                    Notes = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tiers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tiers");
        }
    }
}
