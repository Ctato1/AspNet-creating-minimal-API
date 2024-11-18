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

            var moviesGroup = app.MapGroup("/movies");
            var moviesGroupWithId = moviesGroup.MapGroup("/{moviesId:int}");
            var moviesGroupWithDirectors = moviesGroupWithId.MapGroup("/directors");

            moviesGroupWithId.MapGet("", async (MovieContext context,IMapper mapper, int? moviesId) =>
            {
                return  mapper.Map<MovieDTO>(await context.Movies.FirstOrDefaultAsync(x => x.Id == moviesId));
            }).WithName("GetMovies");

            moviesGroupWithDirectors.MapGet("", async (
                MovieContext context,
                IMapper mapper,
                int? moviesId)
                =>
            {
                return mapper.Map<IEnumerable<DirectorDTO>>((await context.Movies
                    .Include(movie => movie.Directors)
                    .FirstOrDefaultAsync(movie => movie.Id == moviesId))?.Directors);
            });


            //with header (changed name)
            moviesGroup.MapGet("", async Task<Results<NoContent,Ok<IEnumerable<MovieDTO>>>> (MovieContext context,
                IMapper mapper,
                [FromHeader(Name = "X-MOVIE-TITLE")] string? title)
                => {
                var movieEntity = await context.Movies.Where(x => title == null || x.Title.ToLower().Contains(title.ToLower())).ToListAsync();
                    
                if (movieEntity.Count <= 0 || movieEntity == null)
                {
                   return TypedResults.NoContent();
                }
                else
                {
                   return TypedResults.Ok(mapper.Map<IEnumerable<MovieDTO>>(movieEntity));
                }
            });

            moviesGroup.MapPost("", async (
                MovieContext context,
                IMapper mapper,
                [FromBody] MovieForCreatingDTO movieForCreatingDTO
                ) =>
                {
                    var movie = mapper.Map<Movie>(movieForCreatingDTO);
                    context.Add(movie);

                    await context.SaveChangesAsync();

                    var movieToReturn = mapper.Map<MovieDTO>(movie);

                    return TypedResults.CreatedAtRoute(movieToReturn, "GetMovies", new { moviesId = movieToReturn.Id });
                }

            );

            moviesGroupWithId.MapPut("", async Task<Results<NotFound, Ok>> (
                 MovieContext context,
                 IMapper mapper,
                 int? moviesId,
                 [FromBody] MovieForUpdatingDTO movieForUpdatingDTO
                 ) =>{

                     var movie = await context.Movies.FirstOrDefaultAsync(x => x.Id == moviesId);
                     if ( movie == null )
                         return TypedResults.NotFound();

                     mapper.Map(movieForUpdatingDTO, movie);

                     await context.SaveChangesAsync();

                     return TypedResults.Ok();
            });

            moviesGroupWithId.MapDelete("", async Task<Results<NotFound, NoContent>> (
                MovieContext context,
                int? moviesId
                ) => {

                    var movie = await context.Movies.FirstOrDefaultAsync(x => x.Id == moviesId);
                    if (movie == null)
                        return TypedResults.NotFound();

                    context.Movies.Remove(movie);

                    await context.SaveChangesAsync();

                    return TypedResults.NoContent();
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
