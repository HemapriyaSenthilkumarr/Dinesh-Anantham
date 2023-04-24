using System.ComponentModel.DataAnnotations;

namespace ProductRegister.Models
{
    public class CategoryModel
    {
        [Key]
        public string ProductName { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public int Price { get; set; }
    }
}
