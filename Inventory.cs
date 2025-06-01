namespace inventory_management_system
{
    public class Inventory
    {
        private List<Product> _products;
        private int _id;

        public Inventory()
        {
            _products = new List<Product>();
            _id = 1;
        }

        public void AddProduct(string name, decimal price, int quantity)
        {
            var product = new Product(_id++, name, price, quantity);
            _products.Add(product);
        }

        public void RemoveProduct(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                _products.Remove(product);
            }
        }

        public void UpdateStock(int id, int quantity)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            product?.UpdateStock(quantity);
        }

        public List<Product> GetAllProducts()
        {
            return _products.ToList();
        }

        public Product? GetProduct(int id)
        {
            Product? product = _products.FirstOrDefault(p => p.Id == id);

            if (product is null)
            {
                Console.WriteLine("Product not found");
            }

            return product;
        }
    }
}