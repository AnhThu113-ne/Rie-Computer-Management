using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebComputer.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên sản phẩm không được để trống")]
        [StringLength(150, ErrorMessage = "Tên sản phẩm không quá 150 ký tự")]
        [Display(Name = "Tên sản phẩm")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Thương hiệu không được để trống")]
        [StringLength(50)]
        [Display(Name = "Thương hiệu")]
        public string Brand { get; set; } = string.Empty;

        [Required(ErrorMessage = "Giá bán không được để trống")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Giá bán phải lớn hơn 0")]
        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Giá bán")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Số lượng không được để trống")]
        [Range(0, int.MaxValue, ErrorMessage = "Số lượng không được là số âm")]
        [Display(Name = "Số lượng")]
        public int Quantity { get; set; }

        [MaxLength]
        [Display(Name = "Hình ảnh")]
        public string Image { get; set; } = "default.jpg";

        [Display(Name = "Mô tả chi tiết")]
        public string? Description { get; set; }
    }
}