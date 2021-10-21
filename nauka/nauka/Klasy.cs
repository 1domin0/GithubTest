using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nauka
{
    public class Niestatyczna
    {
        public int x = 10;
        public string NiestatycznaTest()
        {
            return "Klasa statyczna. X =  " + x;
        }
    }

    static class Statyczna
    {
        public static int z = 20;
        public static string StatycznaTest()
        {
            return "Klasa niestatyczna. Z = " + z;
        }
    }
}
