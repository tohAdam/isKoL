using System;

namespace PaymentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string programmerName = "Your Name"; // Replace with your name
            string programTitle = "Payment System";

            double totalPrice = 0;
            int choice;

            Console.WriteLine($"Programmer: {programmerName}");
            Console.WriteLine($"Program Title: {programTitle}");

            do
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1: Make a Payment (Call By Value)");
                Console.WriteLine("2: Apply Discount (Call By Reference)");
                Console.WriteLine("3: Calculate Final Price with Discount (Using Out Parameter)");
                Console.WriteLine("4: Exit");
                Console.Write("Enter your choice: ");

                // Removed TryParse - relying on potential exceptions
                choice = int.Parse(Console.ReadLine()); 

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter payment amount: ");
                        // Removed TryParse - relying on potential exceptions
                        double payment = double.Parse(Console.ReadLine());
                        totalPrice = MakePayment(payment);
                        Console.WriteLine($"Payment processed. Total Price: {totalPrice:C}");
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