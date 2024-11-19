using AutoMapper;
using BeetleMovies.API.DTOs;
using BeetleMovies.API.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Tester1.DBContexts;

namespace BeetleMovies.API.EndpointHandler
{
    public static class DirectorsHandlers
    {

        public static async Task<Results<NotFound, Ok<IEnumerable<DirectorDTO>>>> GetDirectorsAsync(
                MovieContext context,
                IMapper mapper,
                int? moviesId)
                
        {
            var movie = await context.Movies.FirstOrDefaultAsync(x => x.Id == moviesId);
            if (movie == null)
                return TypedResults.NotFound();

            return TypedResults.Ok(mapper.Map<IEnumerable<DirectorDTO>>((await context.Movies
                .Include(movie => movie.Directors)
                .FirstOrDefaultAsync(movie => movie.Id == moviesId))?.Directors));
        }

}
}
