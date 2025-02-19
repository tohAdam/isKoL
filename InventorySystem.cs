using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string[,] users = { {"admin", "admin123"}, {"manager", "manager456"} };
        string[] products = { "Apples", "Milk", "Bread" };
        string username, password, choice;
        int[] stock = { 10, 5, 20 };
        int tries = 0;
        bool verify = false; 

        while (tries < 3 && !verify)
        {
            Console.WriteLine("Enter Username:");
            username = Console.ReadLine(); 

            int check = -1;

            for (int i = 0; i < users.GetLength(0); i++)
            {
                if (username == users[i, 0])
                {
                    check = i;
                    break; 
                }
            }

            if (check == -1)
            {
                Console.WriteLine("Invalid User");
                return;
            }

            Console.WriteLine("Enter Password:");
            string pass = Console.ReadLine();

            if (pass == users[check, 1])
            {
                verify = true;
                Console.WriteLine("Login Successful! Welcome to the Inventory Management System.");
            }
            else
            {
                tries++;
                Console.WriteLine($"Login failed! Attempt {tries} of 3");
            }
        }

        if (tries == 3)
        {
            Console.WriteLine("Too many failed attempts. Exiting program");
            return;
        }

        Console.WriteLine("\nSelect an option from the menu:");
        Console.Write("1. View Inventory\n2. Update Stock\n3. Calculate Total Units\n4. Logout");

        do
        {
            Console.Write("\nEnter choice: ");
            choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Current Inventory:");
                    for (int i = 0; i < products.Length; i++) 
                        Console.WriteLine($"{products[i]}\t:\t{stock[i]} units"); 
                    break;
                case "2":
                    Console.Write("Enter product name: ");
                        string prod = Console.ReadLine();

                    for (int i = 0; i < products.Length; i++) 
                    {
                        if (prod == products[i])
                        {
                            Console.Write("Enter quantity to add: ");
                              int add = Convert.ToInt32(Console.ReadLine());
                              stock[i] += add; 
                                Console.WriteLine($"Updated Inventory: {products[i]} now has {stock[i]} units");
                                    break;
                        }
                    }
                    break;
                case "3":
                    int total = 0;
                    for (int i = 0; i < stock.Length; i++) 
                        total += stock[i]; 
                            Console.WriteLine($"Total products in stock: {total} units");
                    break;
                case "4":
                    Console.WriteLine("Logout Successfully. Exiting System.");
                    return;
                default:
                    Console.WriteLine("Invalid Input. Try again.");
                    break;
            }

        } while (choice != "4");
    }
}
