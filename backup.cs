using System;

public class PaymentSystem
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Simple Payment System");
        Console.WriteLine("User: Enya L. Moncayo\n");

        double totalPrice = 0;
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nMenu Options\n");
            Console.WriteLine("1: Make a Payment (Call by Value)");
            Console.WriteLine("2: Apply Discount (Call by Reference)");
            Console.WriteLine("3: Calculate Final Price with Discount (Using Out Parameter)");
            Console.WriteLine("4: Exit");

            // Input
            Console.Write("\nEnter Option (1-4): ");
            int inputOptions = Convert.ToInt32(Console.ReadLine());



            // Menu Options 
            switch (inputOptions)
            {
                case 1: // Make a Payment
                    Console.Write("Enter Amount to Pay: $");
                    totalPrice = Convert.ToDouble(Console.ReadLine());
                        totalPrice = PaymentFee(totalPrice);
                        Console.WriteLine("Update Total(Call By Value): $" +totalPrice);
                        Console.WriteLine("\n------------------------------------------------");
                    break;

                case 2: // Apply Discount
                        
                        DiscountFee(ref totalPrice);
                        Console.WriteLine("Total after Discount (Call By Reference): $" +totalPrice);
                        Console.WriteLine("\n------------------------------------------------");
                    break;

                case 3: // Calculate Final Price with Discount
                        double finalPrice;
                        Calculate(out finalPrice, totalPrice);
                        Console.WriteLine("Final Price after Discount (Out Parameter): $" +finalPrice);
                        Console.WriteLine("\n------------------------------------------------");
                    break;

                case 4: // Exit Program
                    Console.WriteLine("Exiting the System. Thank you for using the Simple Payment System!");
                    running = false;
                    break;

                default:
                    // This will never be reached due to the validation above.
                    break;
            }
        }
    }

    // *Call By Value*: Adds a 10% processing fee
    public static double PaymentFee(double price)
    {
        return price + (price * 0.10);
    }

    // *Call By Reference*: Applies a 15% discount
    public static void DiscountFee(ref double price)
    {
        double discountTotal = price * 0.15;
        price = price - discountTotal;
        Console.WriteLine("\nApplied Discount: $" +discountTotal);
    }

    // *Out Parameter*: Calculates the final price after discount
    public static void Calculate(out double finalPrice, double price)
    {
        finalPrice = price - (price * 0.15);
    }
}
