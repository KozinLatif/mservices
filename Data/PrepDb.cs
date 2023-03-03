using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PlatformService.Models;

namespace PlatformService.Data
{
	public static class PrepDb
	{
		public static void PrepPopulation(IApplicationBuilder app)
		{
            using (var serviceScope = app.ApplicationServices.CreateScope())
			{
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }
		}

        private static void SeedData(AppDbContext context)
        {

            if (!context.Platforms.Any())
            {
                Console.WriteLine("--> Seeding data");

                context.Platforms.AddRange(
                    new Platform() { Name = "SQL", Publisher = "Microsoft", Cost = "Free" },
                    new Platform() { Name = "Java", Publisher = "Oracle", Cost = "Free" },
                    new Platform() { Name = "DOTNET", Publisher = "Microsoft", Cost = "Free" }
                );

                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("--> Already have data");
            }
        }
    }
}

