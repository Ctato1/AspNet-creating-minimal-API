using BeetleMovies.API.Extensions;
using Microsoft.EntityFrameworkCore;
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

            var app = builder.Build();

            app.RegisterMoviesEndpoints();
            app.RegisterDirectorsEndpoints();

            app.Run();
        }
    }
}
