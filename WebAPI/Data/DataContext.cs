using Microsoft.EntityFrameworkCore;

namespace WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Skill>().HasData(
                new Skill {Id = 1, Name = "Mulyadi", Damage = 30},
                new Skill {Id = 2, Name = "Mulyono", Damage = 10},
                new Skill {Id = 3, Name = "Sukirno", Damage = 50}
            );
        }
        public DbSet<Characters> Characters { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<Skill> Skill { get; set; }


    }
}
