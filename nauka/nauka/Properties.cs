using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nauka
{
    static class Properties
    {
        private static int x;

        public static int Prop
        {
            get { return x; }
            set 
            {
                if (value >= 0 && value <= 10)
                    x = value;
                else
                    x = 42;
            }
        }

    }
}
