using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using SchoolCleanArchitecture.Infrastructure.Contexts;
using SchoolCleanArchitecture.Infrastructure;
using SchoolCleanArchitecture.Services;
using SchoolCleanArchitecture.Core; 
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using MediatR;
using System.Reflection;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using SchoolCleanArchitecture.Core.Features.Student.Requsts.Quaries;
using SchoolCleanArchitecture.Core.Features.Student.Handelrs.Quaries;
using SchoolCleanArchitecture.Services.Implementation;
using SchoolCleanArchitecture.Services.Interfaces;
using SchoolCleanArchitecture.Infrastructure.Interfaces;
using SchoolCleanArchitecture.Infrastructure.Reposatories;

namespace SchoolCleanArchitecture.Api
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
            builder.Services.AddInfrastrucureServices();
            builder.Services.AddServiceRegistration();
            builder.Services.AddCoreRegistrationServices();
            //builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
            var app = builder.Build();
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
