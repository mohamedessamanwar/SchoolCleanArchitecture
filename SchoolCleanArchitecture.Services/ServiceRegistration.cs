using Microsoft.Extensions.DependencyInjection;
using SchoolCleanArchitecture.Infrastructure.Contexts;
using SchoolCleanArchitecture.Infrastructure.Interfaces;
using SchoolCleanArchitecture.Infrastructure.Reposatories;
using SchoolCleanArchitecture.Services.Implementation;
using SchoolCleanArchitecture.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCleanArchitecture.Services
{
    public static class ServiceRegistration
    {
       
            public static IServiceCollection AddServiceRegistration(this IServiceCollection services)
            {
            services.AddScoped<IStudentService, StudentService>();
           // services.AddScoped(typeof(IStudentService), typeof(StudentService));
            return services;
            }
        

    }
}
