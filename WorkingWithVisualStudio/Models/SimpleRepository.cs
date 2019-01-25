using System.Collections.Generic;


namespace WorkingWithVisualStudio.Models
{
    public class SimpleRepository
    {
        private static SimpleRepository sharedRepository = new SimpleRepository();
        private Dictionary<string, Product> products = new Dictionary<string, Product>();

        public static SimpleRepository SharedRepository => sharedRepository;

        public SimpleRepository()
        {
            var initialItems = new[]
            {
                new Product {Name = "Kayak", Price = 275M},
                new Product {Name = "Life jacket", Price = 48.95M},

            };

            foreach (var p in initialItems)
            {
                AddProduct(p);
            }
        }

        public IEnumerable<Product> Products => products.Values;

  
        public void AddProduct(Product p) => products.Add(p.Name, p);



    }
}
