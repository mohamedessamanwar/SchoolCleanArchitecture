using MediatR;
using Microsoft.Extensions.DependencyInjection;
using SchoolCleanArchitecture.Core.Features.Student.Handelrs.Quaries;
using SchoolCleanArchitecture.Core.Features.Student.Requsts.Quaries;
using SchoolCleanArchitecture.Domain.Enities;
using SchoolCleanArchitecture.Infrastructure.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace SchoolCleanArchitecture.Core
{
    public static class CoreRegistration
    {
        public static IServiceCollection AddCoreRegistrationServices(this IServiceCollection services)
        {
           // services.AddMediatR(typeof(GetStudentHandler).Assembly);
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            // services.AddMediatR(typeof(GetStudentRequst).Assembly); // Register all MediatR handlers in the specified assembly
             services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }
    }

    
}
