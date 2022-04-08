using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace DataAccess
{
    public class Order
    {
        public List<Product> Products = CurrentOrder.Products;
        public int NumberOfItems = CurrentOrder.NumberOfItems;
        public PaymentType PaymentType = CurrentOrder.PaymentType;
        public decimal TotalAmount = CurrentOrder.Products.Sum(p => p.Price);

        public Order() { }

        public void SaveXML(string date)
        {
            XmlSerializer sr = new XmlSerializer(typeof(Order));
            using (StreamWriter sw = new StreamWriter($"{date}.xml"))
            {
                sr.Serialize(sw, this);
            }
        }
    }
}
