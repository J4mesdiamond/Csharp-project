using System;
using System.Collections.Generic;
using System.Linq;

namespace work_9
{
    public class MyClass
    {
         static void Main(string[] args)
        {
            for (int j = 0; j < 10; j++)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write("*  ");
            }
            Console.WriteLine();
        }

            string x;
            int y;
            int price;
            Double prices;
            Double pricess;
            int pricesss;

            Console.WriteLine("Enter last name: ");
            x = Console.ReadLine();
            Console.WriteLine("Enter number of mini pies: ");
            y = Convert.ToInt32(Console.ReadLine());
       price = y * 4;
       prices =  3.50;
       pricess = 3.25;
       pricesss =  3;


      if (y > 0)
            {
                Console.WriteLine("Dear {0} your price is {1} "  ,x , price);

                if (y <= 4 & y != 1)
                {
                    Console.WriteLine("Dear {0} your price is {1} "  ,x , prices);
                }  
                if (y < 8 & y > 4)
                {
                    Console.WriteLine("Dear {0} your price is {1} "  ,x , pricess);
                }  
                if (y >= 8)
                {
                Console.WriteLine("Dear {0} your price is {1} "  ,x , pricesss);
                }  
          else
          {
               Console.WriteLine("Please choose from 1 and above");
          }      

 }
          


        int x,y;
        x = Convert.ToInt32(Console.ReadLine());
        y = Convert.ToInt32(Console.ReadLine());
        if ((2 * 3) > y)
        {
            if (y > x)
            {
                Console.WriteLine("Loc 1");
                else if(x < 0)
                {
                    Console.WriteLine("Loc 2");
              
                else
                {
                    Console.WriteLine("Loc 3");
                }  }
                else
                {
                    Console.WriteLine("Loc 4");
                }
            }
        }

        }
    }    
}
