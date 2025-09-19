using Application.Interfaces;
using Application.Services;
using Data.Context;
using Data.Repositories;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<ApplicationDbContext>(option => option.UseSqlServer(configuration.GetConnectionString("DefaultConnection")
                , b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            services.AddScoped<IPolicialRepository, PolicialRepository>();
            services.AddScoped<IPolicialService, PolicialService>();
            services.AddScoped<IOpmRepository, OpmRepository>();
            services.AddScoped<IOpmService, OpmService>();
            services.AddScoped<IMedalhaRepository, MedalhaRepository>();
            services.AddScoped<IMedalhaService, MedalhasService>();


            return services;
        }
    }
}
