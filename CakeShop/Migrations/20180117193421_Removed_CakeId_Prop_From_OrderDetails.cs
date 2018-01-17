using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CakeShop.Migrations
{
    public partial class Removed_CakeId_Prop_From_OrderDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Cakes_CakeId",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_CakeId",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "CakeId",
                table: "OrderDetails");

            migrationBuilder.AddColumn<string>(
                name: "CakeName",
                table: "OrderDetails",
                maxLength: 255,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CakeName",
                table: "OrderDetails");

            migrationBuilder.AddColumn<int>(
                name: "CakeId",
                table: "OrderDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_CakeId",
                table: "OrderDetails",
                column: "CakeId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Cakes_CakeId",
                table: "OrderDetails",
                column: "CakeId",
                principalTable: "Cakes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
