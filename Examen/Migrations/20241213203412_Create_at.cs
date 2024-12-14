using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examen.Migrations
{
    /// <inheritdoc />
    public partial class Create_at : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "userCreateId",
                table: "products",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "userCreateId",
                table: "invoices",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "userCreateId",
                table: "invoice_Details",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "userCreateId",
                table: "clients",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "userCreateId",
                table: "catalogues",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "userCreateId",
                table: "brands",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "userCreateId",
                table: "binnacleHeaders",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "userCreateId",
                table: "binnacleBody",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "userCreateId",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "userCreateId",
                table: "AspNetRoles",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_products_userCreateId",
                table: "products",
                column: "userCreateId");

            migrationBuilder.CreateIndex(
                name: "IX_invoices_userCreateId",
                table: "invoices",
                column: "userCreateId");

            migrationBuilder.CreateIndex(
                name: "IX_invoice_Details_userCreateId",
                table: "invoice_Details",
                column: "userCreateId");

            migrationBuilder.CreateIndex(
                name: "IX_clients_userCreateId",
                table: "clients",
                column: "userCreateId");

            migrationBuilder.CreateIndex(
                name: "IX_catalogues_userCreateId",
                table: "catalogues",
                column: "userCreateId");

            migrationBuilder.CreateIndex(
                name: "IX_brands_userCreateId",
                table: "brands",
                column: "userCreateId");

            migrationBuilder.CreateIndex(
                name: "IX_binnacleHeaders_userCreateId",
                table: "binnacleHeaders",
                column: "userCreateId");

            migrationBuilder.CreateIndex(
                name: "IX_binnacleBody_userCreateId",
                table: "binnacleBody",
                column: "userCreateId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_userCreateId",
                table: "AspNetUsers",
                column: "userCreateId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoles_userCreateId",
                table: "AspNetRoles",
                column: "userCreateId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoles_AspNetUsers_userCreateId",
                table: "AspNetRoles",
                column: "userCreateId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_userCreateId",
                table: "AspNetUsers",
                column: "userCreateId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_binnacleBody_AspNetUsers_userCreateId",
                table: "binnacleBody",
                column: "userCreateId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_binnacleHeaders_AspNetUsers_userCreateId",
                table: "binnacleHeaders",
                column: "userCreateId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_brands_AspNetUsers_userCreateId",
                table: "brands",
                column: "userCreateId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_catalogues_AspNetUsers_userCreateId",
                table: "catalogues",
                column: "userCreateId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_clients_AspNetUsers_userCreateId",
                table: "clients",
                column: "userCreateId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_invoice_Details_AspNetUsers_userCreateId",
                table: "invoice_Details",
                column: "userCreateId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_invoices_AspNetUsers_userCreateId",
                table: "invoices",
                column: "userCreateId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_products_AspNetUsers_userCreateId",
                table: "products",
                column: "userCreateId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoles_AspNetUsers_userCreateId",
                table: "AspNetRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_userCreateId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_binnacleBody_AspNetUsers_userCreateId",
                table: "binnacleBody");

            migrationBuilder.DropForeignKey(
                name: "FK_binnacleHeaders_AspNetUsers_userCreateId",
                table: "binnacleHeaders");

            migrationBuilder.DropForeignKey(
                name: "FK_brands_AspNetUsers_userCreateId",
                table: "brands");

            migrationBuilder.DropForeignKey(
                name: "FK_catalogues_AspNetUsers_userCreateId",
                table: "catalogues");

            migrationBuilder.DropForeignKey(
                name: "FK_clients_AspNetUsers_userCreateId",
                table: "clients");

            migrationBuilder.DropForeignKey(
                name: "FK_invoice_Details_AspNetUsers_userCreateId",
                table: "invoice_Details");

            migrationBuilder.DropForeignKey(
                name: "FK_invoices_AspNetUsers_userCreateId",
                table: "invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_products_AspNetUsers_userCreateId",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_userCreateId",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_invoices_userCreateId",
                table: "invoices");

            migrationBuilder.DropIndex(
                name: "IX_invoice_Details_userCreateId",
                table: "invoice_Details");

            migrationBuilder.DropIndex(
                name: "IX_clients_userCreateId",
                table: "clients");

            migrationBuilder.DropIndex(
                name: "IX_catalogues_userCreateId",
                table: "catalogues");

            migrationBuilder.DropIndex(
                name: "IX_brands_userCreateId",
                table: "brands");

            migrationBuilder.DropIndex(
                name: "IX_binnacleHeaders_userCreateId",
                table: "binnacleHeaders");

            migrationBuilder.DropIndex(
                name: "IX_binnacleBody_userCreateId",
                table: "binnacleBody");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_userCreateId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetRoles_userCreateId",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "userCreateId",
                table: "products");

            migrationBuilder.DropColumn(
                name: "userCreateId",
                table: "invoices");

            migrationBuilder.DropColumn(
                name: "userCreateId",
                table: "invoice_Details");

            migrationBuilder.DropColumn(
                name: "userCreateId",
                table: "clients");

            migrationBuilder.DropColumn(
                name: "userCreateId",
                table: "catalogues");

            migrationBuilder.DropColumn(
                name: "userCreateId",
                table: "brands");

            migrationBuilder.DropColumn(
                name: "userCreateId",
                table: "binnacleHeaders");

            migrationBuilder.DropColumn(
                name: "userCreateId",
                table: "binnacleBody");

            migrationBuilder.DropColumn(
                name: "userCreateId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "userCreateId",
                table: "AspNetRoles");
        }
    }
}
