using Microsoft.EntityFrameworkCore;
using Views_And_Procedures_STEP.Entities;
using Views_And_Procedures_STEP.Entities.Views_And_Procedures;

namespace Views_And_Procedures_STEP
{
    public class AppDbContext : DbContext
    {
        public DbSet<Employees> Employees { get; set; } = null!;
        public DbSet<Department> Departments { get; set; } = null!;
        public DbSet<ActiveEmployeeView> ActiveEmployees { get; set; }
        public DbSet<EmployeeResult> EmployeeResults { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=DepartEmp;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employees>().HasOne(e => e.Department)
                                            .WithMany(d => d.Employees)
                                            .HasForeignKey(e => e.DepartmentId)
                                            .OnDelete(DeleteBehavior.Cascade);
            
            
            modelBuilder.Entity<Employees>()
                .ToTable(t =>
                {
                    t.HasCheckConstraint("CK_Employees_Salary", "Salary > 0");
                });


            modelBuilder.Entity<Department>().HasIndex(d => d.Name)
                                             .IsUnique();

            modelBuilder.Entity<ActiveEmployeeView>()
                                             .HasNoKey()
                                             .ToView("ShowActive");

            modelBuilder.Entity<EmployeeResult>()
                                             .HasNoKey()
                                             .ToView(null);
        }
    }
}
