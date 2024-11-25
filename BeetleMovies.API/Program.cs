using BeetleMovies.API.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
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

            builder.Services.AddIdentityApiEndpoints<IdentityUser>()
                .AddEntityFrameworkStores<MovieContext>();

            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            builder.Services.AddProblemDetails();


            builder.Services.AddAuthentication().AddJwtBearer();
            builder.Services.AddAuthorization();

            builder.Services.AddAuthorizationBuilder()
                .AddPolicy("RequireAdminFromBrazil", policy => policy
                .RequireRole("admin")
                .RequireClaim("country", "Brazil"));

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(options =>
            {
                options.AddSecurityDefinition("TakenAuthMovies",
                    new()
                    {
                        Name = "Authorization",
                        Description = "Token based on Authorization and Authentication",
                        Type = SecuritySchemeType.Http,
                        Scheme = "Bearer",
                        In = ParameterLocation.Header,
                    }
                 );
                options.AddSecurityRequirement(new()
                {
                    {
                        new()
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "TakenAuthMovies"
                            }
                        }, new List<string>()
                    }
                });
            });

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {

                app.UseExceptionHandler();
            }
            else
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();


            // WebApplication does this automatically (UseAuthentication & UseAuthorization)
            /* app.UseAuthentication();
               app.UseAuthorization();*/


            app.RegisterMoviesEndpoints();
            app.RegisterDirectorsEndpoints();

            app.Run();
        }
    }
}
