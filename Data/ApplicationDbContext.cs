using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CO550TeamProject.Models;

namespace CO550TeamProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CO550TeamProject.Models.Customer> Customer { get; set; }
        public DbSet<CO550TeamProject.Models.CustomerAddress> CustomerAddress { get; set; }
        public DbSet<CO550TeamProject.Models.CustomerPayment> CustomerPayment { get; set; }
    }
}