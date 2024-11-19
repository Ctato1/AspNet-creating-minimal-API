using BeetleMovies.API.Extensions;
using Microsoft.EntityFrameworkCore;
using System.Net;
using Tester1.DBContexts;

namespace BeetleMovies.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<MovieContext>(
                 o => o.UseSqlite(builder.Configuration["ConnectionStrings:BeetleMovieStr"])
             );

            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            builder.Services.AddProblemDetails();

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {

                app.UseExceptionHandler();
                /*app.UseExceptionHandler(configureApplicationBuilder =>
                {
                    configureApplicationBuilder.Run(async context =>
                    {
                        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                        context.Response.ContentType = "text/html";
                        await context.Response.WriteAsync("An unexpected problem happened.");
                    });
                });*/
            }


            app.RegisterMoviesEndpoints();
            app.RegisterDirectorsEndpoints();

            app.Run();
        }
    }
}
