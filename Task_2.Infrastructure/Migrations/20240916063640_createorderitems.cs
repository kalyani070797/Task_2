using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task_2.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class createorderitems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Product_ProductId",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "OrderItems");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<int>(
            //    name: "ProductId",
            //    table: "OrderItems",
            //    type: "int",
            //    nullable: false,
            //    defaultValue: 0);

            //migrationBuilder.CreateIndex(
            //    name: "IX_OrderItems_ProductId",
            //    table: "OrderItems",
            //    column: "ProductId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_OrderItems_Product_ProductId",
            //    table: "OrderItems",
            //    column: "ProductId",
            //    principalTable: "Product",
            //    principalColumn: "ProductId",
            //    onDelete: ReferentialAction.Cascade);
        }
    }
}
