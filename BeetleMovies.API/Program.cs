using AutoMapper;
using BeetleMovies.API.DTOs;
using BeetleMovies.API.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tester1.DBContexts;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

            app.MapGet("/", () => "Hello World!");

            app.MapGet("/movies/{number:int}", async Task<Results<NoContent, Ok<List<Movie>>>> (MovieContext context, int? number) =>
            {
                var movieEntity = await context.Movies.Where(x => x.Id == number).ToListAsync();
                if (movieEntity == null || movieEntity.Count <= 0)
                {
                    return TypedResults.NoContent();
                }
                return TypedResults.Ok(movieEntity);
            });

            app.MapGet("/movies/{movieId:int}/directors", async (
                MovieContext context,
                IMapper mapper,
                int movieId)
                =>
            {
                return mapper.Map<IEnumerable<DirectorDTO>>((await context.Movies
                    .Include(movie => movie.Directors)
                    .FirstOrDefaultAsync(movie => movie.Id == movieId))?.Directors);
            });


            //with header (changed name)
            app.MapGet("/movies", async Task<Results<NoContent,Ok<List<Movie>>>> (MovieContext context,
                [FromHeader(Name = "X-MOVIE-TITLE")] string? title)
                => {
                var movieEntity = await context.Movies.Where(x => title == null || x.Title.ToLower().Contains(title.ToLower())).ToListAsync();

                    if (movieEntity.Count <= 0 || movieEntity == null)
                    {
                        return TypedResults.NoContent();
                    }
                    else
                    {
                        return TypedResults.Ok(movieEntity);
                    }
            });

            //with header
            /* app.MapGet("/movie", (MovieContext context, [FromHeader]string title) => {
                return context.Movies.FirstOrDefault(x => x.Title == title);
            });*/

            // movie?title=solution
            /*app.MapGet("/movie", (MovieContext context, [FromQuery]string title) => {
                return context.Movies.FirstOrDefault(x => x.Title == title);
            });*/

            // async 
            /*app.MapGet("/movies", async (MovieContext context) => {
                return await context.Movies.ToListAsync();
            });*/
            app.Run();
        }
    }
}
