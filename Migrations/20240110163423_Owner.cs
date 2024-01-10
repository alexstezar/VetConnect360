using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VetConnect360.Migrations
{
    public partial class Owner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Owner",
                table: "Pet");

            migrationBuilder.AddColumn<int>(
                name: "OwnerID",
                table: "Pet",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Owner",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owner", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pet_OwnerID",
                table: "Pet",
                column: "OwnerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pet_Owner_OwnerID",
                table: "Pet",
                column: "OwnerID",
                principalTable: "Owner",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pet_Owner_OwnerID",
                table: "Pet");

            migrationBuilder.DropTable(
                name: "Owner");

            migrationBuilder.DropIndex(
                name: "IX_Pet_OwnerID",
                table: "Pet");

            migrationBuilder.DropColumn(
                name: "OwnerID",
                table: "Pet");

            migrationBuilder.AddColumn<string>(
                name: "Owner",
                table: "Pet",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
