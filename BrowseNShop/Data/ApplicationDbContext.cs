using System;
using System.Collections.Generic;
using System.Text;
using BrowseNShop.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BrowseNShop.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Sneaker> Sneakers { get; set; }
        public DbSet<Category> Categories { get; set; }




    }
}
