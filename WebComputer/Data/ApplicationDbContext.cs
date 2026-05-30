using Microsoft.EntityFrameworkCore;
using WebComputer.Models;

namespace WebComputer.Data
{
    public class ApplicationDbContext : DbContext
    {
        // Constructor tiếp nhận các cấu hình (chuỗi kết nối) từ Program.cs truyền vào
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Khai báo DbSet đại diện cho bảng Computers và Products trong CSDL
        public DbSet<Computer> Computers { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Cấu hình tên bảng rõ ràng trong DB thay vì tự động sinh
            modelBuilder.Entity<Computer>().ToTable("Computers");
            modelBuilder.Entity<Product>().ToTable("Products");

            // Seed dữ liệu cho bảng Computers với URL thực tế
            modelBuilder.Entity<Computer>().HasData(
                new Computer { Id = 1, Name = "Dell XPS 15 9530", Brand = "Dell", Price = 1850.50m, Quantity = 15, Image = "https://m.media-amazon.com/images/I/71c5W9NxN5L._AC_SL1500_.jpg", Description = "CPU: Core i7-13700H, RAM: 16GB DDR5, SSD: 1TB" },
                new Computer { Id = 2, Name = "MacBook Pro 14 M3", Brand = "Apple", Price = 1999.00m, Quantity = 10, Image = "https://m.media-amazon.com/images/I/61jLiCovxVL._AC_SL1500_.jpg", Description = "CPU: Apple M3 Pro, RAM: 18GB, SSD: 512GB" },
                new Computer { Id = 3, Name = "Asus ROG Strix G16", Brand = "Asus", Price = 1650.00m, Quantity = 8, Image = "https://m.media-amazon.com/images/I/71sF78D8cUL._AC_SL1500_.jpg", Description = "CPU: Core i9, RAM: 32GB, VGA: RTX 4070" },
                new Computer { Id = 4, Name = "HP Spectre x360 14", Brand = "HP", Price = 1450.00m, Quantity = 12, Image = "https://m.media-amazon.com/images/I/71YV6xXhQKL._AC_SL1500_.jpg", Description = "CPU: Core i7, RAM: 16GB, Cảm ứng 2-in-1" },
                new Computer { Id = 5, Name = "Lenovo ThinkPad X1", Brand = "Lenovo", Price = 1700.00m, Quantity = 20, Image = "https://m.media-amazon.com/images/I/51rG-8qA0PL._AC_SL1500_.jpg", Description = "Trọng lượng siêu nhẹ 1.1kg, Cực bền bỉ" },
                new Computer { Id = 6, Name = "Acer Predator Helios", Brand = "Acer", Price = 1550.00m, Quantity = 7, Image = "https://m.media-amazon.com/images/I/71NZiNWEsIL._AC_SL1500_.jpg", Description = "VGA: RTX 3070 Ti, Màn hình 165Hz" },
                new Computer { Id = 7, Name = "MSI Stealth 16 Studio", Brand = "MSI", Price = 1800.00m, Quantity = 5, Image = "https://m.media-amazon.com/images/I/71qG5wD5e-L._AC_SL1500_.jpg", Description = "Thiết kế kim loại nguyên khối, RTX 4060" },
                new Computer { Id = 8, Name = "Dell Inspiron 15", Brand = "Dell", Price = 650.00m, Quantity = 30, Image = "https://m.media-amazon.com/images/I/71WN-NpqBmL._AC_SL1500_.jpg", Description = "Laptop văn phòng giá rẻ, Core i5 thế hệ 12" },
                new Computer { Id = 9, Name = "Asus VivoBook 14X", Brand = "Asus", Price = 850.00m, Quantity = 25, Image = "https://m.media-amazon.com/images/I/71q8Fk5P3lL._AC_SL1500_.jpg", Description = "Màn hình OLED sắc nét, Ryzen 7" },
                new Computer { Id = 10, Name = "MacBook Air 15 M2", Brand = "Apple", Price = 1299.00m, Quantity = 18, Image = "https://m.media-amazon.com/images/I/81Fm0tFikPL._AC_SL1500_.jpg", Description = "Pin 18 tiếng, Màn hình 15.3 inch" }
            );

            // Seed dữ liệu cho bảng Products với URL thực tế
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Chuột Logitech MX Master 3S", Brand = "Logitech", Price = 99.99m, Quantity = 50, Image = "https://m.media-amazon.com/images/I/61ni3t1ryQL._AC_SL1500_.jpg", Description = "Chuột công thái học cao cấp" },
                new Product { Id = 2, Name = "Bàn phím Keychron K8 Pro", Brand = "Keychron", Price = 110.00m, Quantity = 30, Image = "https://m.media-amazon.com/images/I/61u+v9D77vL._AC_SL1500_.jpg", Description = "Bàn phím cơ không dây TKL" },
                new Product { Id = 3, Name = "Màn hình Dell U2723QE", Brand = "Dell", Price = 550.00m, Quantity = 15, Image = "https://m.media-amazon.com/images/I/81dG19+E0xL._AC_SL1500_.jpg", Description = "Màn hình 27 inch 4K chuẩn màu đồ họa" },
                new Product { Id = 4, Name = "Tai nghe Sony WH-1000XM5", Brand = "Sony", Price = 349.00m, Quantity = 20, Image = "https://m.media-amazon.com/images/I/51aXvjzcukL._AC_SL1500_.jpg", Description = "Tai nghe Over-ear chống ồn chủ động" },
                new Product { Id = 5, Name = "SSD Samsung 990 PRO 1TB", Brand = "Samsung", Price = 129.50m, Quantity = 40, Image = "https://m.media-amazon.com/images/I/81fHmA9+kGL._AC_SL1500_.jpg", Description = "Tốc độ đọc 7450 MB/s" },
                new Product { Id = 6, Name = "RAM Corsair Vengeance 32GB", Brand = "Corsair", Price = 115.00m, Quantity = 35, Image = "https://m.media-amazon.com/images/I/61u9K5b1qDL._AC_SL1500_.jpg", Description = "DDR5 6000MHz" },
                new Product { Id = 7, Name = "VGA RTX 4070 Ti", Brand = "NVIDIA", Price = 799.00m, Quantity = 10, Image = "https://m.media-amazon.com/images/I/717v3t0Lz3L._AC_SL1500_.jpg", Description = "Card đồ họa 12GB GDDR6X" },
                new Product { Id = 8, Name = "Tản nhiệt NZXT Kraken 240", Brand = "NZXT", Price = 139.00m, Quantity = 25, Image = "https://m.media-amazon.com/images/I/71G1f-jO0bL._AC_SL1500_.jpg", Description = "Tản nhiệt nước AIO có màn LCD" },
                new Product { Id = 9, Name = "Micro Shure SM7B", Brand = "Shure", Price = 399.00m, Quantity = 12, Image = "https://m.media-amazon.com/images/I/61zC4X++-KL._AC_SL1500_.jpg", Description = "Micro thu âm chuẩn Studio" },
                new Product { Id = 10, Name = "Bàn di chuột SteelSeries", Brand = "SteelSeries", Price = 15.00m, Quantity = 100, Image = "https://m.media-amazon.com/images/I/51wB7-7LhtL._AC_SL1500_.jpg", Description = "Lót chuột size L" }
            );
        }
    }
}