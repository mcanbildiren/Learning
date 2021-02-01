using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.CustomerId = 1;
            musteri.CustomerName = "Can";
            musteri.CustomerSurname = "Bildiren";
            musteri.CustomerBalance = 100;

            MusteriManager musteri1 = new MusteriManager();
            musteri1.Add(musteri);
        }
    }
}
