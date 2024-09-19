using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task_2.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addcreateddatetimecolumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: DateTime.Now);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: DateTime.Now);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Product",
                type: "datetime2",
                nullable: false,
                defaultValue: DateTime.Now);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "Product");
        }
    }
}
