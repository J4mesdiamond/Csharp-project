// using System;
// using System.Collections.Generic;
// using System.Linq;

// namespace work_6
// {
//     public class MyClass
//     {
//         public static void Main(string[] args)
//         {
//             // Fibonachi firstly we need to add up the first two numbers and put them in a loop 
//             Console.WriteLine("Enter some number to stop it:");
//             int num = int.Parse(Console.ReadLine());

//             int first = 1;
//             Console.WriteLine("{0}",first);
//             int second = 1;
//             Console.WriteLine("{0}",second);
//             int sum = 0;

//             while (sum <= num)
//             {
                 
//                 sum =  first + second;
//                 Console.WriteLine("{0}",sum);

//                 first = second;
//                 second = sum;

//             }

//         }
//     }
// }