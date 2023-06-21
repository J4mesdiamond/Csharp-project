using System;
using System.Collections.Generic;
using System.Linq;

using System.Diagnostics;

namespace work_10
{
    public class MyClass
    {
        public static void Main(string[] args)
        {
        Console.WriteLine("Enter the application Name you wish to Close:");
        Process[] myProcList = Process.GetProcessesByName(Console.ReadLine());
        foreach (Process Target in myProcList)
        {
            Target.Kill();
        }
        }
    }
}