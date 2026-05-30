using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebComputer.Migrations
{
    /// <inheritdoc />
    public partial class UpdateImageUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "https://www.thegioididong.com/laptop/dell-xps-15-9530-i7-71015716");

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "https://cdn2.cellphones.com.vn/insecure/rs:fill:0:0/q:100/plain/https://cellphones.com.vn/media/wysiwyg/laptop/macbook/macbook-pro/2023/macbook-pro-14-inch-m3-pro-2023-18gb-512gb-2.jpg");

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "https://bizweb.dktcdn.net/thumb/grande/100/512/769/products/asus-rog-strix-g16-g615lr-3-19c20be4-e461-4b04-83b5-2c5bb0624e7e.jpg?v=1779248054407");

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "https://www.hp.com/content/dam/sites/worldwide/personal-computers/consumer/laptops/spectre-x360-14/images/hp-spectre-x360-14.png");

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image",
                value: "https://p4-ofp.static.pub/fes/cms/2024/01/16/8f0d2iw3k0m3c3v7n4t8s1whh8h2r884.png");

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 6,
                column: "Image",
                value: "https://static.acer.com/up/Resource/Acer/Predator_Helios_16/Product_Gallery/20230104/Predator-Helios-16-PH16-71-black-01.png");

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 7,
                column: "Image",
                value: "https://storage-asset.msi.com/global/picture/image/feature/nb/Stealth/stealth16studioa13v/images/kv-nb.png");

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 8,
                column: "Image",
                value: "https://i.dell.com/is/image/DellContent/content/dam/ss2/product-images/page/category/laptop/inspiron-15-3530-laptop.png");

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 9,
                column: "Image",
                value: "https://dlcdnwebimgs.asus.com/gain/6B8BCE70-6F3C-4F17-A1C3-54E64F9A9E2A/w800");

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 10,
                column: "Image",
                value: "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/macbook-air-15-midnight-gallery1-202306");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "https://resource.logitech.com/w_800,c_limit,q_auto,f_auto,dpr_1.0/content/dam/logitech/en/products/mice/mx-master-3s/gallery/mx-master-3s-top-view-graphite.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "https://cdn.shopify.com/s/files/1/0059/0630/1017/products/Keychron-K8-Pro-QMK-VIA-Wireless-Mechanical-Keyboard.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "https://i.dell.com/is/image/DellContent/content/dam/images/products/monitors/u-series/u2723qe/u2723qe-monitor-gallery-1.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "https://sony.scene7.com/is/image/sonyglobalsolutions/wh-1000xm5-black-gallery-image-1");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image",
                value: "https://images.samsung.com/is/image/samsung/p6pim/vn/mz-v9p1t0bw/gallery/vn-990-pro-mz-v9p1t0bw-537129645");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Image",
                value: "https://www.corsair.com/medias/sys_master/images/images/h2e/h34/10307134369822/-CMK32GX5M2B6000C36-Gallery-VENGEANCE-DDR5-01.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "Image",
                value: "https://www.nvidia.com/content/dam/en-zz/Solutions/geforce/ada/rtx-4070-ti/geforce-rtx-4070-ti-gallery-b.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "Image",
                value: "https://nzxt.com/assets/cms/34299/1682518736-kraken-240-rgb-black-1.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "Image",
                value: "https://www.shure.com/damfiles/default/global/products/microphones/sm7b/sm7b-front.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "Image",
                value: "https://media.steelseriescdn.com/thumbs/catalog/items/63842/63842_img1.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
