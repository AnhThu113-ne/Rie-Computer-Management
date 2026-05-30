using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebComputer.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Computers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Computers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Computers",
                columns: new[] { "Id", "Brand", "Description", "Image", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, "Dell", "CPU: Core i7-13700H, RAM: 16GB DDR5, SSD: 1TB", "xps15.jpg", "Dell XPS 15 9530", 1850.50m, 15 },
                    { 2, "Apple", "CPU: Apple M3 Pro, RAM: 18GB, SSD: 512GB", "macpro14.jpg", "MacBook Pro 14 M3", 1999.00m, 10 },
                    { 3, "Asus", "CPU: Core i9, RAM: 32GB, VGA: RTX 4070", "rogg16.jpg", "Asus ROG Strix G16", 1650.00m, 8 },
                    { 4, "HP", "CPU: Core i7, RAM: 16GB, Cảm ứng 2-in-1", "spectre14.jpg", "HP Spectre x360 14", 1450.00m, 12 },
                    { 5, "Lenovo", "Trọng lượng siêu nhẹ 1.1kg, Cực bền bỉ", "thinkpad.jpg", "Lenovo ThinkPad X1", 1700.00m, 20 },
                    { 6, "Acer", "VGA: RTX 3070 Ti, Màn hình 165Hz", "helios300.jpg", "Acer Predator Helios", 1550.00m, 7 },
                    { 7, "MSI", "Thiết kế kim loại nguyên khối, RTX 4060", "stealth16.jpg", "MSI Stealth 16 Studio", 1800.00m, 5 },
                    { 8, "Dell", "Laptop văn phòng giá rẻ, Core i5 thế hệ 12", "inspiron15.jpg", "Dell Inspiron 15", 650.00m, 30 },
                    { 9, "Asus", "Màn hình OLED sắc nét, Ryzen 7", "vivobook.jpg", "Asus VivoBook 14X", 850.00m, 25 },
                    { 10, "Apple", "Pin 18 tiếng, Màn hình 15.3 inch", "macair15.jpg", "MacBook Air 15 M2", 1299.00m, 18 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Description", "Image", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, "Logitech", "Chuột công thái học cao cấp", "mxmaster3s.jpg", "Chuột Logitech MX Master 3S", 99.99m, 50 },
                    { 2, "Keychron", "Bàn phím cơ không dây TKL", "k8pro.jpg", "Bàn phím Keychron K8 Pro", 110.00m, 30 },
                    { 3, "Dell", "Màn hình 27 inch 4K chuẩn màu đồ họa", "u2723qe.jpg", "Màn hình Dell U2723QE", 550.00m, 15 },
                    { 4, "Sony", "Tai nghe Over-ear chống ồn chủ động", "xm5.jpg", "Tai nghe Sony WH-1000XM5", 349.00m, 20 },
                    { 5, "Samsung", "Tốc độ đọc 7450 MB/s", "990pro.jpg", "SSD Samsung 990 PRO 1TB", 129.50m, 40 },
                    { 6, "Corsair", "DDR5 6000MHz", "vengeance.jpg", "RAM Corsair Vengeance 32GB", 115.00m, 35 },
                    { 7, "NVIDIA", "Card đồ họa 12GB GDDR6X", "4070ti.jpg", "VGA RTX 4070 Ti", 799.00m, 10 },
                    { 8, "NZXT", "Tản nhiệt nước AIO có màn LCD", "kraken240.jpg", "Tản nhiệt NZXT Kraken 240", 139.00m, 25 },
                    { 9, "Shure", "Micro thu âm chuẩn Studio", "sm7b.jpg", "Micro Shure SM7B", 399.00m, 12 },
                    { 10, "SteelSeries", "Lót chuột size L", "qck.jpg", "Bàn di chuột SteelSeries", 15.00m, 100 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Computers");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
