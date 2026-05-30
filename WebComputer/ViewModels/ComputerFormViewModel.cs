using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace WebComputer.ViewModels
{
    public class ComputerFormViewModel
    {
        // Thuộc tính Id dùng để xác định sản phẩm khi cập nhật (Edit)
        // Khi tạo mới (Create) thì Id = 0 (mặc định)
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên máy tính không được để trống")]
        [StringLength(150, ErrorMessage = "Tên máy tính không quá 150 ký tự")]
        [Display(Name = "Tên máy tính")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Hãng sản xuất không được để trống")]
        [StringLength(50)]
        [Display(Name = "Hãng sản xuất")]
        public string Brand { get; set; } = string.Empty;

        [Required(ErrorMessage = "Giá bán không được để trống")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Giá bán phải lớn hơn 0")]
        [Display(Name = "Giá bán")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Số lượng không được để trống")]
        [Range(0, int.MaxValue, ErrorMessage = "Số lượng không được là số âm")]
        [Display(Name = "Số lượng")]
        public int Quantity { get; set; }

        [Display(Name = "Mô tả chi tiết")]
        public string? Description { get; set; }

        // -----------------------------------------------------------
        // XỬ LÝ ẢNH BẰNG URL
        // -----------------------------------------------------------

        [Display(Name = "Đường dẫn ảnh (URL)")]
        [Required(ErrorMessage = "Vui lòng nhập đường dẫn hình ảnh")]
        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; } = string.Empty;

        // Added to match the file-input in the Create view
        public IFormFile? ImageUpload { get; set; }

        [System.ComponentModel.DataAnnotations.Display(Name = "Existing Image")]
        public string ExistingImage { get; set; }
    }
}