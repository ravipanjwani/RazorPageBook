using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesBook.Models;
using System;
using System.Linq;

namespace RazorPagesBook.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesBookContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesBookContext>>()))
            {
                // Look for any Books.
                if (context.Book.Any())
                {
                    return;   // DB has been seeded
                }

                context.Book.AddRange(
                    new Book
                    {
                        Title = "Rich Dad Poor Dad",
                        Author = "Robert T. Kiyosaki",
                        Language = "EN",
                        Price = 8.97M
                    },

                    new Book
                    {
                        Title = "How To Make Money In Stocks",
                        Author = "Fred Green",
                        Language = "EN",
                        Price = 13.06M
                    },

                    new Book
                    {
                        Title = "The Secrets of Value Investing You Need to Know",
                        Author = "JD Rams",
                        Language = "EN",
                        Price = 9.99M
                    },

                    new Book
                    {
                        Title = "Le Petit Prince",
                        Author = "Antoine de Saint",
                        Language = "FR",
                        Price = 11.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}