using AutoMapper;
using BeetleMovies.API.DTOs;
using BeetleMovies.API.EndpointHandler;
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

            app.Run();
        }
    }
}
