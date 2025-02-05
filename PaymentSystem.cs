using System;

namespace PaymentSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            double totalPrice = 1000;
            int choice;

            Console.WriteLine($"Programmer: Pingay, Adamusa U");
            Console.WriteLine($"Program Title: Payment System");

            do
            {
                Console.WriteLine("\nMenu Options:");
                Console.WriteLine("1: Make a Payment (Call By Value)");
                Console.WriteLine("2: Apply Discount (Call By Reference)");
                Console.WriteLine("3: Calculate Final Price with Discount (Using Out Parameter)");
                Console.WriteLine("4: Exit");
                Console.Write("Enter option (1-4): ");

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Processing fee added: ");
                            if (double.TryParse(Console.ReadLine(), out double payment))
                            {
                                totalPrice = MakePayment(payment);
                                Console.WriteLine($"updated Total (Call By Reference): {totalPrice:C}");
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid number.");
                            }
                            break;
                        case 2:
                            ApplyDiscount(ref totalPrice);
                            Console.WriteLine($"Discount applied. Total Price: {totalPrice:C}");
                            break;
                        case 3:
                            double finalPrice;
                            CalculateFinalPrice(totalPrice, out finalPrice);
                            Console.WriteLine($"Final price calculated. Final Price: {finalPrice:C}");
                            break;
                        case 4:
                            Console.WriteLine("Exiting program.");
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }

            } while (choice != 4);
        }

        // Call By Value
        static double MakePayment(double amount)
        {
            double processingFee = amount * 0.10; // 10% processing fee
            return amount + processingFee;
        }

        // Call By Reference
        static void ApplyDiscount(ref double price)
        {
            double discount = price * 0.15; // 15% discount
            price -= discount;
        }

        // Out Parameter
        static void CalculateFinalPrice(double price, out double finalPrice)
        {
            double discount = price * 0.15; // 15% discount
            finalPrice = price - discount;
        }
    }
}

/*
using System;

class PaymentSystem
{
    public double MakePayment(double amount)
    {
        double processingFee = amount * 0.10;
        return amount + processingFee;
    }

    public void ApplyDiscount(ref double price)
    {
        double discount = price * 0.15;
        price -= discount;
    }

    public double CalculateFinalPrice(double price, double discountPercentage, out double finalPrice)
    {
        double discountAmount = price * (discountPercentage / 100);
        finalPrice = price - discountAmount;
        return finalPrice;
    }

    static void Main(string[] args)
    {
        PaymentSystem ps = new PaymentSystem();
        double totalPrice = 1000;
        string choice;

        while (true)
        {
                      Console.WriteLine("System Payment by: Adamusa U. Pingay");
            Console.WriteLine("\nCurrent Total: $" + totalPrice);
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1: Make Payment (Call By Value)");
            Console.WriteLine("2: Apply Discount (Call By Reference)");
            Console.WriteLine("3: Calculate Final Price with Discount (Out Parameter)");
            Console.WriteLine("4: Exit");
            Console.Write("\nEnter option (1-4): ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    totalPrice = ps.MakePayment(totalPrice);
                    Console.WriteLine("Updated Total: $" + totalPrice + "\n");
                    break;

                case "2":
                    ps.ApplyDiscount(ref totalPrice);
                    Console.WriteLine("Total after Discount: $" + totalPrice + "\n");
                    break;

                case "3":
                    Console.Write("Enter discount percentage: ");
                    if (double.TryParse(Console.ReadLine(), out double discountPercentage))
                    {
                        double finalPrice;
                        ps.CalculateFinalPrice(totalPrice, discountPercentage, out finalPrice);
                        Console.WriteLine("Final Price after discount: $" + finalPrice + "\n");
                        totalPrice = finalPrice;
                    }
                    else
                    {
                        Console.WriteLine("Invalid discount percentage.\n");
                    }
                    break;

                case "4":
                    Console.WriteLine("Exiting program...");
                    return;

                default:
                    Console.WriteLine("Invalid Input\n");
                    break;
            }
        }
    }
}
*/
