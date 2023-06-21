using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
public class Calculator
{
    public static void addition()
    {
    Console.WriteLine("Enter first number: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter second number: ");
    int b = Convert.ToInt32(Console.ReadLine());
    int result = a + b;
    Console.WriteLine("The sum of the {%d} and {%d} is {%d} ", a, b, result);
    }

    public static void multiply()
    {
    Console.WriteLine("Enter first number: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter second number: ");
    int b = Convert.ToInt32(Console.ReadLine());
      int result = a * b;
    Console.WriteLine("The sum of the {%d} and {%d} is {%d} ");
    }

    public static void sub()
    {
    Console.WriteLine("Enter first number: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter second number: ");
    int b = Convert.ToInt32(Console.ReadLine());
    int result = a - b;
    Console.WriteLine("The sub of" + a + "and" + b + "is" + result);
    }

    public static void div()
    {
    Console.WriteLine("Enter first number: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter second number: ");
    int b = Convert.ToInt32(Console.ReadLine());
    int result = a + b;
    Console.WriteLine("The div of" + a + "and" + b + "is" + result);
    }


    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Welcome to my world");
            Console.WriteLine("Enter a number btw 1 - 5");
            Console.WriteLine("\t 1. Addition");
            Console.WriteLine("\t 2. Multiplition");
            Console.WriteLine("\t 3. Subtraction");
            Console.WriteLine("\t 4. Division");
            Console.WriteLine("\t 5. Exit");
            int opt = Convert.ToInt32(Console.ReadLine());

            if (opt == 1)
            {
                addition();
            }
            else if (opt == 2)
            {
                multiply();
            }
            else if (opt == 3)
            {
                sub();
            }
            else if(opt == 4)
            {
                div();
            }
            else if(opt == 5)
            {
                break;
            }
        }
    }

    
}
}