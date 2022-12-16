using Microsoft.EntityFrameworkCore;
using Prueba_3.Models;

namespace Prueba_3.Context
{
    public class Prueba3DbContext: DbContext
    {
        public Prueba3DbContext(DbContextOptions<Prueba3DbContext> options)
           : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<PersonaClass> Persona { get; set; }
    }
}
