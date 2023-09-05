using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoppingCartDLL.Migrations
{
    public partial class Init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PostTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96af6229-2c5e-44c8-afa3-f2802a27ef77", "AQAAAAEAACcQAAAAEAP4T1yO9rYG8vyEg2k1uQ/qqoFcE4mDBh6ANJBjXYeS7l6WhlnyPILmBYac10WHpQ==", "96f62cda-89ba-4c9c-95b3-55f512bee95f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "F7A13C3E-EB62-4193-9653-CB3BB571DADF",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8694ec4-a078-418f-abfb-dc8cefc659b5", "AQAAAAEAACcQAAAAECr/+IqESBlNh/UpO5SI8bd/SGT1G9yQxTNKfeTj8A4MvXOQ3tXPaCtyiEQ+0XTixA==", "75212efe-5a34-4b46-8360-0fe476d92c65" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9176a3b-b419-4d21-9bc9-8180cf80d863", "AQAAAAEAACcQAAAAEOCNzBTWf7U1agb9TnN43cfqacu5mnpwjCtYR0FAB1gkuwCMW2lFvueHnCw0e6FDHg==", "f11dc9f4-5abc-4892-8882-811568050db8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "F7A13C3E-EB62-4193-9653-CB3BB571DADF",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6f93b60-121b-4e45-9d55-ba533fef1dbe", "AQAAAAEAACcQAAAAEF12RhgTiTJmechL/o5SljCWBAIVGp7oIUnQHoZC/RcE7GrM5t5W/5rt0RXlyhEVJg==", "74bc1291-5b30-41e7-87eb-92e1fa421461" });
        }
    }
}
