namespace Restourant.Data.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;
    using Restaurant.Data;
    using Restaurant.Data.Enums;
    using Restaurant.Data.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<RestaurantDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(RestaurantDbContext context)
        {
            if (context.Ingredients.Any())
            {
                return;
            }

            Product[] products;
            Recipe[] recipes;
            Storage storage;

            storage = new Storage("Main")
            {
                Products = new List<Product>()
            };

            recipes = new[]
            {
                new Recipe("Spaghetti carbonara", 12.87m, TimeSpan.FromMinutes(10), TimeSpan.FromMinutes(10), string.Empty),
                new Recipe("Spaghetti bolonese", 10.87m, TimeSpan.FromMinutes(12), TimeSpan.FromMinutes(12), string.Empty)
            };

            products = new[]
            {
                new Product("Eggs yolks")
                {
                    MeasurementType = MeasurementType.None,
                    Price = 0.06m,
                    Allergens = new List<AllergenType>
                    {
                        AllergenType.Eggs
                    },
                    Amount = 3
                },
                new Product("Dried Spagetti ¹5")
                {
                    Amount = 3,
                    MeasurementType = MeasurementType.Gram,
                    Price = 3.99m,
                    Allergens = new List<AllergenType>()
                },
                new Product("Tomato souce")
                {
                    Amount = 4,
                    MeasurementType = MeasurementType.Kilogram,
                    Price = 23.99m,
                    Allergens = null
                }
            };

            storage.Products.Add(products[0]);
            storage.Products.Add(products[1]);
            storage.Products.Add(products[2]);

            context.Storages.Add(storage);
            context.SaveChanges();

            recipes[0].Ingredients = new List<Ingredient>
            {
                new Ingredient("Egg")
                {
                    Amount = 3,
                    MeasurementType = MeasurementType.None,
                    Price = 2.15m,
                    Allergens = new List<AllergenType>
                    {
                        AllergenType.Eggs
                    }
                },
                new Ingredient("Dried Spagetti ¹5")
                {
                    Amount = 500,
                    MeasurementType = MeasurementType.Gram,
                    Price = 2.99m
                }
            };

            recipes[1].Ingredients = new List<Ingredient>
            {
                new Ingredient("Dried Spagetti ¹5")
                {
                    Amount = 1,
                    MeasurementType = MeasurementType.Kilogram,
                    Price = 2.99m
                },
                new Ingredient("Tomato souce")
                {
                    Amount = 400,
                    MeasurementType = MeasurementType.Gram,
                    Price = 4.99m
                }
            };

            context.Recipes.Add(recipes[0]);
            context.Recipes.Add(recipes[1]);
            context.SaveChanges();
        }
    }
}
