using System;

namespace Uppgift_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in lönen på 3 av dina anställda");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());

            double summa = (x + y + z) / 3;
            Console.WriteLine("Medellönen för din personal är " + summa);
        }
    }
}

