using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using WebComputer.Data;

namespace WebComputer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // ==========================================
        // 1. TRANG CHỦ: TÌM KIẾM VÀ LỌC SẢN PHẨM
        // ==========================================
        // Thêm 2 tham số: searchString (Tìm theo tên) và brand (Lọc theo hãng)
        public IActionResult Index(string searchString, string brand)
        {
            // 1. Lấy query gốc (chưa thực thi vào DB ngay)
            var computers = from c in _context.Computers
                            select c;

            // 2. Lấy danh sách các Hãng (Brand) không trùng lặp để đưa ra Dropdown (Select box)
            var brandQuery = _context.Computers.Select(c => c.Brand).Distinct();
            ViewBag.Brands = new SelectList(brandQuery.ToList());

            // Giữ lại giá trị người dùng vừa tìm để hiển thị lại trên thanh tìm kiếm
            ViewBag.CurrentSearch = searchString;
            ViewBag.CurrentBrand = brand;

            // 3. Nếu người dùng có nhập ô Tìm kiếm
            if (!string.IsNullOrEmpty(searchString))
            {
                // Lọc tên máy có chứa chuỗi tìm kiếm
                computers = computers.Where(c => c.Name.Contains(searchString));
            }

            // 4. Nếu người dùng có chọn Hãng để lọc
            if (!string.IsNullOrEmpty(brand))
            {
                // Lọc chính xác hãng
                computers = computers.Where(c => c.Brand == brand);
            }

            // 5. Sắp xếp ưu tiên máy còn hàng lên trước và thực thi lệnh lấy dữ liệu
            var result = computers.OrderByDescending(c => c.Quantity > 0).ToList();

            return View(result);
        }

        // ==========================================
        // 2. TRANG CHI TIẾT SẢN PHẨM (Giữ nguyên)
        // ==========================================
        public IActionResult Detail(int id)
        {
            var computer = _context.Computers.Find(id);
            if (computer == null) return NotFound();
            return View(computer);
        }
    }
}