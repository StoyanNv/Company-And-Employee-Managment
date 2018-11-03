namespace CompanyAndEmployeeManagment.Data
{
    using Models;
    using Microsoft.EntityFrameworkCore;

    public class CompanyAndEmployeeManagmentContext : DbContext
    {
        private DbContextOptions<CompanyAndEmployeeManagmentContext> options;

        public CompanyAndEmployeeManagmentContext(DbContextOptions<CompanyAndEmployeeManagmentContext> dbContextOptions)
        {
        }

        public DbSet<Company> Companies { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Level> Levels { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(SqlServerConstants.ConnectionString);
            }

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Level>()
                .HasIndex(c => c.ExperienceLevel)
                .IsUnique(); ;
        }
    }
}
