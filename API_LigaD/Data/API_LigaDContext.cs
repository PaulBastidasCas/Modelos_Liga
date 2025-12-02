using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Modelos_Liga;

namespace API_LigaD.Data
{
    public class API_LigaDContext : DbContext
    {
        public API_LigaDContext (DbContextOptions<API_LigaDContext> options)
            : base(options)
        {
        }

        public DbSet<Modelos_Liga.Torneo> Torneo { get; set; } = default!;
        public DbSet<Modelos_Liga.Partido> Partido { get; set; } = default!;
        public DbSet<Modelos_Liga.Detalle> Detalle { get; set; } = default!;
    }
}
