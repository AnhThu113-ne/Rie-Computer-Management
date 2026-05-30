using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebComputer.Migrations
{
    /// <inheritdoc />
    public partial class UpdateImageUrls : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Computers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "https://m.media-amazon.com/images/I/71c5W9NxN5L._AC_SL1500_.jpg");

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "https://m.media-amazon.com/images/I/61jLiCovxVL._AC_SL1500_.jpg");

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "https://m.media-amazon.com/images/I/71sF78D8cUL._AC_SL1500_.jpg");

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "https://m.media-amazon.com/images/I/71YV6xXhQKL._AC_SL1500_.jpg");

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image",
                value: "https://m.media-amazon.com/images/I/51rG-8qA0PL._AC_SL1500_.jpg");

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 6,
                column: "Image",
                value: "https://m.media-amazon.com/images/I/71NZiNWEsIL._AC_SL1500_.jpg");

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 7,
                column: "Image",
                value: "https://m.media-amazon.com/images/I/71qG5wD5e-L._AC_SL1500_.jpg");

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 8,
                column: "Image",
                value: "https://m.media-amazon.com/images/I/71WN-NpqBmL._AC_SL1500_.jpg");

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 9,
                column: "Image",
                value: "https://m.media-amazon.com/images/I/71q8Fk5P3lL._AC_SL1500_.jpg");

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 10,
                column: "Image",
                value: "https://m.media-amazon.com/images/I/81Fm0tFikPL._AC_SL1500_.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "https://m.media-amazon.com/images/I/61ni3t1ryQL._AC_SL1500_.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "https://m.media-amazon.com/images/I/61u+v9D77vL._AC_SL1500_.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "https://m.media-amazon.com/images/I/81dG19+E0xL._AC_SL1500_.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "https://m.media-amazon.com/images/I/51aXvjzcukL._AC_SL1500_.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image",
                value: "https://m.media-amazon.com/images/I/81fHmA9+kGL._AC_SL1500_.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Image",
                value: "https://m.media-amazon.com/images/I/61u9K5b1qDL._AC_SL1500_.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "Image",
                value: "https://m.media-amazon.com/images/I/717v3t0Lz3L._AC_SL1500_.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "Image",
                value: "https://m.media-amazon.com/images/I/71G1f-jO0bL._AC_SL1500_.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "Image",
                value: "https://m.media-amazon.com/images/I/61zC4X++-KL._AC_SL1500_.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "Image",
                value: "https://m.media-amazon.com/images/I/51wB7-7LhtL._AC_SL1500_.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Products",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Computers",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "xps15.jpg");

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "macpro14.jpg");

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "rogg16.jpg");

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "spectre14.jpg");

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image",
                value: "thinkpad.jpg");

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 6,
                column: "Image",
                value: "helios300.jpg");

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 7,
                column: "Image",
                value: "stealth16.jpg");

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 8,
                column: "Image",
                value: "inspiron15.jpg");

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 9,
                column: "Image",
                value: "vivobook.jpg");

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 10,
                column: "Image",
                value: "macair15.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "mxmaster3s.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "k8pro.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "u2723qe.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "xm5.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image",
                value: "990pro.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Image",
                value: "vengeance.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "Image",
                value: "4070ti.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "Image",
                value: "kraken240.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "Image",
                value: "sm7b.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "Image",
                value: "qck.jpg");
        }
    }
}
