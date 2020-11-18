using Microsoft.EntityFrameworkCore;
using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Data
{
    public class RestaurantContext : DbContext
    {
        public RestaurantContext(DbContextOptions<RestaurantContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                  new Product
                  {
                      ProductID = 1,
                      ProductName = "Blackcurrant ombré cheesecake",
                      Description = "This cheesecake tastes as good as it looks. The ombré effect makes a great centrepiece – your friends will never guess how easy it is to make!",
                      ImagePath = "c1.jpg",
                      UnitPrice = 3000,
                      CategoryID = 1
                  },
                  new Product
                  {
                      ProductID = 2,
                      ProductName = "My NYC cheesecake",
                      Description = "Perphaps is the most sweetest Cheese cake in new york! Loving it",
                      ImagePath = "c2.jpg",
                      UnitPrice = 2400,
                      CategoryID = 1
                  },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Frozen banoffee cheesecake",
                    Description = "Frozen banoffee cheesecake is sooo nice i would recommend you get one of these, you will exactly enjoy your dinner/lunch ",
                    ImagePath = "c3.jpg",
                    UnitPrice = 2700,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Black forest frozen cheesecake",
                    Description = "This is a great make-ahead dessert that will definitely impress your guests!",
                    ImagePath = "c4.jpg",
                    UnitPrice = 2500,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Frozen berries",
                    Description = "The best way to use frozen berries in any seaso" +
                    "Rick Stein's blueberry tart recipe, with ground almonds and egg custard is the perfect mix of comforting and refined. The tart is really stuffed with fruit with a very light binding of egg custard.",
                    ImagePath = "c7.jpg",
                    UnitPrice = 1400,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Dairy-free coconut cheesecake",
                    Description = "With a gorgeous nutty base, sweet coconut & vanilla topping and a strawberry drizzle, this is incredible!",
                    ImagePath = "c6.jpg",
                    UnitPrice = 3500,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "White Mountain Layer Cake with Marshmallow Buttercream",
                    Description = "Forget everything you know about 'white cake,' this recipe's a game changer: rich and velvety to the point of creaminess, heady with vanilla, and almost as fluffy as angel's food cake. The secret is virgin coconut oil, which amplifies the aroma of butter and vanilla while creaming up lighter (and whiter) than butter alone. I top it all off with silky Marshmallow Buttercream, for a cake that's beguilingly complex despite its apparent simplicity. Get the recipe for White Mountain Layer Cake with Marshmallow ButtercreamMatt Taylor-Gross",
                    ImagePath = "b1.jpg",
                    UnitPrice = 5000,
                    CategoryID = 2
                },
                 new Product
                 {
                     ProductID = 8,
                     ProductName = "New Orleans Doberge Cake",
                     Description = "This version of the classic NOLA dessert combines a rich buttermilk cake with both lemon curd and chocolate fillings, surrounded by a vanilla German buttercream and ganache",
                     ImagePath = "b2.jpg",
                     UnitPrice = 4700,
                     CategoryID = 2
                 },
                  new Product
                  {
                      ProductID = 9,
                      ProductName = "Chocolate Cake",
                      Description = "Chef Magnus Nilsson's wife likes to serve this beloved Swedish cake, similar to a fudgy American brownie, chilled, but it's just as good piping hot from the pan with a scoop of ice cream. Melting the butter in this recipe first and then stirring it with the other ingredients helps ensure that as little air as possible gets incorporated into the batter. The result: a gooey, more moist cake",
                      ImagePath = "b3.jpg",
                      UnitPrice = 2100,
                      CategoryID = 2
                  },
                 new Product
                 {
                     ProductID = 10,
                     ProductName = "Strawberry Lemon Cake",
                     Description = "At New York's Milk Bar, Christina Tosi makes this towering cake every spring, when sweet and tiny tristar strawberries are in season. This is by no means an everyday cake, but it's worth the work that you'll put in, and worthy of a special occasion",
                     ImagePath = "b4.jpg",
                     UnitPrice = 2500,
                     CategoryID = 2
                 },
                 new Product
                 {
                     ProductID = 11,
                     ProductName = "Lemon Curd Layer Cake",
                     Description = "Silken white chocolate buttercream frosts a tender yellow cake layered with rich lemon curd in this recipe from the restaurant",
                     ImagePath = "b5.jpg",
                     UnitPrice = 4600,
                     CategoryID = 2
                 },

                 new Product
                 {
                     ProductID = 12,
                     ProductName = "The Best Flourless Chocolate Cake",
                     Description = "The oldest and most popular dessert at San Francisco's legendary Zuni Café, this gluten-free chocolate cake boasts a fine, tender crumb and bold chocolate flavor",
                     ImagePath = "b9.jpg",
                     UnitPrice = 5600,
                     CategoryID = 2
                 },
                 new Product
                 {
                     ProductID = 13,
                     ProductName = "Whole Wheat Mille Crêpe Cake",
                     Description = "Layer nutty whole wheat crêpes with delicate honey whipped cream for a light but impressive dessert",
                     ImagePath = "b10.jpg",
                     UnitPrice = 4400,
                     CategoryID = 2
                 },
                 new Product
                 {
                     ProductID = 14,
                     ProductName = "Classic Smith Island Cake",
                     Description = "This impressive layer cake consists of 10 thin cake layers sandwiches with an old-fashioned chocolate fudge icing.",
                     ImagePath = "b11.jpg",
                     UnitPrice = 4000,
                     CategoryID = 2
                 }
                );

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Cheese Cake",
                    Description = "We sell nice sweet  cheese cakes here in our shop"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Birthday Cake",
                    Description = "We sell nice sweet  Birthday here in our shop, You are all welcome"
                }
              );
            base.OnModelCreating(modelBuilder);
        }
    }
}
