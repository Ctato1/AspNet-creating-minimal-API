
namespace BeetleMovies.API.EndpointFilter
{
    public class PerfectMoviesAreLockedFilter : IEndpointFilter
    {
        public readonly int _lockedPerfectMoviesId;
        public PerfectMoviesAreLockedFilter(int lockedPerfectMoviesId )
        {
            _lockedPerfectMoviesId = lockedPerfectMoviesId;
        }

        public async ValueTask<object?> InvokeAsync(EndpointFilterInvocationContext context, EndpointFilterDelegate next)
        {
            int moviesId;

            if (context.HttpContext.Request.Method == "PUT")
            {
                moviesId = context.GetArgument<int>(2);
            }
            else if (context.HttpContext.Request.Method == "DELETE")
            {
                moviesId = context.GetArgument<int>(1);
            }
            else
            {
                throw new NotSupportedException();
            }

            var perfectMoviesId = _lockedPerfectMoviesId;

            if (moviesId == perfectMoviesId)
            {
                return TypedResults.Problem(new()
                {
                    Status = 400,
                    Title = "You can not change or delete this movie",
                    Detail = $"This movie is good to {context.HttpContext.Request.Method}",
                });
            }


            var result = await next.Invoke(context);
            return result;
        }
    }
}
