﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The RM",
                        ReleaseDate = DateTime.Parse("2003-1-31"),
                        Genre = "Comedy",
                        Price = 7.99M,
                        Rating = "PG",
                        ImagePath = "/images/rm.jpg",
                    },

                    new Movie
                    {
                        Title = "The Other Side of Heaven",
                        ReleaseDate = DateTime.Parse("2001-12-14"),
                        Genre = "Drama",
                        Price = 8.99M,
                        Rating = "PG",
                        ImagePath = "/images/other.jpg",
                    },

                    new Movie
                    {
                        Title = "Meet the Mormons",
                        ReleaseDate = DateTime.Parse("2014-10-14"),
                        Genre = "Documentary",
                        Price = 9.99M,
                        Rating = "PG",
                        ImagePath = "/images/meet.jpg",
                    }

                );
                context.SaveChanges();
            }
        }
    }
}