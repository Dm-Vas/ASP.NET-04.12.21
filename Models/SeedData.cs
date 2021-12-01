using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcCountry.Data;
using System;
using System.Linq;
namespace MvcCountry.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcCountryContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcCountryContext>>()))
            {

                if (context.Country.Any())
                {
                    return;   
                }
                context.Country.AddRange(
                    new Country
                    {
                        Name = "Poland",
                        CapitalCity = "Warsaw",
                        Language = "Polish",
                        Currency = "PLN"
                    },
                    new Country
                    {
                        Name = "USA",
                        CapitalCity = "Washington",
                        Language = "English",
                        Currency = "USD"
                    },
                    new Country
                    {
                        Name = "Japan",
                        CapitalCity = "Tokyo",
                        Language = "Japanese",
                        Currency = "JPY"
                    },
                    new Country
                    {
                        Name = "France",
                        CapitalCity = "Paris",
                        Language = "French",
                        Currency = "EUR"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}