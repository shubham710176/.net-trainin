using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productdet
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("ENTER THE ITEM YOU WANT TO BUY");
            int choice;
            
            choice = int.Parse(Console.ReadLine());
            Product p = new Product();
            switch (choice)
            {
                case 1:
                    p.name = "nike";
                    p.price = 2000;
                    p.quantity = 20;
                    Console.WriteLine("this is nike shoes:");
                    
                    Console.WriteLine("the bill is"+p.genbill());
                    break;
                case 2:
                    p.name = "puma";
                    p.price = 1000;
                    p.quantity = 20;
                    Console.WriteLine("this is puma shoes:");
                    
                    Console.WriteLine("the bill is" + p.genbill());
                    break;
                case 3:
                    p.name = "adidas";
                    p.price = 1500;
                    p.quantity = 20;
                    Console.WriteLine("this is adidas shoes:");
                    
                    Console.WriteLine("the bill is" + p.genbill());
                    break;
           }
            Console.WriteLine("do you want to add more items");
            string ch = Console.ReadLine();
                if (ch == "y") 
            {
                Console.WriteLine("ENTER THE ITEM YOU WANT TO BUY");
                goto Newitem;

            }
            else {
                Console.WriteLine("total price" + p.genbill());
            }


            Newitem:
            int choice1;

            choice1 = int.Parse(Console.ReadLine());
            switch (choice1)
                {
                    case 1:
                        p.name = "nike";
                        p.price = 2000;
                        p.quantity = 20;
                        Console.WriteLine("this is nike shoes:");

                        Console.WriteLine("the bill is" + p.genbill());
                        break;
                    case 2:
                        p.name = "puma";
                        p.price = 1000;
                        p.quantity = 20;
                        Console.WriteLine("this is puma shoes:");

                        Console.WriteLine("the bill is" + p.genbill());
                        break;
                    case 3:
                        p.name = "adidas";
                        p.price = 1500;
                        p.quantity = 20;
                        Console.WriteLine("this is adidas shoes:");

                        Console.WriteLine("the bill is" + p.genbill());
                        break;
                }
                Console.WriteLine("do you want to add more items");
                string ch1 = Console.ReadLine();
                if (ch1 == "y")
                {
                    goto Newitem;

                }
                else
                {
                    Console.WriteLine("total price" + p.genbill());
                }
            Console.ReadKey();
        }
    }
}
