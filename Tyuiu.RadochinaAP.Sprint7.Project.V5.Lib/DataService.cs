using System.Globalization;

namespace Tyuiu.RadochinaAP.Sprint7.Project.V5.Lib
{
    public class DataService
    {
        public class Product
        {
            public string Code { get; set; } = "";
            public string Name { get; set; } = "";
            public int Quantity { get; set; }
            public decimal Price { get; set; }
            public string Notes { get; set; } = "";
            public decimal TotalValue => Quantity * Price;
        }

        public List<Product> LoadFromCSV(string filePath)
        {
            var products = new List<Product>();

            if (!File.Exists(filePath))
                return products;

            try
            {
                var lines = File.ReadAllLines(filePath);

                for (int i = 1; i < lines.Length; i++)
                {
                    var parts = lines[i].Split(';');

                    if (parts.Length >= 5)
                    {
                        products.Add(new Product
                        {
                            Code = parts[0],
                            Name = parts[1],
                            Quantity = int.Parse(parts[2]),
                            Price = decimal.Parse(parts[3], CultureInfo.InvariantCulture),
                            Notes = parts[4]
                        });
                    }
                }
            }
            catch
            {
                return new List<Product>();
            }

            return products;
        }

        public void SaveToCSV(string filePath, List<Product> products)
        {
            var lines = new List<string> { "Code;Name;Quantity;Price;Notes" };

            foreach (var p in products)
            {
                lines.Add($"{p.Code};{p.Name};{p.Quantity};{p.Price.ToString(CultureInfo.InvariantCulture)};{p.Notes}");
            }

            File.WriteAllLines(filePath, lines);
        }

        public List<Product> SearchProducts(List<Product> products, string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
                return products;

            return products.Where(p =>
                p.Code.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                p.Name.Contains(searchText, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Product> SortByName(List<Product> products)
        {
            return products.OrderBy(p => p.Name).ToList();
        }

        public List<Product> SortByPrice(List<Product> products)
        {
            return products.OrderBy(p => p.Price).ToList();
        }

        public List<Product> FilterInStock(List<Product> products)
        {
            return products.Where(p => p.Quantity > 0).ToList();
        }

        public List<Product> GetDemoData()
        {
            return new List<Product>
            {
                new Product { Code = "P001", Name = "Сахар", Quantity = 150, Price = 85.50m, Notes = "Рафинированный" },
                new Product { Code = "P002", Name = "Мука", Quantity = 75, Price = 62.30m, Notes = "Пшеничная" },
                new Product { Code = "P003", Name = "Соль", Quantity = 120, Price = 24.80m, Notes = "Йодированная" },
                new Product { Code = "P004", Name = "Рис", Quantity = 0, Price = 120.00m, Notes = "Басмати" },
                new Product { Code = "P005", Name = "Чай", Quantity = 45, Price = 320.00m, Notes = "Черный" },
                new Product { Code = "P006", Name = "Кофе", Quantity = 28, Price = 450.75m, Notes = "Молотый" },
                new Product { Code = "P007", Name = "Масло", Quantity = 32, Price = 180.50m, Notes = "Подсолнечное" }
            };
        }

        public (int count, int totalQty, decimal totalValue, decimal avgPrice, int outOfStock)
            GetStatistics(List<Product> products)
        {
            if (products.Count == 0)
                return (0, 0, 0, 0, 0);

            return (
                products.Count,
                products.Sum(p => p.Quantity),
                products.Sum(p => p.TotalValue),
                products.Average(p => p.Price),
                products.Count(p => p.Quantity == 0)
            );
        }
    }
}