using System.Globalization;

namespace Tyuiu.RadochinaAP.Sprint7.Project.V5.Lib
{
    public class DataService
    {
        // Класс для хранения данных о товаре
        public class Товар_RAP
        {
            public string Код_RAP { get; set; } = "";
            public string Название_RAP { get; set; } = "";
            public int Количество_RAP { get; set; }
            public decimal Цена_RAP { get; set; }
            public string Примечание_RAP { get; set; } = "";

            // Вычисляемое свойство: Общая стоимость
            public decimal ОбщаяСтоимость_RAP => Количество_RAP * Цена_RAP;
        }

        // 1. ЧТЕНИЕ из CSV файла
        public List<Товар_RAP> ПрочитатьCSV_RAP(string путьФайла_RAP)
        {
            var список_RAP = new List<Товар_RAP>();

            if (!File.Exists(путьФайла_RAP))
                return список_RAP;

            string[] всеСтроки_RAP = File.ReadAllLines(путьФайла_RAP);

            // Первая строка - заголовки, пропускаем
            for (int i = 1; i < всеСтроки_RAP.Length; i++)
            {
                string[] части_RAP = всеСтроки_RAP[i].Split(';');

                if (части_RAP.Length >= 5)
                {
                    var товар_RAP = new Товар_RAP
                    {
                        Код_RAP = части_RAP[0],
                        Название_RAP = части_RAP[1],
                        Количество_RAP = int.Parse(части_RAP[2]),
                        Цена_RAP = decimal.Parse(части_RAP[3], CultureInfo.InvariantCulture),
                        Примечание_RAP = части_RAP[4]
                    };

                    список_RAP.Add(товар_RAP);
                }
            }

            return список_RAP;
        }

        // 2. ЗАПИСЬ в CSV файл
        public void ЗаписатьCSV_RAP(string путьФайла_RAP, List<Товар_RAP> товары_RAP)
        {
            var строки_RAP = new List<string>();

            // Заголовки столбцов
            строки_RAP.Add("Код;Название;Количество;Цена;Примечание");

            // Данные товаров
            foreach (var т in товары_RAP)
            {
                string строка_RAP = $"{т.Код_RAP};{т.Название_RAP};{т.Количество_RAP};" +
                                  $"{т.Цена_RAP.ToString(CultureInfo.InvariantCulture)};{т.Примечание_RAP}";
                строки_RAP.Add(строка_RAP);
            }

            File.WriteAllLines(путьФайла_RAP, строки_RAP);
        }

        // 3. ПОИСК товаров
        public List<Товар_RAP> НайтиТовары_RAP(List<Товар_RAP> товары_RAP, string текст_RAP)
        {
            if (string.IsNullOrWhiteSpace(текст_RAP))
                return товары_RAP;

            текст_RAP = текст_RAP.ToLower();

            return товары_RAP.Where(т =>
                т.Код_RAP.ToLower().Contains(текст_RAP) ||
                т.Название_RAP.ToLower().Contains(текст_RAP)).ToList();
        }

        // 4. СТАТИСТИКА
        public string ПолучитьСтатистику_RAP(List<Товар_RAP> товары_RAP)
        {
            if (товары_RAP.Count == 0)
                return "Нет данных";

            int всего = товары_RAP.Count;
            int суммаКоличества = товары_RAP.Sum(т => т.Количество_RAP);
            decimal суммаСтоимости = товары_RAP.Sum(т => т.ОбщаяСтоимость_RAP);
            decimal средняяЦена = товары_RAP.Average(т => т.Цена_RAP);
            int нетВНаличии = товары_RAP.Count(т => т.Количество_RAP == 0);

            return $"Всего: {всего} товаров\n" +
                   $"На складе: {суммаКоличества} ед.\n" +
                   $"Общая стоимость: {суммаСтоимости:C}\n" +
                   $"Средняя цена: {средняяЦена:C}\n" +
                   $"Нет в наличии: {нетВНаличии}";
        }

        // 5. ТЕСТОВЫЕ ДАННЫЕ
        public List<Товар_RAP> СоздатьТестовыеДанные_RAP()
        {
            return new List<Товар_RAP>
            {
                new Товар_RAP { Код_RAP = "П001", Название_RAP = "Сахар", Количество_RAP = 100, Цена_RAP = 85.50m, Примечание_RAP = "Рафинированный" },
                new Товар_RAP { Код_RAP = "П002", Название_RAP = "Мука", Количество_RAP = 50, Цена_RAP = 62.30m, Примечание_RAP = "Высший сорт" },
                new Товар_RAP { Код_RAP = "П003", Название_RAP = "Соль", Количество_RAP = 120, Цена_RAP = 24.80m, Примечание_RAP = "Йодированная" },
                new Товар_RAP { Код_RAP = "П004", Название_RAP = "Рис", Количество_RAP = 0, Цена_RAP = 120.00m, Примечание_RAP = "Басмати" },
                new Товар_RAP { Код_RAP = "П005", Название_RAP = "Чай", Количество_RAP = 30, Цена_RAP = 320.00m, Примечание_RAP = "Черный" }
            };
        }
    }
}