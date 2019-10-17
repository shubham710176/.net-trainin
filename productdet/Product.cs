using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productdet
{
    class Product
    {
        public string name;
        public double price;
        public double quantity;
        public Product()
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }
        public double genbill()
        {
            return price * quantity;
        }
    }
}
