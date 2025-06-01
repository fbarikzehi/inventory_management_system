
namespace inventory_management_system
{
    public class Product(int id, string name, decimal price, int quantity)
    {
        public int Id { get; set; } = id;
        public string Name { get; set; } = name;
        public decimal Price { get; set; } = price;
        public int Quantity { get; set; } = quantity;

        public void UpdateStock(int change)
        {
            int newQuantity = Quantity + change;
            if (newQuantity < 0)
            {
                Console.WriteLine($"Cannot reduce stock by {Math.Abs(change)} units. Current stock: {Quantity}");
            }
            Quantity = newQuantity;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Price: ${Price:F2}, Stock: {Quantity}";
        }
    }
}