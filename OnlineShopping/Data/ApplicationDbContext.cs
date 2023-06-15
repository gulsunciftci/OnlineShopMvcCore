using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineShopping.Models;

namespace OnlineShopping.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ProductTypes> ProductTypes { get; set; }
        public DbSet<SpecialTags>  SpecialTags { get; set; }

        public DbSet<Products> Products { get; set; }

        public DbSet<Orders> Orders { get; set; }

        public DbSet<OrdersDetails> OrdersDetails { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

    }
}
