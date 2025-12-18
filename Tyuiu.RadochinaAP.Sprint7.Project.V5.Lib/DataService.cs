namespace Tyuiu.RadochinaAP.Sprint7.Project.V5.Lib
{
    public class DataService
    {
        private string productsFile = "products.csv";

        public class Product
        {
            public string Code { get; set; }
            public string Name { get; set; }
            public int Quantity { get; set; }
            public decimal Price { get; set; }
            public string Description { get; set; }
        }

        public List<Product> LoadProducts()
        {
            List<Product> products = new List<Product>();

            if (File.Exists(productsFile))
            {
                string[] lines = File.ReadAllLines(productsFile);
                for (int i = 1; i < lines.Length; i++) // пропускаем заголовок
                {
                    string[] data = lines[i].Split(';');
                    products.Add(new Product
                    {
                        Code = data[0],
                        Name = data[1],
                        Quantity = int.Parse(data[2]),
                        Price = decimal.Parse(data[3]),
                        Description = data[4]
                    });
                }
            }

            return products;
        }

        public void SaveProducts(List<Product> products)
        {
            List<string> lines = new List<string>();
            lines.Add("Код;Название;Количество;Цена;Описание");

            foreach (Product p in products)
            {
                lines.Add($"{p.Code};{p.Name};{p.Quantity};{p.Price};{p.Description}");
            }

            File.WriteAllLines(productsFile, lines);
        }

        public List<Product> SearchProducts(string searchText)
        {
            List<Product> allProducts = LoadProducts();
            List<Product> result = new List<Product>();

            foreach (Product p in allProducts)
            {
                if (p.Name.Contains(searchText) ||
                    p.Code.Contains(searchText) ||
                    p.Description.Contains(searchText))
                {
                    result.Add(p);
                }
            }

            return result;
        }

        public int GetTotalProducts()
        {
            return LoadProducts().Count;
        }

        public int GetTotalQuantity()
        {
            return LoadProducts().Sum(p => p.Quantity);
        }
        public decimal GetTotalValue()
        {
            return LoadProducts().Sum(p => p.Quantity * p.Price);
        }
    }
}