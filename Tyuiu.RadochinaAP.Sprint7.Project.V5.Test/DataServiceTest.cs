using Tyuiu.RadochinaAP.Sprint7.Project.V5.Lib;
namespace Tyuiu.RadochinaAP.Sprint7.Project.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        private DataService GetService()
        {
            return new DataService();
        }

        private List<DataService.Product> GetTestData()
        {
            return new List<DataService.Product>
            {
                new DataService.Product { Code = "P001", Name = "Сахар", Quantity = 100, Price = 85.50m },
                new DataService.Product { Code = "P002", Name = "Мука", Quantity = 50, Price = 62.30m },
                new DataService.Product { Code = "P003", Name = "Соль", Quantity = 20, Price = 24.80m }
            };
        }

        [TestMethod]
        public void TestSearchProducts()
        {
            var service = GetService();
            var data = GetTestData();

            var result = service.SearchProducts(data, "сах");

            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("Сахар", result[0].Name);
        }

        [TestMethod]
        public void TestSortByName()
        {
            var service = GetService();
            var data = GetTestData();

            var result = service.SortByName(data);

            Assert.AreEqual("Мука", result[0].Name);
            Assert.AreEqual("Сахар", result[1].Name);
            Assert.AreEqual("Соль", result[2].Name);
        }

        [TestMethod]
        public void TestSortByPrice()
        {
            var service = GetService();
            var data = GetTestData();

            var result = service.SortByPrice(data);

            Assert.IsTrue(result[0].Price <= result[1].Price);
            Assert.IsTrue(result[1].Price <= result[2].Price);
        }

        [TestMethod]
        public void TestFilterInStock()
        {
            var service = GetService();
            var data = GetTestData();

            var result = service.FilterInStock(data);

            Assert.AreEqual(3, result.Count);
            Assert.IsTrue(result.All(p => p.Quantity > 0));
        }

        [TestMethod]
        public void TestGetStatistics()
        {
            var service = GetService();
            var data = GetTestData();

            var stats = service.GetStatistics(data);

            Assert.AreEqual(3, stats.count);
            Assert.AreEqual(170, stats.totalQty);
            Assert.IsTrue(stats.totalValue > 0);
        }

        [TestMethod]
        public void TestTotalValueCalculation()
        {
            var product = new DataService.Product
            {
                Code = "TEST",
                Name = "Test",
                Quantity = 10,
                Price = 100.00m
            };

            Assert.AreEqual(1000.00m, product.TotalValue);
        }
    }
}