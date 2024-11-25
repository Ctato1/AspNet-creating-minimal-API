using BeetleMovies.API.EndpointFilter;
using BeetleMovies.API.EndpointHandler;
using Microsoft.AspNetCore.Identity;
namespace BeetleMovies.API.Extensions
{
    public static class EndpointRouteBuilderExtensions
    {

        public static void RegisterMoviesEndpoints(this IEndpointRouteBuilder endpointRouteBuilder)
        {

            endpointRouteBuilder.MapGroup("/identity/").MapIdentityApi<IdentityUser>();

            endpointRouteBuilder.MapGet("/GetMovies/{movieId:int}", (int movieId) => $"this movie id is {movieId}")
                .WithOpenApi((operation) =>
                {
                    operation.Deprecated = true;
                    return operation;
                }).WithSummary("Use ( /movies/moviesId )");

            var moviesGroup = endpointRouteBuilder.MapGroup("/movies")
                .RequireAuthorization();
            var moviesGroupWithId = moviesGroup.MapGroup("/{moviesId:int}");
            var moviesGroupWithIdFilter = endpointRouteBuilder.MapGroup("/movies/{moviesId:int}")
                .RequireAuthorization()
                .AddEndpointFilter(new PerfectMoviesAreLockedFilter(2))
                .AddEndpointFilter(new PerfectMoviesAreLockedFilter(5));


            moviesGroupWithId.MapGet("", MoviesHandlers.GetMoviesById).WithName("GetMovies")
                .RequireAuthorization("RequireAdminFromBrazil")
                .WithOpenApi();
            //with header (changed name)
            moviesGroup.MapGet("", MoviesHandlers.GetMoviesAsync);

            moviesGroup.MapPost("", MoviesHandlers.CreateMoviesAsync)
                .AddEndpointFilter<ValidateAnnotationFilter>();

            moviesGroupWithIdFilter.MapPut("", MoviesHandlers.UpdateMoviesAsync);

            moviesGroupWithIdFilter.MapDelete("", MoviesHandlers.DeleteMoviesAsync)
                .AddEndpointFilter<LogNotFoundResponseFilter>();

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
        }

        public static void RegisterDirectorsEndpoints(this IEndpointRouteBuilder endpointRouteBuilder)
        {

            var moviesGroupWithDirectors = endpointRouteBuilder.MapGroup("/movies/{moviesId:int}/directors")
                .RequireAuthorization();
            moviesGroupWithDirectors.MapGet("", DirectorsHandlers.GetDirectorsAsync);
            moviesGroupWithDirectors.MapPost("", () =>
            {
                throw new NotImplementedException();
            });
        }

    }
}
