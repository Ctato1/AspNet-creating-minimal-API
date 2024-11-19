using BeetleMovies.API.EndpointHandler;

namespace BeetleMovies.API.Extensions
{
    public static class EndpointRouteBuilderExtensions
    {

        public static void RegisterMoviesEndpoints(this IEndpointRouteBuilder endpointRouteBuilder)
        {
            var moviesGroup = endpointRouteBuilder.MapGroup("/movies");
            var moviesGroupWithId = moviesGroup.MapGroup("/{moviesId:int}");
            moviesGroupWithId.MapGet("", MoviesHandlers.GetMoviesById).WithName("GetMovies");
            //with header (changed name)
            moviesGroup.MapGet("", MoviesHandlers.GetMoviesAsync);

            moviesGroup.MapPost("", MoviesHandlers.CreateMoviesAsync);

            moviesGroupWithId.MapPut("", MoviesHandlers.UpdateMoviesAsync);

            moviesGroupWithId.MapDelete("", MoviesHandlers.DeleteMoviesAsync);

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

            var moviesGroupWithDirectors = endpointRouteBuilder.MapGroup("/movies/{moviesId:int}/directors");
            moviesGroupWithDirectors.MapGet("", DirectorsHandlers.GetDirectorsAsync);
            moviesGroupWithDirectors.MapPost("", () =>
            {
                throw new NotImplementedException();
            });
        }

    }
}
