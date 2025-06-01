using inventory_management_system;

class Program
{
    private static Inventory _inventory = new Inventory();

    static void Main(string[] args)
    {
        bool exit = false;
        while (!exit)
        {
            ShowMessage("\nInventory Management System");
            ShowMessage("1. Add New Product");
            ShowMessage("2. Update Stock");
            ShowMessage("3. View All Products");
            ShowMessage("4. Remove Product");
            ShowMessage("5. Exit");
            ShowMessage("Select an option: ", false);

            switch (ReadInput())
            {
                case "1":
                    AddNewProduct();
                    break;
                case "2":
                    UpdateStock();
                    break;
                case "3":
                    ViewAllProducts();
                    break;
                case "4":
                    RemoveProduct();
                    break;
                case "5":
                    exit = true;
                    break;
                default:
                    ShowMessage("Invalid option. Please try again.");
                    break;
            }
        }
        ShowMessage("You Logged Out!");
    }

    private static void AddNewProduct()
    {
        try
        {
            ShowMessage("\nAdding New Product");
            ShowMessage("------------------");

            ShowMessage("Enter product name: ", false);
            string? inputName = ReadInput();
            if (string.IsNullOrWhiteSpace(inputName))
            {
                ShowMessage("Product name cannot be empty.");
                return;
            }
            string name = inputName;

            ShowMessage("Enter price: $ ", false);
            if (!decimal.TryParse(ReadInput(), out decimal price))
            {
                ShowMessage("Invalid price format.");
                return;
            }

            ShowMessage("Enter initial stock quantity: ", false);
            if (!int.TryParse(ReadInput(), out int quantity))
            {
                ShowMessage("Invalid quantity format.");
                return;
            }

            ShowMessage("\nConfirm adding product with following details:");
            ShowMessage($"Name: {name}");
            ShowMessage($"Price: ${price:F2}");
            ShowMessage($"Initial Stock: {quantity}");
            ShowMessage("Proceed? (y/n): ", false);

            if (!ReadInput().Equals("y"))
            {
                ShowMessage("Operation cancelled.");
                return;
            }

            _inventory.AddProduct(name, price, quantity);
            ShowMessage("✓ Product added successfully!");
        }
        catch (Exception ex)
        {
            ShowMessage($"Error: {ex.Message}");
        }
    }

    private static void UpdateStock()
    {
        try
        {
            ShowMessage("\nUpdating Stock");
            ShowMessage("--------------");

            ShowMessage("Enter product ID: ", false);
            if (!int.TryParse(ReadInput(), out int id))
            {
                ShowMessage("Invalid ID format.");
                return;
            }

            var product = _inventory.GetProduct(id);
            if (product == null)
            {
                ShowMessage("Product not found.");
                return;
            }

            ShowMessage($"\nCurrent stock for {product.Name}: {product.Quantity}");

            ShowMessage("Enter quantity change (+/-): ", false);
            if (!int.TryParse(ReadInput(), out int quantity))
            {
                ShowMessage("Invalid quantity format.");
                return;
            }

            ShowMessage($"\nConfirm {(quantity >= 0 ? "adding" : "removing")} {Math.Abs(quantity)} units? (y/n): ", false);
            if (!ReadInput().Equals("y"))
            {
                ShowMessage("Operation cancelled.");
                return;
            }

            _inventory.UpdateStock(id, quantity);
            ShowMessage($"✓ Stock updated successfully! New quantity: {product.Quantity + quantity}");
        }
        catch (Exception ex)
        {
            ShowMessage($"Error: {ex.Message}");
        }
    }

    private static void ViewAllProducts()
    {
        var products = _inventory.GetAllProducts();
        if (products.Count == 0)
        {
            ShowMessage("No products in inventory.");
            return;
        }

        ShowMessage("\nCurrent Inventory:");
        foreach (var product in products)
        {
            ShowMessage(product.ToString());
        }
    }

    private static void RemoveProduct()
    {
        try
        {
            ShowMessage("\nRemoving Product");
            ShowMessage("----------------");

            ShowMessage("Enter product ID to remove: ", false);
            if (!int.TryParse(ReadInput(), out int id))
            {
                ShowMessage("Invalid ID format.");
                return;
            }

            var product = _inventory.GetProduct(id);
            if (product == null)
            {
                ShowMessage("Product not found.");
                return;
            }

            ShowMessage($"\nConfirm removing product:");
            ShowMessage(product.ToString());
            ShowMessage("Are you sure? (y/n): ", false);

            if (!ReadInput().Equals("y"))
            {
                ShowMessage("Operation cancelled.");
                return;
            }

            if (product.Quantity > 0)
            {
                ShowMessage($"Cannot remove product with remaining stock ({product.Quantity} units).");
                return;
            }

            _inventory.RemoveProduct(id);
            ShowMessage("✓ Product removed successfully!");
        }
        catch (Exception ex)
        {
            ShowMessage($"Error: {ex.Message}");
        }
    }

    private static void ShowMessage(string message, bool isLine = true)
    {
        if (isLine)
            Console.WriteLine(message);
        else
            Console.Write(message);
    }

    private static string ReadInput()
    {
        return Console.ReadLine() ?? string.Empty;
    }
}






