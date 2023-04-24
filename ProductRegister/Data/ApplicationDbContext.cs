using Microsoft.EntityFrameworkCore;
using ProductRegister.Models;

namespace ProductRegister.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<CategoryModel> Categories { get; set; }
    }
}
