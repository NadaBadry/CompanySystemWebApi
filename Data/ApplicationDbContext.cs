using SimpleCompany.DataAccessLayer.Model;

namespace SimpleCompany.Data
{
	public class ApplicationDbContext:DbContext
	{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options) { }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<InsuranceCompany>InsuranceCompanies { get; set; }

    }
}
