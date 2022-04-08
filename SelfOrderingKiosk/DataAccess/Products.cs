using DataAccess.Database;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class Products
    {
        public List<Product> ProductsList { get; set; } = GetProductsList();
        public static List<Product> GetProductsList()
        {
            using (var context = new SelfOrderingKioskDbContext())
            {
                var products = context.Products;
                return products.ToList();
            }
        }

        public List<Product> FriesList { get; set; } = GetFries();
        public static List<Product> GetFries()
        {
            return GetProductsList().Where(p => p.Type == ProductType.Fries).ToList();
        }

        public List<Product> DrinksList { get; set; } = GetDrinks();
        public static List<Product> GetDrinks()
        {
            return GetProductsList().Where(p => p.Type == ProductType.Drinks).ToList();
        }

        public List<Product> BurgersList { get; set; } = GetBurgers();
        public static List<Product> GetBurgers()
        {
            return GetProductsList().Where(p => p.Type == ProductType.Burgers).ToList();
        }

        public List<Product> OrderedProducts => GetOrderedProducts();

        public List<Product> GetOrderedProducts()
        {
            return CurrentOrder.Products;
        }
    }
}




