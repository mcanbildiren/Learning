using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class CartManager
    {
        public void Add(Product urun)
        {
            Console.WriteLine("Sepete Eklendi: " + urun.Name);
        }
        public void Add2(string Name, string Description, double Price,int stockA)
        {
            Console.WriteLine("Sepete Eklendi: " + Name);
        }
    }
}
