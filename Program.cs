using System;
using System.Threading;

namespace GPOUP2NEWPROJECT
{
    internal class Program
    {
        public static void Main()
        {
            int option;

            do
            {
                Console.Clear();
                Console.WriteLine("Please select an option");
                Console.WriteLine("1. Task 1");
                Console.WriteLine("2. Task 2");
                Console.WriteLine("3. Task 3");
                Console.WriteLine("4. Task 4");
                Console.WriteLine("0. Exit");

                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        one();
                        break;
                    case 2:

                        two();
                        break;
                    case 3:

                        three();
                        break;
                    case 4:

                        four();
                        break;
                    case 0:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Please enter valid number");
                        Thread.Sleep(2000);
                        break;
                }
            } while (option != 0);

        }
    }
}
