using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurant.Migrations
{
    public partial class SeedingDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName", "Description" },
                values: new object[] { 1, "Cheese Cake", "We sell nice sweet  cheese cakes here in our shop" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName", "Description" },
                values: new object[] { 2, "Birthday Cake", "We sell nice sweet  Birthday here in our shop, You are all welcome" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryID", "Description", "ImagePath", "ProductName", "UnitPrice" },
                values: new object[,]
                {
                    { 1, 1, "This cheesecake tastes as good as it looks. The ombré effect makes a great centrepiece – your friends will never guess how easy it is to make!", "c1.jpg", "Blackcurrant ombré cheesecake", 3000.0 },
                    { 2, 1, "Perphaps is the most sweetest Cheese cake in new york! Loving it", "c2.jpg", "My NYC cheesecake", 2400.0 },
                    { 3, 1, "Frozen banoffee cheesecake is sooo nice i would recommend you get one of these, you will exactly enjoy your dinner/lunch ", "c3.jpg", "Frozen banoffee cheesecake", 2700.0 },
                    { 4, 1, "This is a great make-ahead dessert that will definitely impress your guests!", "c4.jpg", "Black forest frozen cheesecake", 2500.0 },
                    { 5, 1, "The best way to use frozen berries in any seasoRick Stein's blueberry tart recipe, with ground almonds and egg custard is the perfect mix of comforting and refined. The tart is really stuffed with fruit with a very light binding of egg custard.", "c7.jpg", "Frozen berries", 1400.0 },
                    { 6, 1, "With a gorgeous nutty base, sweet coconut & vanilla topping and a strawberry drizzle, this is incredible!", "c6.jpg", "Dairy-free coconut cheesecake", 3500.0 },
                    { 7, 2, "Forget everything you know about 'white cake,' this recipe's a game changer: rich and velvety to the point of creaminess, heady with vanilla, and almost as fluffy as angel's food cake. The secret is virgin coconut oil, which amplifies the aroma of butter and vanilla while creaming up lighter (and whiter) than butter alone. I top it all off with silky Marshmallow Buttercream, for a cake that's beguilingly complex despite its apparent simplicity. Get the recipe for White Mountain Layer Cake with Marshmallow ButtercreamMatt Taylor-Gross", "b1.jpg", "White Mountain Layer Cake with Marshmallow Buttercream", 5000.0 },
                    { 8, 2, "This version of the classic NOLA dessert combines a rich buttermilk cake with both lemon curd and chocolate fillings, surrounded by a vanilla German buttercream and ganache", "b2.jpg", "New Orleans Doberge Cake", 4700.0 },
                    { 9, 2, "Chef Magnus Nilsson's wife likes to serve this beloved Swedish cake, similar to a fudgy American brownie, chilled, but it's just as good piping hot from the pan with a scoop of ice cream. Melting the butter in this recipe first and then stirring it with the other ingredients helps ensure that as little air as possible gets incorporated into the batter. The result: a gooey, more moist cake", "b3.jpg", "Chocolate Cake", 2100.0 },
                    { 10, 2, "At New York's Milk Bar, Christina Tosi makes this towering cake every spring, when sweet and tiny tristar strawberries are in season. This is by no means an everyday cake, but it's worth the work that you'll put in, and worthy of a special occasion", "b4.jpg", "Strawberry Lemon Cake", 2500.0 },
                    { 11, 2, "Silken white chocolate buttercream frosts a tender yellow cake layered with rich lemon curd in this recipe from the restaurant", "b5.jpg", "Lemon Curd Layer Cake", 4600.0 },
                    { 12, 2, "The oldest and most popular dessert at San Francisco's legendary Zuni Café, this gluten-free chocolate cake boasts a fine, tender crumb and bold chocolate flavor", "b9.jpg", "The Best Flourless Chocolate Cake", 5600.0 },
                    { 13, 2, "Layer nutty whole wheat crêpes with delicate honey whipped cream for a light but impressive dessert", "b10.jpg", "Whole Wheat Mille Crêpe Cake", 4400.0 },
                    { 14, 2, "This impressive layer cake consists of 10 thin cake layers sandwiches with an old-fashioned chocolate fudge icing.", "b11.jpg", "Classic Smith Island Cake", 4000.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 2);
        }
    }
}
