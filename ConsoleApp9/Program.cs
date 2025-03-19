using System;
using System.Diagnostics.Eventing.Reader;

namespace Tower_of_Hanoi_Prelims
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // main important variables
            bool usingATM = true;
            int balance = 1000;
            int transactionCount = 0;
            string[] transactionHistory = new string[100];


            // task 1
            for (int i = 0; i < 100; i++)
            {
             
                transactionHistory[i] = "No Transaction Yet";
          
            }

            while (usingATM)
            {

                // task 2
                Console.WriteLine("=== ATM Menu ===");
                Console.WriteLine();
                Console.WriteLine("1. Check Balance");
                Console.WriteLine();
                Console.WriteLine("2. Deposit");
                Console.WriteLine();
                Console.WriteLine("3. Withdraw");
                Console.WriteLine();
                Console.WriteLine("4. Transaction History");
                Console.WriteLine();
                Console.WriteLine("5. Exit");
                Console.WriteLine();
                Console.Write("Enter your choice: ");
               

                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out int choice))
                {
                
                    // task 3
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine();
                            Console.WriteLine($"Your balance is: ${balance}");
                         
                            break;
                    // task 4
                        case 2:
                            Console.Write("Enter deposit amount: ");
                            if (int.TryParse(Console.ReadLine(), out int depositAmount) && depositAmount > 0)
                            {
                                balance += depositAmount;
                                Console.WriteLine();
                                transactionHistory[transactionCount] = $"Deposited ${depositAmount}";
                                Console.WriteLine();
                                transactionCount++;
                                Console.WriteLine();
                                Console.WriteLine($"Successfully deposited ${depositAmount}. New balance: ${balance}");
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Invalid deposit amount.");
                                Console.WriteLine();
                            }
                            break;
                        // task 5
                        case 3:
                            Console.Write("Enter withdrawal amount: ");
                            if (int.TryParse(Console.ReadLine(), out int withdrawAmount) && withdrawAmount > 0 && withdrawAmount <= balance)
                            {
                                balance -= withdrawAmount;
                                Console.WriteLine();
                                transactionHistory[transactionCount] = $"Withdrew ${withdrawAmount}";
                                Console.WriteLine();
                                transactionCount++;
                                Console.WriteLine();
                                Console.WriteLine($"Successfully withdrew ${withdrawAmount}. Your new balance is ${balance}.");
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Invalid withdrawal amount or insufficient balance.");
                                Console.WriteLine();
                            }
                            break;
                        // task 6
                        case 4:
                            Console.WriteLine();
                            Console.WriteLine("Transaction History:");
                            for (int i = 0; i < transactionCount; i++)
                            {
                                Console.WriteLine( transactionHistory[i] );
                                                      
                            }
                            if (transactionCount == 0)
                            {
                                Console.WriteLine(transactionHistory[1]);
                            }
                            break;
                        // task 7
                        case 5:
                            Console.WriteLine();
                            Console.WriteLine(" Exiting the Program...");
                            Console.WriteLine();
                            usingATM = false;
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter a number.");
                }
                Console.WriteLine();
            }
        }
    }
}
