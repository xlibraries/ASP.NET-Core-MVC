using BulkyBook.Models;
using Microsoft.EntityFrameworkCore;


namespace BulkyBook.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //It will create a Category table with name Categories with four columns present in category
        public DbSet<Category> Categories { get; set; }
        public DbSet<CoverType> CoverTypes { get; set; }
    }
}