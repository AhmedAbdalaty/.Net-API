using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Repos.Repo;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AhmedMahmoudCompany
{
    public static class AddedServices
    {
        public static void RegisterOtherServices(this IServiceCollection services)
        {
            services.AddScoped<DepartmentRepo>();
            services.AddScoped<EmployeeRepo>();
            services.AddScoped<ProjectRepo>();
            services.AddScoped<Works_onRepo>();
            services.AddControllers().AddNewtonsoftJson(i => i.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);
        }
    }
}