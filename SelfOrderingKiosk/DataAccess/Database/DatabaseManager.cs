using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Database
{
    public static class DatabaseManager
    {
        public static void InitializeDatabase()
        {
            using (var context = new SelfOrderingKioskDbContext())
            {
                if (!IsDatabaseInitialized(context))
                {
                    context.Products.AddRange(GetProductsList());
                    context.SaveChanges();
                }
            }
        }

        private static List<Product> GetProductsList()
        {
            Product product1 = new Product("Maestro Bacon & Cheddar", 21, ProductType.Burgers, "/Images/maestroBaconCheddar.jpg");
            Product product2 = new Product("Maestro Grilled Cheese", 20, ProductType.Burgers, "/Images/maestroGrilledCheese.png");
            Product product3 = new Product("Maestro Grand Classic", 19, ProductType.Burgers, "/Images/maestroClassic.jpg");
            Product product4 = new Product("Big Mac", 13, ProductType.Burgers, "/Images/bigmac.jpg");
            Product product5 = new Product("McRoyal ", 14, ProductType.Burgers, "/Images/mcroyal.jpg");
            Product product6 = new Product("McRoyal Double", 18, ProductType.Burgers, "/Images/mcroyalDouble.jpg");
            Product product7 = new Product("McRoyal Double Spicy", 19, ProductType.Burgers, "/Images/mcroyalDoubleSpicy.jpg");
            Product product8 = new Product("Wiesmak", 14, ProductType.Burgers, "/Images/wiesmac.jpg");
            Product product9 = new Product("Wiesmak Double", 18, ProductType.Burgers, "/Images/wiesmakDouble.jpg");
            Product product10 = new Product("McChicken", 13, ProductType.Burgers, "/Images/mcchicken.jpg");
            Product product11 = new Product("McDouble", 7, ProductType.Burgers, "/Images/mcdouble.jpg");
            Product product12 = new Product("Hamburger", 5, ProductType.Burgers, "/Images/hamburger.jpg");
            Product product13 = new Product("Cheeseburger", 5, ProductType.Burgers, "/Images/cheeseburger.jpg");
            Product product14 = new Product("Jalapenoburger", 5, ProductType.Burgers, "/Images/jalapenoburger.jpg");
            Product product15 = new Product("Chikker", 6, ProductType.Burgers, "/Images/chikker.jpg");
            Product product16 = new Product("Small fries", 6, ProductType.Fries, "/Images/fries.jpg");
            Product product17 = new Product("Medium fries", 7, ProductType.Fries, "/Images/fries.jpg");
            Product product18 = new Product("Large fries", 8, ProductType.Fries, "/Images/fries.jpg");
            Product product19 = new Product("Coca Cola", 6, ProductType.Drinks, "/Images/drink.jpg");
            Product product20 = new Product("Coca Cola Zero", 6, ProductType.Drinks, "/Images/drink.jpg");
            Product product21 = new Product("Sprite", 6, ProductType.Drinks, "/Images/drink.jpg");
            Product product22 = new Product("Fanta", 6, ProductType.Drinks, "/Images/drink.jpg");
            Product product23 = new Product("Lipton Ice Tea", 6, ProductType.Drinks, "/Images/drink.jpg");
            Product product24 = new Product("Water", 4, ProductType.Drinks, "/Images/water.jpg");
            Product product25 = new Product("Orange Juice", 6, ProductType.Drinks, "/Images/orangeJuice.jpg");
            Product product26 = new Product("Apple Juice", 6, ProductType.Drinks, "/Images/appleJuice.jpg");
            List<Product> list = new List<Product>
            {
                product1, product2, product3, product4, product5, product6, product7, product8, product9, product10, product11, product12, product13,
                product14, product15, product16, product17, product18, product19, product20, product21, product22, product23, product24, product25, product26
            };
            return list;
        }
        private static bool IsDatabaseInitialized(SelfOrderingKioskDbContext context)
        {
            var productsNumber = context.Products.Count();
            return !(productsNumber == 0);
        }
    }
}
