namespace LinqProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId = 1, CategoryName="Bilgisayar"},
                new Category{CategoryId = 2, CategoryName = "Telefon"}
            };

            List<Product> products = new List<Product>
            {
                new Product{ProductId=1, CategoryId=1, ProductName="Acer Laptop", QuantityPerUnit="32 GB Ram", UnitPrice=50000, UnitsInStock=5},
                new Product{ProductId=2, CategoryId=1, ProductName="Asus Laptop", QuantityPerUnit="16 GB Ram", UnitPrice=30000, UnitsInStock=3},
                new Product{ProductId=3, CategoryId=1, ProductName="Hp Laptop", QuantityPerUnit="8 GB Ram", UnitPrice=20000, UnitsInStock=2},
                new Product{ProductId=4, CategoryId=2, ProductName="Samsung Telefon", QuantityPerUnit="4 GB Ram", UnitPrice=15000, UnitsInStock=15},
                new Product{ProductId=5, CategoryId=2, ProductName="Apple Telefon", QuantityPerUnit="4 GB Ram", UnitPrice=18000, UnitsInStock=0},
            };

            Console.WriteLine("Algoritmik----------------------");
            var result1 = GetProducts(products);
            foreach (var product in result1)
            {
                Console.WriteLine(product.ProductName);
            }

            Console.WriteLine("Linq----------------------------");
            var result2 = GetProductsWithLinq(products);
            foreach (var product in result2)
            {
                Console.WriteLine(product.ProductName); ;
            }
        }

        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filteredProducts = new List<Product>();
            foreach (var product in products)
            {
                if (product.UnitPrice > 19000 && product.UnitsInStock > 3)
                {
                    filteredProducts.Add(product);
                }
            }
            return filteredProducts;
        }

        static List<Product> GetProductsWithLinq(List<Product> products)
        {
            return products.Where(p => p.UnitPrice > 19000 && p.UnitsInStock > 3).ToList();
        }
    }

    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
