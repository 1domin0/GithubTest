using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nauka
{
    static class NewCulture
    {
        public static void CreateNewCulture()
        {
            var newCulture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            CultureInfo.CurrentCulture = newCulture;
            newCulture.DateTimeFormat.ShortDatePattern = "D/m/yyyy";
            newCulture.NumberFormat.NumberDecimalSeparator = "*";
        }
        public static void ShowNewCulture()
        {
            string str = "123";
            float x = float.Parse(str) + 2.23f;

            Console.WriteLine(x);
            Console.WriteLine(CultureInfo.CurrentCulture.Name);
            Console.WriteLine(CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern);

            CreateNewCulture();
            Console.WriteLine(x);
            Console.WriteLine(CultureInfo.CurrentCulture.Name);
            Console.WriteLine(CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern);

            CultureInfo.CurrentCulture = new CultureInfo("en-US", false);

            Console.WriteLine("");
        }
    }
}
