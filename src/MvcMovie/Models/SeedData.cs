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
            var context = serviceProvider.GetService<ApplicationDbContext>();

            if (context.Database == null)
            {
                throw new Exception("DB is null");
            }

            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }

            context.Movie.AddRange(
             new Movie
             {
                 Title = "The Other Side of Heaven",
                 ReleaseDate = DateTime.Parse("2001-12-14"),
                 Genre = "Drama",
                 Rating = "PG",
                 Price = 7.99M
                 
             },

                 new Movie
                 {
                     Title = "The Singles Ward",
                     ReleaseDate = DateTime.Parse("2002-1-31"),
                     Genre = "Comedy",
                     Rating = "PG",
                     Price = 8.99M
                 },

                 new Movie
                 {
                     Title = "The Best Two Years",
                     ReleaseDate = DateTime.Parse("2003-2-15"),
                     Genre = "Comedy",
                     Rating = "PG",
                     Price = 9.99M
                 },

               new Movie
               {
                   Title = "Once I was a Beehive",
                   ReleaseDate = DateTime.Parse("2015-11-15"),
                   Genre = "Feel Good",
                   Rating = "G",
                   Price = 3.99M
               }
            );
            context.SaveChanges();
        }
    }
}