using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> ColorId = new Dictionary<string, int>();
            ColorId.Add("Red",1);
            ColorId.Add("Blue", 2);
            foreach (var color in ColorId)
            {
                Console.WriteLine(color);
            }
        }
    }
}
