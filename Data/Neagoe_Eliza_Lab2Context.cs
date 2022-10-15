using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Neagoe_Eliza_Lab2.Models;

namespace Neagoe_Eliza_Lab2.Data
{
    public class Neagoe_Eliza_Lab2Context : DbContext
    {
        public Neagoe_Eliza_Lab2Context (DbContextOptions<Neagoe_Eliza_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Neagoe_Eliza_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Neagoe_Eliza_Lab2.Models.Category> Category { get; set; }

        public DbSet<Neagoe_Eliza_Lab2.Models.BookCategory> BookCategory { get; set; }

        public DbSet<Neagoe_Eliza_Lab2.Models.Publisher> Publisher { get; set; }
    }
}
