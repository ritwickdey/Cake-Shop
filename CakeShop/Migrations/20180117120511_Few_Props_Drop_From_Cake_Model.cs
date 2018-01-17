using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CakeShop.Migrations
{
    public partial class Few_Props_Drop_From_Cake_Model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AllergyInfo",
                table: "Cakes");

            migrationBuilder.DropColumn(
                name: "ImageThumbnailUrl",
                table: "Cakes");

            migrationBuilder.DropColumn(
                name: "InStock",
                table: "Cakes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AllergyInfo",
                table: "Cakes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageThumbnailUrl",
                table: "Cakes",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "InStock",
                table: "Cakes",
                nullable: false,
                defaultValue: false);
        }
    }
}
