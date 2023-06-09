using Microsoft.EntityFrameworkCore;
using TallerBackendMaciasIbarbo.models;

namespace TallerBackendMaciasIbarbo
{
    public class AplicationDBContext : DbContext
    {
        public AplicationDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Genero> Sexo { get; set; }
        public DbSet<Usuario> Persona { get; set; }

    }
}

