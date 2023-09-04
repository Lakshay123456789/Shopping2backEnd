using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoppingCartDLL.Migrations
{
    public partial class init4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductQuantity = table.Column<int>(type: "int", nullable: false),
                    ProductPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductCatagory = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7dafa332-18a0-473d-9ea0-2ea02bc4b92c", "AQAAAAEAACcQAAAAEG8vVvkvNejUFCf1wsnPsIiJEw5VcIKg76mjh33ZH/fQkUlEjYmkowZBvViLGIcBtg==", "26113fae-9271-4317-8003-bef0f1b8877a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "F7A13C3E-EB62-4193-9653-CB3BB571DADF",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c232dc6b-8140-4ac0-b5fc-66ec6ef18381", "AQAAAAEAACcQAAAAEL4q4uLOYcOrTykP7GNidQ0vYBpXGz2TJ+jcL9AUOf+yxSfizNXAvcM2MxEwOQ+lwg==", "a34fdaec-0e7a-4edb-8ac6-c280ed9f235b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b2855c3-7b06-4935-9de3-81d98288b227", "AQAAAAEAACcQAAAAEPseYjDnNuVonMYYLoC3U5Fh8dJfc3H5vW3/Iur6aCSo8o9NkQE09tPwbBRKzWb5Ag==", "304defcd-a492-4c7a-bf16-6bdae32361fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "F7A13C3E-EB62-4193-9653-CB3BB571DADF",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8cfcdef4-8c01-4ebe-acbb-c07d255874df", "AQAAAAEAACcQAAAAEAHFU5U4lQY3T6mp/M8EJNDwUuha/IRDkyengEg8e8SHSo2rgLCWwZ80V8bsLASZOw==", "d4d847bb-76d8-4a4b-95b8-86b572e92a7e" });
        }
    }
}
