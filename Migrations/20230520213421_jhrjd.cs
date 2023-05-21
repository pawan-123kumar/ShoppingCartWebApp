using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoppingCartWebApp.Migrations
{
    public partial class jhrjd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Checkouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Catagory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checkouts", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "634a60ec-96bc-4f37-937f-27ba52f58d41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b06f0af-624c-4d32-8c54-7fbc8c086ad6", "AQAAAAEAACcQAAAAEClcvoaERwpuMzijulI23enoFgv24lqEWxQ/KvK/aunIgE6MVK/Ev5ZY6kP8RUnWUQ==", "5a67541a-b5b5-4010-bc55-1770d30952b0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c80d49e8-a97c-45e6-babf-0760a6b86814",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e020d229-8607-4472-86a6-e0855348ec1c", "AQAAAAEAACcQAAAAECUkKOelz4CfBuGeMHHOTSGSiWUn0drrPw4homBzllhBpi7mkVVsFfF/bKQrX1wxsg==", "9850f049-669e-4d66-8c16-30652984d042" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Checkouts");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "634a60ec-96bc-4f37-937f-27ba52f58d41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fec1efee-b5e9-46f3-b1d2-e8c99a6a8b15", "AQAAAAEAACcQAAAAEIeHO+iZ9Vzq+Cd7mI8cUgE/SbOmUXBrEx0Hsgl9P/MeF9BnxZ9lMN1f3GYlTKc6IA==", "dd69fed6-13fa-44a0-bb89-8826f7a8db83" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c80d49e8-a97c-45e6-babf-0760a6b86814",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e20b4c51-ba91-4446-a6f0-934450da51f2", "AQAAAAEAACcQAAAAEIgMyY3TNdvMgSt37gAfTklRiHhcTXtkDVrzjtfldQSS8Ps4EapVj2rQo9iNs74NaQ==", "93196323-ff1e-44ad-8623-2bf658f0dbd4" });
        }
    }
}
