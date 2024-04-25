using Microsoft.EntityFrameworkCore;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;
using System.IO;

namespace CarsAdviser.Database
{
    public class AppContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Users_bookmarks> Users_bookmarks { get; set; }
        public DbSet<Users_hidden_auto> Users_hidden_auto { get; set; }
        public DbSet<Users_preferences> Users_preferences { get; set; }
        public DbSet<Cars> Cars { get; set; }
        public DbSet<Cars_model> Cars_model { get; set; }
        public DbSet<Cars_stamp> Cars_stamp { get; set; }
        public DbSet<Cars_body> Cars_body{ get; set; }
        public DbSet<Cars_engine> Cars_engine { get; set; }
        public DbSet<Cars_fuel> Cars_fuel { get; set; }
        public DbSet<Cars_drive> Cars_drive { get; set; }
        public DbSet<Cars_checkpoint> Cars_checkpoint { get; set; }
        public DbSet<Cars_wheel> Cars_wheel { get; set; }
        public DbSet<Cars_colour> Cars_colour { get; set; }
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

            modelBuilder.Entity<Cars_model>()
            .HasOne(c => c.Cars_Stamp)
            .WithMany()
            .HasForeignKey(c => c.Cars_stamp);

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

            modelBuilder.Entity<Users_hidden_auto>()
                .HasOne(uha => uha.Cars)
                .WithMany()
                .HasForeignKey(uha => uha.Cars_id);

            modelBuilder.Entity<Users_preferences>()
            .HasOne(up => up.Users)
            .WithMany(u => u.UserPreferences)
            .HasForeignKey(up => up.Cars_id);

            modelBuilder.Entity<Users_preferences>()
            .HasOne(up => up.Cars)
            .WithMany()
            .HasForeignKey(up => up.Cars_id);

            base.OnModelCreating(modelBuilder);
        }
    }
}
