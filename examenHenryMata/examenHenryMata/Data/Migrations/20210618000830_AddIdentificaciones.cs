using Microsoft.EntityFrameworkCore.Migrations;

namespace examenHenryMata.Data.Migrations
{
    public partial class AddIdentificaciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Identificaciones",
                columns: table => new
                {
                    IdentificacionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentificacionCodigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentificacionApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentificacionNombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentificacionApodo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentificacionDireccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentificacionCodigoPostal = table.Column<int>(type: "int", nullable: false),
                    IdentificacionTelefono = table.Column<int>(type: "int", nullable: false),
                    IdentificacionCelular = table.Column<int>(type: "int", nullable: false),
                    IdentificacionFax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentificacionEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Identificaciones", x => x.IdentificacionId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Identificaciones");
        }
    }
}
