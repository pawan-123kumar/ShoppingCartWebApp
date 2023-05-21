using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoppingCartWebApp.Migrations
{
    public partial class fkjgfk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "634a60ec-96bc-4f37-937f-27ba52f58d41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "edff3711-28e6-4c57-8b70-1d1eedb57515", "AQAAAAEAACcQAAAAEEXrKMdFr0Km6NjAGg3sGzM/sapqB41pigxanvx9/dCIZNXuCgPOSknmU0rkGn0HwA==", "fc15c01a-b29a-4a42-99ed-f26da6b7605f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c80d49e8-a97c-45e6-babf-0760a6b86814",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92cdd3ea-968b-48a6-a902-35fc98ef9be0", "AQAAAAEAACcQAAAAEI6AD3Crgob+dw7ul0uNIxNTnttcj1x+kzp57iW3g3x3G7fXlp/K/ljnGETtBxNmHg==", "4da0cc3d-360c-408a-8588-3732fea5cf9b" });
        }
    }
}
