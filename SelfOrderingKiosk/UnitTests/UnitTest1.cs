using DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void CreateFinalOrder_Products()
        {
            //Arrange
            var product1 = new Product("Maestro Bacon & Cheddar", 20, ProductType.Burgers, "/Images/maestroBaconCheddar.jpg");
            var product2 = new Product("Maestro Grilled Cheese", 20, ProductType.Burgers, "/Images/maestroGrilledCheese.png");
            var order = new Order();

            //Act
            CurrentOrder.AddToOrder(product1);
            CurrentOrder.AddToOrder(product2);

            //Assert
            Assert.AreEqual(order.Products, CurrentOrder.Products);
        }

        [TestMethod]
        public void CreateFinalOrder_TotalAmmount()
        {
            //Arrange
            var product1 = new Product("Maestro Bacon & Cheddar", 20, ProductType.Burgers, "/Images/maestroBaconCheddar.jpg");
            var product2 = new Product("Maestro Grilled Cheese", 20, ProductType.Burgers, "/Images/maestroGrilledCheese.png");
            var order = new Order();

            //Act
            CurrentOrder.AddToOrder(product1);
            CurrentOrder.AddToOrder(product2);

            //Assert
            Assert.AreEqual(order.TotalAmount, CurrentOrder.TotalAmount);
        }

        [TestMethod]
        public void AddProductToCurrentOrder_NumberOfItems()
        {
            //Arrange
            var product = new Product();
            var counter = CurrentOrder.NumberOfItems;

            //Act
            CurrentOrder.AddToOrder(product);

            //Assert
            Assert.AreEqual(counter++, CurrentOrder.NumberOfItems);
        }
    }
}
