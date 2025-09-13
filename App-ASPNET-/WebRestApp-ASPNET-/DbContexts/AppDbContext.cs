using Microsoft.EntityFrameworkCore;
using WebRestApp_ASPNET_.Models;

namespace WebRestApp_ASPNET_.DbContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }

        public DbSet<Alumno> Alumnos { get; set; }
    }
}
