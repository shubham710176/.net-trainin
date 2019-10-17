using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
     class  shape1
    {
        public double height;
        public double length;
        public double breadth;
        public double radius;
        public shape1()
        {
            this.height = height;
            this.length = length;
            this.breadth = breadth;
            this.radius = radius;

        }
        public double getvolume()
        {
            length = double.Parse(Console.ReadLine());
            breadth = double.Parse(Console.ReadLine());
            height = double.Parse(Console.ReadLine());
            return length * breadth * height;
        }
        public double getrectarea()
        {
            length = double.Parse(Console.ReadLine());
            breadth = double.Parse(Console.ReadLine());
            return length * breadth;
        }
        public double gettrainglearea()
        {
            breadth = double.Parse(Console.ReadLine());
            height = double.Parse(Console.ReadLine());
            return 0.5 *breadth* height;
        }
        public double getcirclearea()
        {
            radius= double.Parse(Console.ReadLine());
            return 3.14 * radius * radius;
        }
    }
}
