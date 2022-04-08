using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public static class CurrentOrder
    {
        public static List<Product> Products = new List<Product>();
        public static int NumberOfItems = 0;
        public static PaymentType PaymentType;
        public static decimal TotalAmount => Products.Sum(p => p.Price);

        public static void AddToOrder(Product product)
        {
            Products.Add(product);
        }
        public static void RemoveFromOrder(Product product)
        {
            Products.Remove(product);
            NumberOfItems++;
        }
        public static void ClearCurrentOrder()
        {
            Products.Clear();
            NumberOfItems = 0;
        }
    }

    public enum PaymentType
    {
        Cash,
        Card,
    }
}
