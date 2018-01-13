using CakeShop.Core.Models;
using System.Collections.Generic;
using System.Linq;

namespace CakeShop.Models
{
    public static class DbInitializer
    {
        public static void SeedDatabase(CakeShopDbContext context)
        {
            System.Console.WriteLine("Seeding... - Start");

            var categories = new List<Category>
            {
                new Category { Name = "Vanilla Cakes",  Description = "Colorful & Testy"  },
                new Category { Name = "Chocolate Cakes", Description =  "Yaamy! & Chocolatey" },
                new Category { Name = "Fruit Cakes",  Description = "All Fruity cakes" }
            };

            var cakes = new List<Cake>
            {
                new Cake
                {
                    Name ="Strawberry Cake",
                    Price = 48.00M,
                    ShortDescription ="Yammy Sweet & Testy",
                    LongDescription ="Icing carrot cake jelly-o cheesecake. tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake.dragée gummies.",
                    Category = categories[0],
                    ImageUrl ="/img/vanilla-cake2.jpg",
                    InStock = true,
                    IsCakeOfTheWeek = true,
                    ImageThumbnailUrl ="/img/vanilla-cake2.jpg"
                },
                new Cake
                {
                    Name ="Dark Chocolate Cake",
                    Price =45.50M,
                    ShortDescription ="Yammy! Dark Chocolate Flavour",
                    LongDescription ="Icing carrot cake jelly-o cheesecake. tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake.dragée gummies.",
                    Category = categories[1],
                    ImageUrl ="/img/chocolate-cake4.jpg",
                    InStock = true,
                    IsCakeOfTheWeek = false,
                    ImageThumbnailUrl ="/img/chocolate-cake4.jpg"
                },
                new Cake
                {
                    Name ="Special Chocolate Cake",
                    Price = 40.50M,
                    ShortDescription ="Taste Our Special Chocolates",
                    LongDescription ="Icing carrot cake jelly-o cheesecake. tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake.dragée gummies.",
                    Category = categories[1],
                    ImageUrl ="/img/chocolate-cake3.jpg",
                    InStock = true,
                    IsCakeOfTheWeek = true,
                    ImageThumbnailUrl ="/img/chocolate-cake3.jpg"
                },
                new Cake
                {
                    Name ="Red Velvet Cake",
                    Price=35.00M,
                    ShortDescription ="Lorem Ipsum",
                    LongDescription ="Icing carrot cake jelly-o cheesecake. tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake.dragée gummies.",
                    Category = categories[0],
                    ImageUrl ="/img/vanilla-cake4.jpg",
                    InStock =true,
                    IsCakeOfTheWeek = true,
                    ImageThumbnailUrl ="/img/vanilla-cake4.jpg"
                },
                new Cake
                {
                    Name ="Mixed Fruit Cake",
                    Price = 30.50M,
                    ShortDescription ="Fruity & Testy",
                    LongDescription ="Icing carrot cake jelly-o cheesecake. tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake.caramels.",
                    Category = categories[2],
                    ImageUrl ="/img/fruit-cake.jpg",
                    InStock =true,
                    IsCakeOfTheWeek =true,
                    ImageThumbnailUrl ="/img/fruit-cake.jpg"
                }

            };

            if (!context.Categories.Any() && !context.Cakes.Any())
            {
                context.Categories.AddRange(categories);
                context.Cakes.AddRange(cakes);
                context.SaveChanges();
            }

            System.Console.WriteLine("Seeding... - End");

        }

    }
}