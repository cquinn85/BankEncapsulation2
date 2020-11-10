using System;

namespace BankEncapsulation2
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the main method of your application, 
            //create a new instance of the BankAccount class. 
           

            var account = new BankAccount();// use BAnkAccount in place of var
                                            // after new you call the constructor

            //Allow the user of the application to Deposit money 
            //and retrieve their balance through the console.
            Console.WriteLine("How much would you like to deposit:");

            var amountToDeposit = double.Parse(Console.ReadLine());

            //call the deposit method
            account.Deposit(amountToDeposit);

            Console.WriteLine($"Thank you. Your balance is now {account.GetBalance()}");

        }
    }
}
