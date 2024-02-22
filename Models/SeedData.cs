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
                        Rating = 5,
                        Reviews= "Excellent Product"
                    },
                    new Drawer
                    {
                        Type = "Cabinet With Draws",
                        DrawerMaterial = "Plastic",
                        Color = "Blue",
                        Price = 90M,
                        Rating = 4,
                        Reviews = "Good Material"
                    },
                    new Drawer
                    {
                        Type = "Appliances Drawers",
                        DrawerMaterial = "Metal",
                        Color = "Black",
                        Price = 130M,
                        Rating = 3,
                        Reviews = "Nice Build"
                    },
                    new Drawer
                    {
                        Type = "Shoe Drawer",
                        DrawerMaterial = "Composite Material",
                        Color = "Grey",
                        Price = 50M,
                        Rating = 5,
                        Reviews = "Need to improve it's quality"
                    },
                    new Drawer
                    {
                        Type = "Junk Drawers",
                        DrawerMaterial = "Bamboo",
                        Color = "Blue",
                        Price = 40M,
                        Rating = 4,
                        Reviews = "Eco-Friendly Product"
                    },
                    new Drawer
                    {
                        Type = "Pocker Drawers",
                        DrawerMaterial = "Fabric",
                        Color = "White",
                        Price = 30M,
                        Rating = 4,
                        Reviews = "Quality is good"
                    },
                    new Drawer
                    {
                        Type = "Rolling Drawers",
                        DrawerMaterial = "Wood",
                        Color = "Green",
                        Price = 80M,
                        Rating = 5,
                        Reviews = "Easy mobility"
                    },
                    new Drawer
                    {
                        Type = "Kitchen Drawers",
                        DrawerMaterial = "Plywood",
                        Color = "Red",
                        Price = 60M,
                        Rating = 4,
                        Reviews = "Durable product"
                    },
                    new Drawer
                    {
                        Type = "Secret Drawers",
                        DrawerMaterial = "Steel",
                        Color = "Black",
                        Price = 140M,
                        Rating = 5,
                        Reviews = "Easy to fit"
                    },
                    new Drawer
                    {
                        Type = "Dish Drawers",
                        DrawerMaterial = "Composite Material",
                        Color = "Silver",
                        Price = 90M,
                        Rating = 4,
                        Reviews = "Strong build"
                    }
                );
                context.SaveChanges();
            }
        }
    }

}
