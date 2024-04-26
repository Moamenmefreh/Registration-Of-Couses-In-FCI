using Microsoft.EntityFrameworkCore;
using Registration.Models;

namespace Registration.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options)
            :base(options) { }
        public DbSet<Students>? student { get; set; } 
        public DbSet<Semster>? Semster { get; set; } 
        public DbSet<Semster1>? Semster1 { get; set; }
        public DbSet<Semster2>? Semster2 { get; set; }
        public DbSet<Semster3>? Semster3 { get; set; }
        public DbSet<Semster4>? Semster4 { get; set; }
        public DbSet<Semster5>? Semster5 { get; set; }
        public DbSet<Semster6>? Semster6 { get; set; }
        public DbSet<Semster7>? Semster7 { get; set; } = null;
        public DbSet<Semster8>? Semster8 { get; set; }

        public DbSet<Levels>? Levels { get; set; } 
        public DbSet<Level1>? Level1 { get; set; } 
        public DbSet<Level2>? Level2 { get; set; } 
        public DbSet<Level3>? Level3 { get; set; } 
        public DbSet<Level4>? Level4 { get; set; } 

        public DbSet<Admins>? Admins { get; set; } 
        public DbSet<Courses>? Courses { get; set; } 

        public DbSet<Department>? Departments { get; set; }
        public DbSet<PreRequistes>? PreRequistes { get; set; }
        public DbSet<RegistrationStudent>? RegistrationStudent { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            //var connstring = configuration.GetSection("DefualtString").Value;

            //optionsBuilder.UseSqlServer(connstring);


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }

    }
}
