using System.ComponentModel.DataAnnotations;

namespace OnlineShopping.Models
{
    public class SpecialTags
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string SpecialTag { get; set; }
    }
}
