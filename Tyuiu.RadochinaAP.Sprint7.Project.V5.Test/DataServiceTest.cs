using Tyuiu.RadochinaAP.Sprint7.Project.V5.Lib;
namespace Tyuiu.RadochinaAP.Sprint7.Project.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void LoadProductsTest()
        {
            DataService ds = new DataService();
            var products = ds.LoadProducts();

            Assert.IsNotNull(products);
        }

        [TestMethod]
        public void GetTotalProductsTest()
        {
            DataService ds = new DataService();
            int count = ds.GetTotalProducts();

            Assert.IsTrue(count >= 0);
        }
    }
}
