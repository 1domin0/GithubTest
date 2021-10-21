using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nauka
{
    static class GenerowanieTekstu
    {
        public static string WyswietlTekst(string tekst, params object[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                tekst = tekst.Replace("#" + i, args[i].ToString());
            }
            return tekst;
        }
    }
}
