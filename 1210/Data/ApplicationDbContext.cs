using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using _1210.Models;

namespace _1210.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
