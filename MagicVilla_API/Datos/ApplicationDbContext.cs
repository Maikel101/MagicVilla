using MagicVilla_API.Modelos;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_API.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        //Tablas de la base de datos
        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id= 1,
                    Nombre="Villa Real",
                    Detalle="Detalle de la Villa...",
                    ImagenUrl="",
                    Ocupantes=5,
                    MetrosCuadrados=50,
                    Tarifa=200,
                    Amenidad="",
                    FechaCreacion=DateTime.Now,
                    FechaAcualizacion=DateTime.Now
                },
                  new Villa()
                  {
                      Id = 2,
                      Nombre = "Premium vista a la Playa",
                      Detalle = "Detalle de la Villa...",
                      ImagenUrl = "",
                      Ocupantes = 6,
                      MetrosCuadrados = 80,
                      Tarifa = 250,
                      Amenidad = "",
                      FechaCreacion = DateTime.Now,
                      FechaAcualizacion = DateTime.Now
                  }
          );
        }
    }
}
