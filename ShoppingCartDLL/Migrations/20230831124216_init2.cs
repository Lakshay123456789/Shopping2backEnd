using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoppingCartDLL.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a4154c2-f09f-488a-beb1-6a54f35278c5", "AQAAAAEAACcQAAAAEIxq+15sWvoGpOs+GHsALYw3Tm8xbre1ffU5BwkMaAYCHKUPH3wP1/5Fbk6vaBRDNw==", "72ba3bfa-be7f-46b5-a8d1-8e84bfd84256" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "F7A13C3E-EB62-4193-9653-CB3BB571DADF",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d7a3a86-38f0-4be7-8c1b-94f4a574fac1", "AQAAAAEAACcQAAAAEGMFKpDSzuKuuU7SAFuFhq1XirdDpQ5DYRbVyEE3FcbuCL5S3VTuiMNRnnE26j7oLA==", "80843a0a-1076-47ee-9ac0-7346b541e8b7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe626ba5-bff2-4ecf-b1e5-70094b9ef0f1", null, "6b15e8c9-0b3d-4817-b68a-8cd66d432f80" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "F7A13C3E-EB62-4193-9653-CB3BB571DADF",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8d5b6c8-4374-41e1-926c-ed2bef7a5db7", null, "b5aca5e7-b653-402b-a33d-8956806aa3b3" });
        }
    }
}
