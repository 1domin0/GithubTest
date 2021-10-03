using System;

namespace gueess_the_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int x = rnd.Next(1, 10);
            int y = 0;
            while (y != x)
            {
                y = int.Parse(Console.ReadLine());
                if (y < x)
                {
                    Console.WriteLine("Number X is bigger");
                }
                if (y > x)
                {
                    Console.WriteLine("Nu,ber X is smaller");
                }
                if (y == x)
                {
                    Console.WriteLine("You guessed the number!");
                }
            }
        }
    }
}
