using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDprueba.Migrations
{
    /// <inheritdoc />
    public partial class AgregarVendedor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Vendedor",
                table: "Vendedor");

            migrationBuilder.RenameTable(
                name: "Vendedor",
                newName: "Vendedores");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vendedores",
                table: "Vendedores",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Vendedores",
                table: "Vendedores");

            migrationBuilder.RenameTable(
                name: "Vendedores",
                newName: "Vendedor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vendedor",
                table: "Vendedor",
                column: "Id");
        }
    }
}
