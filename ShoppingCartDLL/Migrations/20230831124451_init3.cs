using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoppingCartDLL.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b2855c3-7b06-4935-9de3-81d98288b227", "admin@gmail.com", "Admin", "AQAAAAEAACcQAAAAEPseYjDnNuVonMYYLoC3U5Fh8dJfc3H5vW3/Iur6aCSo8o9NkQE09tPwbBRKzWb5Ag==", "304defcd-a492-4c7a-bf16-6bdae32361fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "F7A13C3E-EB62-4193-9653-CB3BB571DADF",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8cfcdef4-8c01-4ebe-acbb-c07d255874df", "user@gmail.com", "User", "AQAAAAEAACcQAAAAEAHFU5U4lQY3T6mp/M8EJNDwUuha/IRDkyengEg8e8SHSo2rgLCWwZ80V8bsLASZOw==", "d4d847bb-76d8-4a4b-95b8-86b572e92a7e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a4154c2-f09f-488a-beb1-6a54f35278c5", null, null, "AQAAAAEAACcQAAAAEIxq+15sWvoGpOs+GHsALYw3Tm8xbre1ffU5BwkMaAYCHKUPH3wP1/5Fbk6vaBRDNw==", "72ba3bfa-be7f-46b5-a8d1-8e84bfd84256" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "F7A13C3E-EB62-4193-9653-CB3BB571DADF",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d7a3a86-38f0-4be7-8c1b-94f4a574fac1", null, null, "AQAAAAEAACcQAAAAEGMFKpDSzuKuuU7SAFuFhq1XirdDpQ5DYRbVyEE3FcbuCL5S3VTuiMNRnnE26j7oLA==", "80843a0a-1076-47ee-9ac0-7346b541e8b7" });
        }
    }
}
