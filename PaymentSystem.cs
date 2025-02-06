using System;

public class PaymentSystem
{
    public double Payment(double val)
    {
        double fee = val * 0.10;
        val = val + fee;
        Console.WriteLine("Processing fee added: $" + fee);
        Console.WriteLine("Updated Total (Call By Value): $" + val + "\n\n");
        return val;
    }

    public void Discount(ref double val)
    {
        double discount = val * 0.15;
        val = val - discount;
        Console.WriteLine("Discount applied: $" + discount);
    }

    public double Calculate(double price, double discount, out double calculatedPrice)
    {
        double discountTotal = price - (price * (discount / 100));
        calculatedPrice = discountTotal + (price * 0.1);
        Console.WriteLine("Discounted price: $" + discountTotal);
        return calculatedPrice;
    }
}

public class main
{
    static void Main(string[] args)
    {
        Console.WriteLine("PaymentSystem by: Adamusa Pingay\n");
        string choice;
        PaymentSystem ps = new PaymentSystem();

        double val = 1000;
        double calculatedPrice = 0;

        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1: Make Payment (Call By Value)");
            Console.WriteLine("2: Apply Discount (Call By Reference)");
            Console.WriteLine("3: Calculate Final Price with Discount (Using Out Parameter): ");
            Console.WriteLine("4: Exit");
            Console.Write("\n\nEnter option (1-4): ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    val = ps.Payment(val);
                    break;
                case "2":
                    ps.Discount(ref val);
                    Console.WriteLine("Total after Discount: $" + val + "\n\n");
                    break;
                case "3":
                    Console.Write("Enter discount percentage: ");
                    if (double.TryParse(Console.ReadLine(), out double discount))
                    {
                        calculatedPrice = ps.Calculate(val, discount, out calculatedPrice);
                        Console.WriteLine("Final Price after discount and processing fee: $" + calculatedPrice + "\n\n");

                    }
                    else
                    {
                        Console.WriteLine("Invalid discount input. Please enter a number.");
                    }
                    break;
                case "4":
                    Console.WriteLine("Thank you for using PaymentSystem, Bye!");
                    return;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
    }
}
