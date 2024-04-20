using Microsoft.EntityFrameworkCore;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;
using System.IO;

namespace CarsAdviser.Database
{
    internal class AppContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Users_bookmarks> UsersBookmarks { get; set; }
        public DbSet<Users_hidden_auto> UsersHiddenAuto { get; set; }
        public DbSet<Cars> Cars { get; set; }
        public DbSet<Cars_model> CarsModels { get; set; }
        public DbSet<Cars_stamp> CarsStamps { get; set; }
        public DbSet<Cars_body> CarsBodies { get; set; }
        public DbSet<Cars_engine> CarsEngines { get; set; }
        public DbSet<Cars_fuel> CarsFuels { get; set; }
        public DbSet<Cars_drive> CarsDrives { get; set; }
        public DbSet<Cars_checkpoint> CarsCheckpoints { get; set; }
        public DbSet<Cars_wheel> CarsWheels { get; set; }
        public DbSet<Cars_colour> CarsColours { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string dbPath = Path.Combine(path, "../../Database/CarAdviser.db");

            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cars>()
            .HasOne(c => c.Cars_Model)
            .WithMany()
            .HasForeignKey(c => c.Cars_model);

            modelBuilder.Entity<Cars>()
                .HasOne(c => c.Cars_Stamp)
                .WithMany()
                .HasForeignKey(c => c.Cars_stamp);

            modelBuilder.Entity<Cars>()
                .HasOne(c => c.Cars_Body)
                .WithMany()
                .HasForeignKey(c => c.Cars_body);

            modelBuilder.Entity<Cars>()
                .HasOne(c => c.Cars_Engine)
                .WithMany()
                .HasForeignKey(c => c.Cars_engine);

            modelBuilder.Entity<Cars>()
                .HasOne(c => c.Cars_Fuel)
                .WithMany()
                .HasForeignKey(c => c.Cars_fuel);

            modelBuilder.Entity<Cars>()
                .HasOne(c => c.Cars_Drive)
                .WithMany()
                .HasForeignKey(c => c.Cars_drive);

            modelBuilder.Entity<Cars>()
                .HasOne(c => c.Cars_Checkpoint)
                .WithMany()
                .HasForeignKey(c => c.Cars_checkpoint);

            modelBuilder.Entity<Cars>()
                .HasOne(c => c.Cars_Wheel)
                .WithMany()
                .HasForeignKey(c => c.Cars_wheel);

            modelBuilder.Entity<Cars>()
                .HasOne(c => c.Cars_Colour)
                .WithMany()
                .HasForeignKey(c => c.Cars_colour);

            modelBuilder.Entity<Cars_stamp>()
            .HasOne(c => c.Cars_Model)
            .WithMany()
            .HasForeignKey(c => c.Cars_model);

            modelBuilder.Entity<Users_bookmarks>()
            .HasOne(ub => ub.Users)
            .WithMany(u => u.UserBookmarks)
            .HasForeignKey(ub => ub.Users_id);

            modelBuilder.Entity<Users_bookmarks>()
                .HasOne(ub => ub.Cars)
                .WithMany()
                .HasForeignKey(ub => ub.Cars_id);

            modelBuilder.Entity<Users_hidden_auto>()
            .HasOne(uha => uha.Users)
            .WithMany(u => u.UserHiddenAutos)
            .HasForeignKey(uha => uha.Users_id);
        }
    }
}
