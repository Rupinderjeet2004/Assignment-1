using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Assignment1.Models;

namespace AssignmentASP1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Assignment1.Models.Manufacturers> Manufacturers { get; set; }
        public DbSet<Assignment1.Models.Products> Products { get; set; }
    }
}
