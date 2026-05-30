using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebComputer.Migrations
{
    /// <inheritdoc />
    public partial class UpdateImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

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
                value: "asusvivobook14x.jpg");

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 10,
                column: "Image",
                value: "macair15m2.jpg");

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
                value: "keychronk8pro1.jpg");

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
                value: "sonywh1000xm5.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image",
                value: "SamsungSSD990PRO.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Description", "Image", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 6, "Corsair", "DDR5 6000MHz", "https://www.corsair.com/medias/sys_master/images/images/h2e/h34/10307134369822/-CMK32GX5M2B6000C36-Gallery-VENGEANCE-DDR5-01.png", "RAM Corsair Vengeance 32GB", 115.00m, 35 },
                    { 7, "NVIDIA", "Card đồ họa 12GB GDDR6X", "https://www.nvidia.com/content/dam/en-zz/Solutions/geforce/ada/rtx-4070-ti/geforce-rtx-4070-ti-gallery-b.jpg", "VGA RTX 4070 Ti", 799.00m, 10 },
                    { 8, "NZXT", "Tản nhiệt nước AIO có màn LCD", "https://nzxt.com/assets/cms/34299/1682518736-kraken-240-rgb-black-1.png", "Tản nhiệt NZXT Kraken 240", 139.00m, 25 },
                    { 9, "Shure", "Micro thu âm chuẩn Studio", "https://www.shure.com/damfiles/default/global/products/microphones/sm7b/sm7b-front.png", "Micro Shure SM7B", 399.00m, 12 },
                    { 10, "SteelSeries", "Lót chuột size L", "https://media.steelseriescdn.com/thumbs/catalog/items/63842/63842_img1.png", "Bàn di chuột SteelSeries", 15.00m, 100 }
                });
        }
    }
}
