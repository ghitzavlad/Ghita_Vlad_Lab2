using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ghita_Vlad_Lab2.Models;

namespace Ghita_Vlad_Lab2.Data
{
    public class Ghita_Vlad_Lab2Context : DbContext
    {
        public Ghita_Vlad_Lab2Context (DbContextOptions<Ghita_Vlad_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Ghita_Vlad_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Ghita_Vlad_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    }
}
