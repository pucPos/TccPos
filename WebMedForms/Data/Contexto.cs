using Microsoft.EntityFrameworkCore;
using WebMedForms.Models;

namespace WebMedForms.Data
{
    public class Contexto : DbContext
    {
        public Contexto()
        {
        }

        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        { }
        public DbSet<Usuario>Usuario { get; set; }
        public DbSet<Solicitacao>Solicitacao { get; set; }
    }
}
