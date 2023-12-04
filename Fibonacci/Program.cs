using System;
using System.Collections;

class Program
{
    static void Main()
    {
        int result = CalcFibonacci(2);
        Console.WriteLine(result);
        int option;

        do {
            ShowOption();
            option = RequestOption();

            switch (option) {
                case 1:
                    Console.WriteLine("");
                    Console.Write("Input n value: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"F{n} = {CalcFibonacci(n)}");
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.Write("Input n value: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    bool calcResult = CalcIfFibo(num);
                    if (calcResult)
                    {
                        Console.WriteLine("******************************************");
                        Console.WriteLine($"{num} is a Fibonacci number");
                        Console.WriteLine("******************************************");
                    }
                    else
                    {
                        Console.WriteLine("******************************************");
                        Console.WriteLine($"{num} is not a Fibonacci number");
                        Console.WriteLine("******************************************");
                    }
                    break;
                case 3:
                    Console.Write("Input n value: ");
                    int y = Convert.ToInt32(Console.ReadLine());
                    Console.Write($"The first {y} numbers of Fibonacci are: ");
                    for (int i = 0; i < y; i++)
                    {
                        Console.Write($"{CalcFibonacci(i)} ");
                    }
                    Console.WriteLine();
                    break;


                default:
                    
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }

    } while (option != 4);
}

    static int CalcFibonacci(int k)
    {
        if (k == 0 || k == 1)
        {
            return k;
        }
        else if (k >= 2)
        {
            return CalcFibonacci(k - 1) + CalcFibonacci(k - 2);
        }
        else
        {
            return -1;
        }
    }

    static bool CalcIfFibo(int k)
    {
        for (int n = 0; CalcFibonacci(n) <= k; n++)
        {
            if (CalcFibonacci(n) == k)
            {
                return true;
            }
        }
        return false;
    }

    static void ShowOption() 
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Calculate Fn Fibonacci");
        Console.WriteLine("2. Is my number a Fibonacci number?");
        Console.WriteLine("3. My Fibonacci n number sequence");
        Console.WriteLine("4. Exit");
    }

    static int RequestOption() {
        Console.Write("Elige una opción: ");
        return Convert.ToInt32(Console.ReadLine());
    }
    
}
