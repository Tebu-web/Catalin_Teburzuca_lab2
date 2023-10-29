using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Catalin_Teburzuca_lab2.Models;

namespace Catalin_Teburzuca_lab2.Data
{
    public class Catalin_Teburzuca_lab2Context : DbContext
    {
        public Catalin_Teburzuca_lab2Context (DbContextOptions<Catalin_Teburzuca_lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Catalin_Teburzuca_lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Catalin_Teburzuca_lab2.Models.Publisher>? Publisher { get; set; }
    }
}
