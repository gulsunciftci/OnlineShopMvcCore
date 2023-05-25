﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShopping.Models
{
    public class Products
    {
        [Key]
        public int Product { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        public string Image { get; set; }

        [Display(Name = "Product Color")]
        public string ProductColor { get; set; }

        [Required]
        [Display(Name = "Available")]
        public bool IsAvailable { get; set; }


        [Display(Name = "Special Tag")]
        [Required]
        public int SpecialTagId { get; set; }


        [ForeignKey("SpecialTagId")]
        public SpecialTags SpecialTags { get; set; }


        [Display(Name = "Product Type")]
        [Required]
        public int ProductTypeId { get; set; }

        [ForeignKey("ProductTypeId")]

        public ProductTypes ProductTypes { get; set; }
    }
}
