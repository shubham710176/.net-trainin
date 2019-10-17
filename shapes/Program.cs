using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            
          

            int choice;
            Console.WriteLine("enter the choice for shape:");
            choice = int.Parse(Console.ReadLine());
            
            switch (choice)
            {
                case 1:

                    
                    Console.WriteLine("shape is cuboid");
                    shape1 s = new shape1();
                    Console.WriteLine("and volume is:" + s.getvolume());
                    break;
                case 2:
                    
                    Console.WriteLine("shape is rectangle");
                    shape1 c = new shape1();
                    Console.WriteLine("and area is:" + c.getrectarea());
                    break;
                case 3:
                    Console.WriteLine("shape is traingle");  
                    shape1 d = new shape1();
                    Console.WriteLine("and area is:" + d.gettrainglearea());
                    break;
                case 4:
                    
                    Console.WriteLine("shape is circle");
                    shape1 t = new shape1();
                    Console.WriteLine("and area is:" + t.getcirclearea());
                    break;
            }
            
            Console.ReadKey();


        }
    }
}
