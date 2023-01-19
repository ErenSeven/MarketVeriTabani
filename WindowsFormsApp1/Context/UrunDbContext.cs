using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Context
{
    internal class UrunDbContext:DbContext
    {
        public DbSet<Urun> Uruns { get; set; }
        public DbSet<Musteri> Musteris { get; set; }
        public DbSet<Tedarikci> Tedarikcis { get; set; }
        public DbSet<Irsaliye> Irsaliyes { get; set; }
        public DbSet<Kullanici> Kullanicis { get; set; }
        public DbSet<Satis> Satis { get; set; }

    }
}
