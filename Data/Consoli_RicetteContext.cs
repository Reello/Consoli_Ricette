using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Consoli_Ricette.Models;

namespace Consoli_Ricette.Data
{
    public class Consoli_RicetteContext : DbContext
    {
        public Consoli_RicetteContext (DbContextOptions<Consoli_RicetteContext> options)
            : base(options)
        {
        }

        public DbSet<Consoli_Ricette.Models.Recipe> Recipe { get; set; }
    }
}
