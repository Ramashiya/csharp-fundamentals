using System;
using System.Diagnostics.CodeAnalysis;
namespace CsharpProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Password = "admin123";
            string PasswordCheck;
            int attempt = 3;
            bool accessGranted = false;
            while (attempt > 0) {
                Console.Write("Enter password: ");
                PasswordCheck = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(PasswordCheck)) { 
                    Console.WriteLine("Password cannot be empty");
                    continue;
                }
                if(PasswordCheck == Password)
                { 
                    accessGranted = true;
                    Console.WriteLine("Access Granted");
                    break;

                }
                else {
                    attempt--;
                    Console.WriteLine($"Access denied Incorrect password,left with {attempt} attemps");
                }

            } if (!accessGranted) {
                Console.WriteLine("Account blocked");
            }
            int Menu;
            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Print numbers 1 to N");
                Console.WriteLine("2. Calculate sum 1 to N");
                Console.WriteLine("3. Exit");
                Console.Write("Choose Menu(1-3): ");
                bool isValidMenu = int.TryParse(Console.ReadLine(), out Menu);


                if(!isValidMenu || Menu < 1 || Menu > 3)
                {
                    Console.WriteLine("Incorrect Input");
                    continue;
                }
                if(Menu == 3)
                {
                    Console.WriteLine("Exiting...");
                    break;
                }else if(Menu == 1) {
                    int Number;
                    Console.Write("Enter a number: ");
                    bool isValidNumber = int.TryParse(Console.ReadLine(), out Number);
                    if (!isValidNumber || Number <= 0)
                    {
                        Console.WriteLine("Incorrect Input");
                        continue;
                    }
                    PrintNumber(Number);
                }
                else
                {
                    int N;
                    Console.Write("Enter number: ");
                    bool isValidN = int.TryParse(Console.ReadLine(), out N);
                    if(!isValidMenu || N <= 0)
                    {
                        Console.WriteLine("Incorrect Input, enter correct number ");
                        continue;
                    }
                    Console.WriteLine($"The sum is {SumNumbers(N)}");
                }
                
            }


        }

        static void PrintNumber(int N)
        {
            for(int i = 1; i <= N; i++)
            {
                Console.WriteLine(i);
            }
        }
        static int SumNumbers(int N) { 
        int sum = 0;
            for (int i = 1;i<N;i++)
            {
                sum += i;
            }
            return sum;
        }

    }
}
