using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PizzaExpress.Models;

namespace PizzaExpress.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<CategoryInfo> Categories { get; set; }
        public DbSet<ProductInfo> Products { get; set; }

        public DbSet<EnquiryInfo> Enquiries { get; set; }
    }
}
