using HSM2.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace HSM2.Dbcontext
{
    public class ApplicationDbContext : DbContext
    {
        // DbSet también debe ser público para que se pueda acceder fuera del contexto
        public DbSet<HsmData> HsmData { get; set; }

        // Constructor que configura el contexto, si es necesario, puedes configurarlo aquí
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
