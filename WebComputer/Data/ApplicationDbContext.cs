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
                new Computer { Id = 1, Name = "Dell XPS 15 9530", Brand = "Dell", Price = 1850.50m, Quantity = 15, Image = "xps15.jpg", Description = "CPU: Core i7-13700H, RAM: 16GB DDR5, SSD: 1TB" },
                new Computer { Id = 2, Name = "MacBook Pro 14 M3", Brand = "Apple", Price = 1999.00m, Quantity = 10, Image = "macpro14.jpg", Description = "CPU: Apple M3 Pro, RAM: 18GB, SSD: 512GB" },
                new Computer { Id = 3, Name = "Asus ROG Strix G16", Brand = "Asus", Price = 1650.00m, Quantity = 8, Image = "rogg16.jpg", Description = "CPU: Core i9, RAM: 32GB, VGA: RTX 4070" },
                new Computer { Id = 4, Name = "HP Spectre x360 14", Brand = "HP", Price = 1450.00m, Quantity = 12, Image = "spectre14.jpg", Description = "CPU: Core i7, RAM: 16GB, Cảm ứng 2-in-1" },
                new Computer { Id = 5, Name = "Lenovo ThinkPad X1", Brand = "Lenovo", Price = 1700.00m, Quantity = 20, Image = "thinkpad.jpg", Description = "Trọng lượng siêu nhẹ 1.1kg, Cực bền bỉ" },
                new Computer { Id = 6, Name = "Acer Predator Helios", Brand = "Acer", Price = 1550.00m, Quantity = 7, Image = "helios300.jpg", Description = "VGA: RTX 3070 Ti, Màn hình 165Hz" },
                new Computer { Id = 7, Name = "MSI Stealth 16 Studio", Brand = "MSI", Price = 1800.00m, Quantity = 5, Image = "stealth16.jpg", Description = "Thiết kế kim loại nguyên khối, RTX 4060" },
                new Computer { Id = 8, Name = "Dell Inspiron 15", Brand = "Dell", Price = 650.00m, Quantity = 30, Image = "inspiron15.jpg", Description = "Laptop văn phòng giá rẻ, Core i5 thế hệ 12" },
                new Computer { Id = 9, Name = "Asus VivoBook 14X", Brand = "Asus", Price = 850.00m, Quantity = 25, Image = "asusvivobook14x.jpg", Description = "Màn hình OLED sắc nét, Ryzen 7" },
                new Computer { Id = 10, Name = "MacBook Air 15 M2", Brand = "Apple", Price = 1299.00m, Quantity = 18, Image = "macair15m2.jpg", Description = "Pin 18 tiếng, Màn hình 15.3 inch" }
            );

            // Seed dữ liệu cho bảng Products với URL thực tế
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Chuột Logitech MX Master 3S", Brand = "Logitech", Price = 99.99m, Quantity = 50, Image = "mxmaster3s.jpg", Description = "Chuột công thái học cao cấp" },
                new Product { Id = 2, Name = "Bàn phím Keychron K8 Pro", Brand = "Keychron", Price = 110.00m, Quantity = 30, Image = "keychronk8pro1.jpg", Description = "Bàn phím cơ không dây TKL" },
                new Product { Id = 3, Name = "Màn hình Dell U2723QE", Brand = "Dell", Price = 550.00m, Quantity = 15, Image = "u2723qe.jpg", Description = "Màn hình 27 inch 4K chuẩn màu đồ họa" },
                new Product { Id = 4, Name = "Tai nghe Sony WH-1000XM5", Brand = "Sony", Price = 349.00m, Quantity = 20, Image = "sonywh1000xm5.jpg", Description = "Tai nghe Over-ear chống ồn chủ động" },
                new Product { Id = 5, Name = "SSD Samsung 990 PRO 1TB", Brand = "Samsung", Price = 129.50m, Quantity = 40, Image = "SamsungSSD990PRO.jpg", Description = "Tốc độ đọc 7450 MB/s" }
            );
        }
    }
}