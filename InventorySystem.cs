using System;

class InventorySystem
{
    public static void Main()
    {
        string[,] users = { { "admin", "admin123" }, { "manager", "manager456" } };
        bool isAuthenticated = false;
        int attempts = 0;

        while (attempts < 3)
        {
            Console.Write("Enter Username: ");
            string username = Console.ReadLine();
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            for (int i = 0; i < users.GetLength(0); i++)
            {
                if (username == users[i, 0] && password == users[i, 1])
                {
                    isAuthenticated = true;
                    break;
                }
            }

            if (isAuthenticated)
            {
                Console.WriteLine("Login Successful! Welcome to the inventory Management System.\n");
                break;
            }
            else
            {
                Console.WriteLine("Wrong password\n");
                Console.WriteLine($"Login failed! Attempt {attempts + 1}/3");

                attempts++;
            }
        }

        if (!isAuthenticated)
        {
            Console.WriteLine("Too many failed attempts. Exiting...");
            return;
        }

        InventorySystem();
    }

    static void InventorySystem()
    {
        object[,] products = {
            { "Apples", "Milk", "Bread" },
            { 10, 5, 20 }
        };

        while (true)
        {
            Console.WriteLine("\nInventory Management System");
            Console.WriteLine("1. View Inventory");
            Console.WriteLine("2. Update Stock");
            Console.WriteLine("3. Calculate Total Units");
            Console.WriteLine("4. Logout ");
            Console.Write("Enter choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ViewInventory(products);
                    break;
                case "2":
                    UpdateStock(products);
                    break;
                case "3":
                    CalculateTotalStock(products);
                    break;
                case "4":
                    Console.WriteLine("Logout Successfully. Exiting System.");
                    return;
                default:
                    Console.WriteLine("Try again.");
                    break;
            }
        }
    }

    static void ViewInventory(object[,] products)
    {
        Console.WriteLine("\nInventory Details:");
        for (int i = 0; i < products.GetLength(1); i++)
        {
            string productName = (string)products[0, i];
            int stock = (int)products[1, i];
            Console.WriteLine($"{productName}: {stock} units");
        }
    }

    static void UpdateStock(object[,] products)
    {
        Console.Write("Enter product name to update stock: ");
        string productName = Console.ReadLine();

        int productIndex = -1;
        for (int i = 0; i < products.GetLength(1); i++)
        {
            if ((string)products[0, i] == productName)
            {
                productIndex = i;
                break;
            }
        }

        if (productIndex == -1)
        {
            Console.WriteLine("Product not found.");
        }
        else
        {
            Console.Write("Enter quantity to add: ");
            int quantity = int.Parse(Console.ReadLine());
            products[1, productIndex] = (int)products[1, productIndex] + quantity;
            Console.WriteLine($"{productName} stock updated successfully.");
        }
    }

    static void TotalStock(object[,] products)
    {
        int totalStock = 0;
        for (int i = 0; i < products.GetLength(1); i++)
        {
            totalStock += (int)products[1, i];
        }
        Console.WriteLine($"Total stock in inventory: {totalStock} units.");
    }
}
