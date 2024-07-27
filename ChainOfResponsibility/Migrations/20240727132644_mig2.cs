using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChainOfResponsibility.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Processs",
                table: "Processs");

            migrationBuilder.RenameTable(
                name: "Processs",
                newName: "CustomerProcesses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerProcesses",
                table: "CustomerProcesses",
                column: "CustomerProcessId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerProcesses",
                table: "CustomerProcesses");

            migrationBuilder.RenameTable(
                name: "CustomerProcesses",
                newName: "Processs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Processs",
                table: "Processs",
                column: "CustomerProcessId");
        }
    }
}
