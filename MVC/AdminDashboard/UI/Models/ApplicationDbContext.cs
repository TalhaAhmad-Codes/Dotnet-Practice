using Microsoft.EntityFrameworkCore;
using UI.Models.Entities;

namespace UI.Models
{
    public class ApplicationDbContext : DbContext
    {
        /*/ <----- DbSets for Model Entities -----> /*/
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }

        // Constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}
