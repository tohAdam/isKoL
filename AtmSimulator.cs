
using System;

public class AtmSimulator {

    public static void Main(string[] args)
    {
        
            Console.WriteLine("ATM Simulator by: ADAMUSA U. PINGAY");
            
                    int balance = 1000;
                    bool exit = false;
          
           while(!exit) {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Exit\n");
            
            Console.Write("Enter your Choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

            
           switch(choice)
                {
                    case 1:
                    Console.WriteLine("Your current balance is $" +balance);
                    break;
                    
                    case 2: 
                    Console.WriteLine("Enter the amount to deposit: ");
                    double deposit = Convert.ToDouble(Console.ReadLine());
                    
                    double resultBal = balance + deposit;
                    
                    Console.WriteLine("Deposit Successful! Your new balance is $" +resultBal);
                    break;
                    
                    case 3:
                    Console.WriteLine("Enter the amount to Withdraw: ");
                    double withdraw = Convert.ToDouble(Console.ReadLine());
                    
                     if(withdraw <= balance)
                     {
                         double withdrawAmount = withdraw - balance;
                         
                         Console.WriteLine("Successful! Your new Balance is " +withdrawAmount);
                         
                     }
                     else
                         Console.WriteLine("Insuffiecient balance! Please enter a smaller amount. ");    
                     break;
                     
                     case 4:
                     Console.WriteLine("Thank You for using the ATM Simulator!");
                            return;
            }
        }
    }
}


