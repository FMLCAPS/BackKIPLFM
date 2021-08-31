using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIPLModel
{
    public class Bdd :  DbContext
    {
        public DbSet<Cabinet> Cabinets { get; set; } // génèrera une table Cabinets dans notre base de données
        public DbSet<Kine> Kines { get; set; }

        public Bdd()
        {

        }

        public Bdd(DbContextOptions<Bdd> options) : base (options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=localhost;Initial Catalog=Kipl_Cabinet_Fm;User ID=Ef_login;Password=azerty;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Les PK
            modelBuilder.Entity<Cabinet>().HasKey(c => c.Id);
            modelBuilder.Entity<Kine>().HasKey(k => k.Id);
            // Les FK
            modelBuilder.Entity<Kine>().HasOne(k => k.Cabinet).WithMany(c => c.Kines).HasForeignKey(k => k.CabinetId);
        }
    }
}
