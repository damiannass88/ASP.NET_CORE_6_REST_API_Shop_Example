using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP.NET_CORE_6_REST_API_Shop_Example.Migrations
{
    public partial class Shop_Example_DBSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShopProducts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    ProductCreationDate = table.Column<DateTimeOffset>(type: "DateTimeOffset", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    ProductModificationDate = table.Column<DateTimeOffset>(type: "DateTimeOffset", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    ProductPrice = table.Column<decimal>(type: "Smallmoney", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopProducts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ShopProducts",
                columns: new[] { "Id", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[] { new Guid("652a0584-2d73-4a47-83cb-378f3e60984a"), "Very Good and Quckly Printer, for alldays use.", "Printer Z", 85.99m });

            migrationBuilder.InsertData(
                table: "ShopProducts",
                columns: new[] { "Id", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[] { new Guid("ea755709-32ce-4c35-96e6-dd27ca631deb"), "Very Good and Comfortable Chair, for alldays use.", "Chair Y", 189.99m });

            migrationBuilder.InsertData(
                table: "ShopProducts",
                columns: new[] { "Id", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[] { new Guid("f874d74f-c215-441f-87de-e1c8aa037d6f"), "Very Good and Quckly Phone, for alldays use.", "Mobile Phone X", 988.99m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShopProducts");
        }
    }
}
