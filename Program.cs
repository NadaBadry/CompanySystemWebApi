using SimpleCompany.Data;
using SimpleCompany.DataAccessLayer.Repository;
using SimpleCompany.DataAccessLayer.Repository.Contract;
using SimpleCompany.ServicesLayer;
using SimpleCompany.ServicesLayer.Contract;

namespace SimpleCompany
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.

			builder.Services.AddControllers();
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();
			//builder.Services.Configure<JWT>(con)
			builder.Services.AddDbContext<ApplicationDbContext>(options =>
			options.UseSqlServer(builder.Configuration.GetConnectionString("cs")));
			builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
			builder.Services.AddScoped<IDepartmentService, DepartmentServices>();
			builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
			builder.Services.AddScoped<IEmployeeService, EmployeeService>();
			builder.Services.AddScoped<IInsuranceCompanyRepository, InsuranceCompanyRepository>();
			builder.Services.AddScoped<IInsuranceCompanyService, InsuranceCompanyService>();
			builder.Services.AddScoped<IProjectRepository, ProjectRepository>();
			builder.Services.AddScoped<IProjectService, ProjectService>();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseAuthorization();


			app.MapControllers();

			app.Run();
		}
	}
}
