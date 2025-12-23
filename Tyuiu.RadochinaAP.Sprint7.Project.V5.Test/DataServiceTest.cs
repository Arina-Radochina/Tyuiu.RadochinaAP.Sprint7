using Tyuiu.RadochinaAP.Sprint7.Project.V5.Lib;
namespace Tyuiu.RadochinaAP.Sprint7.Project.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ТестДанных_RAP()
        {
            // Создаем сервис
            var сервис_RAP = new DataService();

            // Получаем тестовые данные
            var данные_RAP = сервис_RAP.СоздатьТестовыеДанные_RAP();

            // Проверяем
            Assert.AreEqual(5, данные_RAP.Count); // Должно быть 5 товаров
            Assert.AreEqual("Сахар", данные_RAP[0].Название_RAP); // Первый - сахар
        }

        [TestMethod]
        public void ТестПоиска_RAP()
        {
            var сервис_RAP = new DataService();
            var данные_RAP = сервис_RAP.СоздатьТестовыеДанные_RAP();

            // Ищем "сахар"
            var найденные_RAP = сервис_RAP.НайтиТовары_RAP(данные_RAP, "сахар");

            Assert.AreEqual(1, найденные_RAP.Count); // Найден 1 товар
            Assert.AreEqual("П001", найденные_RAP[0].Код_RAP); // Код правильный
        }

        [TestMethod]
        public void ТестСтатистики_RAP()
        {
            var сервис_RAP = new DataService();
            var данные_RAP = сервис_RAP.СоздатьТестовыеДанные_RAP();

            string статистика_RAP = сервис_RAP.ПолучитьСтатистику_RAP(данные_RAP);

            // Проверяем, что статистика содержит нужные слова
            Assert.IsTrue(статистика_RAP.Contains("Всего:"));
            Assert.IsTrue(статистика_RAP.Contains("На складе:"));
        }
    }
}