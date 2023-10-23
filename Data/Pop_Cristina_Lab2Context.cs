using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pop_Cristina_Lab2.Models;

namespace Pop_Cristina_Lab2.Data
{
    public class Pop_Cristina_Lab2Context : DbContext
    {
        public Pop_Cristina_Lab2Context (DbContextOptions<Pop_Cristina_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Pop_Cristina_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Pop_Cristina_Lab2.Models.Publisher>? Publisher { get; set; }
    }
}
