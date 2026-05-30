using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using WebComputer.Data;
using WebComputer.Models;
using WebComputer.ViewModels;

namespace WebComputer.Controllers
{
    public class ComputerController : Controller
    {
        private readonly ApplicationDbContext _context;

        // Tiêm Dependency Injection (DI) vào Constructor (Đã bỏ IWebHostEnvironment)
        public ComputerController(ApplicationDbContext context)
        {
            _context = context;
        }

        // ==========================================
        // 1. ĐỌC DỮ LIỆU (READ) - LẤY DANH SÁCH
        // ==========================================
        public IActionResult Index()
        {
            var computers = _context.Computers.ToList();
            return View(computers);
        }

        // ==========================================
        // 2. THÊM MỚI (CREATE)
        // ==========================================
        [HttpGet]
        public IActionResult Create()
        {
            return View(new ComputerFormViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ComputerFormViewModel model)
        {
            if (ModelState.IsValid)
            {
                var computer = new Computer
                {
                    Name = model.Name,
                    Brand = model.Brand,
                    Price = model.Price,
                    Quantity = model.Quantity,
                    Description = model.Description,
                    Image = model.ImageUrl // Gán trực tiếp URL ảnh
                };

                _context.Computers.Add(computer);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // ==========================================
        // 3. CẬP NHẬT (UPDATE)
        // ==========================================
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var computer = _context.Computers.Find(id);
            if (computer == null) return NotFound();

            var viewModel = new ComputerFormViewModel
            {
                Id = computer.Id,
                Name = computer.Name,
                Brand = computer.Brand,
                Price = computer.Price,
                Quantity = computer.Quantity,
                Description = computer.Description,
                ImageUrl = computer.Image // Lấy URL cũ truyền ra view
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, ComputerFormViewModel model)
        {
            if (id != model.Id) return NotFound();

            if (ModelState.IsValid)
            {
                var computer = _context.Computers.Find(model.Id);
                if (computer == null) return NotFound();

                computer.Name = model.Name;
                computer.Brand = model.Brand;
                computer.Price = model.Price;
                computer.Quantity = model.Quantity;
                computer.Description = model.Description;
                computer.Image = model.ImageUrl; // Cập nhật URL ảnh mới

                _context.Computers.Update(computer);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // ==========================================
        // 4. XÓA (DELETE)
        // ==========================================
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var computer = _context.Computers.Find(id);
            if (computer == null) return NotFound();
            return View(computer);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var computer = _context.Computers.Find(id);
            if (computer != null)
            {
                // Chỉ xóa data trong DB, không cần xóa file vật lý nữa
                _context.Computers.Remove(computer);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}