using System.ComponentModel.DataAnnotations;

namespace OnlineShopping.Models
{
    public class OrdersDetails
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Orders")]
        public int OrdersId { get; set; }
        [Display(Name = "Product")]
        public int ProductsProduct { get; set; }

        public Orders Orders { get; set; }

        public Products Products { get; set; }
    }
}
