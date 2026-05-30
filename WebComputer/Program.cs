using WebComputer.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// 1. Lấy chuỗi kết nối từ appsettings.json
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
    ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

// 2. Đăng ký ApplicationDbContext sử dụng SQL Server với vòng đời Scoped
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

// Thêm các dịch vụ cho kiến trúc MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Cấu hình HTTP request pipeline kế tiếp...
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles(); // Quan trọng: Giúp truy cập các file ảnh trong wwwroot/uploads

app.UseRouting();

app.UseAuthorization();

// Định tuyến URL mặc định cho ứng dụng
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();