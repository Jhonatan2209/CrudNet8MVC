using CrudNet8MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudNet8MVC.Datos
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        // agregar los modelos (cada modelo corresponde a una tabla en la BD)
        public DbSet<User> usuario { get; set; }
    }
}
