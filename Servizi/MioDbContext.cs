using Microsoft.EntityFrameworkCore;
using Scacchi.Modello;

namespace Scacchi.Servizi{
    public class MioDbContext : DbContext {
        public DbSet<Mossa> mosse {get; private set;}
        protected override void OnConfiguring(DbContextOptionsBuilder builder){
            builder.UseSqlite(@"Data Source=../../../Database.db");
        }
        protected override void OnModelCreating(ModelBuilder builder){
            builder.Entity<Mossa>().ToTable("Mosse").HasKey(m=>m.Id);
        }
        public MioDbContext() : base(){
            this.Database.EnsureCreated();
        }
    }
}