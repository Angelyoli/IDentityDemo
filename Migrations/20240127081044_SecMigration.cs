using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IDentityDemo.Migrations
{
    /// <inheritdoc />
    public partial class SecMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "daafead4-bd6b-4dd3-b3f3-c8009dfcb13b", null, "seller", "seller" },
                    { "e523d46c-f398-44c5-b3ef-24092d47e6dc", null, "client", "client" },
                    { "f9ae30ae-c473-4113-9792-2873fb822e76", null, "admin", "admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "daafead4-bd6b-4dd3-b3f3-c8009dfcb13b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e523d46c-f398-44c5-b3ef-24092d47e6dc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f9ae30ae-c473-4113-9792-2873fb822e76");
        }
    }
}
