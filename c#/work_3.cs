// using System;
// using System.Collections.Generic;
// using System.Linq;

// namespace work_3
// {
//     class Refparameter
//     {
//     static void Calculate(ref int numValueOne, ref int numValueTwo)
//     {
//         numValueOne = numValueTwo * 2;
//         numValueTwo = numValueTwo / 2;
//     }
    
//         static void Main(string[] args)
//         {
//             int numOne = 10;
//             int numTwo = 20;
//             Console.WriteLine("Value of Num1 and Nun2 before calling method " +numOne + "," + numTwo);
//             Calculate(ref numOne, ref numTwo); 
//             Console.WriteLine("Value of Num1 and Num2 after calling method " +numOne + "," + numTwo);
//         }
//     }

// }