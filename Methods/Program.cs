using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
      

            Product product1 = new Product();
            product1.Name = "Apple";
            product1.Price = 15;
            product1.Description = "Amasya";

            Product product2 = new Product();
            product2.Name = "Watermelon";
            product2.Price = 80;
            product2.Description = "Diyarbakir";

            Product[] urunler = new Product[] {product1,product2 };

            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Name);
                Console.WriteLine(urun.Price);
                Console.WriteLine(urun.Description);
                Console.WriteLine("-----------");


            }

            Console.WriteLine("-----Methods-----");

            CartManager cartManager = new CartManager();
            cartManager.Add(product2);
            cartManager.Add(product1);

            cartManager.Add2("Armut","Yeşil armut",12,5);
            cartManager.Add2("Elma", "Yeşil elma", 12,5);
            cartManager.Add2("karpuz", "Diyarbakır", 12,5);

        }
    }
}
