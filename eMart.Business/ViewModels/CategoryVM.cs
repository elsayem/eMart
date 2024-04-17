using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMart.Business.ViewModels
{
    public class CategoryVM
    {
        public int Id { get; set; }
    
        [MinLength(3,ErrorMessage ="Name Must be more than two character !")]
        [Required(ErrorMessage ="Category Name is required")]
        [Display(Name="Category Name")]
        public string Name { get; set; }

        [MinLength(3, ErrorMessage = "Description Must be more than two character !")]
        public string? Description { get; set; }

        public byte[]? Thumbnail { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public bool IsDeleted { get; set; } = false;

    }
}
