using AutoMapper;
using BeetleMovies.API.Entities;
using BeetleMovies.API.DTOs;

namespace BeetleMovies.API.Profiles
{
    public class BeetleMovieProfile : Profile
    {
        public BeetleMovieProfile()
        {
            CreateMap<Movie,MovieDTO>().ReverseMap();
            CreateMap<Director, DirectorDTO>()
                .ForMember(d => d.MovieId,
                o => o.MapFrom(d => d.Movies.First().Id));

        }
    }
}
