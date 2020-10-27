using CleanArch.Appplication.Interfaces;
using CleanArch.Appplication.Services;
using CleanArch.Domain.Interfaces;
using CleanArch.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Aplication layer
            services.AddScoped<ICourseService, CourseService>();
            //Infra.Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
