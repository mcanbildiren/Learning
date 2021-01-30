using System;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 30;
            num1 = num2;
            num2 = 65;
            Console.WriteLine(num1); //30

            int[] numbers1 = new int[] { 10, 20, 30 };
            int[] numbers2 = new int[] { 100, 200, 300 };
            numbers1 = numbers2;
            numbers2[0] = 999;
            Console.WriteLine(numbers1[0]); //999


        }
    }
}
