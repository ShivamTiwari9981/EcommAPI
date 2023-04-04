using System.ComponentModel.DataAnnotations;

namespace EcommAPI.Model
{
    public class CategoryModel:BaseModel
    {
        public int CategoryId { get; set; }
        [Required]
        public string CategoryName { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
