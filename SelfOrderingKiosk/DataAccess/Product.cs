using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccess
{
    public class Product : IComparable<Product>
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public ProductType Type { get; set; }
        public string ImagePath { get; set; }

        public Product() { }
        public Product(string name, decimal price, ProductType type)
        {
            Name = name;
            Price = price;
            Type = type;
        }

        public Product(string name, decimal price, ProductType type, string imagePath)
        {
            Name = name;
            Price = price;
            Type = type;
            ImagePath = imagePath;
        }

        public int CompareTo(Product other)
        {
            if (other == null)
                return 1;
            return Name.CompareTo(other.Name);
        }
    }
}

namespace DataAccess
{
    public enum ProductType
    {
        Burgers,
        Fries,
        Drinks,
    }
}