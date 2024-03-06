using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SchoolCleanArchitecture.Infrastructure.Contexts;
using SchoolCleanArchitecture.Infrastructure.Interfaces;
using SchoolCleanArchitecture.Infrastructure.Reposatories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCleanArchitecture.Infrastructure
{
    public static class InfrastructureRegistration
    {  
        public static IServiceCollection AddInfrastrucureServices(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services; 
        }
    }
}
