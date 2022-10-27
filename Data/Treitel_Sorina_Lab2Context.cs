using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Treitel_Sorina_Lab2.Models;

namespace Treitel_Sorina_Lab2.Data
{
    public class Treitel_Sorina_Lab2Context : DbContext
    {
        public Treitel_Sorina_Lab2Context (DbContextOptions<Treitel_Sorina_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Treitel_Sorina_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Treitel_Sorina_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Treitel_Sorina_Lab2.Models.Author> Author { get; set; }

        public DbSet<Treitel_Sorina_Lab2.Models.Category> Category { get; set; }

       
    }
}
