using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nauka
{
    class Konstruktor
    {
        int y;
        public Konstruktor(int x, int z)
        {
            y = x + z;
        }
        public void Wyswietl()
        {
            Console.WriteLine("y = " + y);
        }

    }
}
