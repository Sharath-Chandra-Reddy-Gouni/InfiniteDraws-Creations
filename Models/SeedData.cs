using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using InfiniteDraws_Creations.Data;
using System;
using System.Linq;
namespace InfiniteDraws_Creations.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new InfiniteDraws_CreationsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<InfiniteDraws_CreationsContext>>()))
            {
                // Look for any movies.
                if (context.Drawer.Any())
                {
                    return;   // DB has been seeded
                }
                context.Drawer.AddRange(
                    new Drawer
                    {
                        Type = "Dresser With Draws",
                        DrawerMaterial = "Wood",
                        Color = "Brown",
                        Price = 150M,
                        Rating = "5",
                        Reviews= "Excellent Product"
                    },
                    new Drawer
                    {
                        Type = "Cabinet With Draws",
                        DrawerMaterial = "Plastic",
                        Color = "Blue",
                        Price = 90M,
                        Rating = "4",
                        Reviews = "Good Material"
                    },
                    new Drawer
                    {
                        Type = "Appliances Drawers",
                        DrawerMaterial = "Metal",
                        Color = "Black",
                        Price = 130M,
                        Rating = "4.5",
                        Reviews = "Nice Build"
                    },
                    new Drawer
                    {
                        Type = "Shoe Drawer",
                        DrawerMaterial = "Composite Material",
                        Color = "Grey",
                        Price = 50M,
                        Rating = "3.5",
                        Reviews = "Need to improve it's quality"
                    },
                    new Drawer
                    {
                        Type = "Junk Drawers",
                        DrawerMaterial = "Bamboo",
                        Color = "Blue",
                        Price = 40M,
                        Rating = "4",
                        Reviews = "Eco-Friendly Product"
                    }
                );
                context.SaveChanges();
            }
        }
    }

}
