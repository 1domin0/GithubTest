using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Text;

namespace nauka
{
    class Program
    {

        static void Main(string[] args)
        {
            int x = 10; int z = 20;
            Console.WriteLine($"x = {x} z = {z}");
            
            Konstruktory();
            Klasy();
            Console.WriteLine(GenerowanieTekstu.WyswietlTekst("Mam na imie #0 i mam #1 lat", "Dominik", 17));
            Properties();
            StringBuilderTest(1000000);
            CreateNewCulture();

            Console.ReadKey();
        }
        static void Konstruktory()
        {
            int x = 10;
            int z = 20;
            Konstruktor konstruktor = new Konstruktor(x, z);
            konstruktor.Wyswietl();
        }
        static void Klasy()
        {
            //Klasy niestatyczne
            Niestatyczna klasaNieStatyczna1 = new Niestatyczna();
            Niestatyczna klasaNieStatyczna2 = new Niestatyczna();
            klasaNieStatyczna2.x = 2;
            Console.WriteLine("");
            Console.WriteLine("Statyczna1: " + klasaNieStatyczna1.NiestatycznaTest());
            Console.WriteLine("Statyczna2: " + klasaNieStatyczna2.NiestatycznaTest());

            //klasy statyczne
            Console.WriteLine(Statyczna.StatycznaTest());
            Statyczna.z = 210321;
            Console.WriteLine(Statyczna.StatycznaTest());
            Console.WriteLine("");
        }
        static void Properties()
        {
            Properties props = new Properties();
            props.Prop = 11;
            Console.WriteLine("");
            Console.WriteLine($"Properties {props.Prop}");
            Console.WriteLine("");
        }
        static void StringBuilderTest(int numberOfLoops)
        {
            string tekst1 = "tekst1: ";
            string tekst2 = "tekst2: ";
            int loops = numberOfLoops;

            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();
            for (int i = 0; i < numberOfLoops; i++)
            {
                tekst1 = tekst1 + i;
            }
            stopWatch.Stop();
            Console.WriteLine("Tekst1: " + stopWatch.ElapsedMilliseconds + "ms");
            stopWatch.Reset();

            stopWatch.Start();
            StringBuilder newStringBuilder = new StringBuilder();
            for (int i = 0; i < numberOfLoops; i++)
            {
                newStringBuilder.Append(i);
            }
            stopWatch.Stop();
            Console.WriteLine("Tekst2: " + stopWatch.ElapsedMilliseconds + "ms");
            stopWatch.Reset();

            Console.WriteLine("");
        }
        static void CreateNewCulture()
        {
            string str = "123";
            float npint = float.Parse(str) + 2.23f;
            var newCulture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            newCulture.DateTimeFormat.ShortDatePattern = "D/m/yyyy";
            newCulture.NumberFormat.NumberDecimalSeparator = "*";

            Console.WriteLine(npint);
            Console.WriteLine(CultureInfo.CurrentCulture.Name);
            Console.WriteLine(CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern);

            CultureInfo.CurrentCulture = newCulture;
 
            Console.WriteLine(npint);
            Console.WriteLine(CultureInfo.CurrentCulture.Name);
            Console.WriteLine(CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern);

            CultureInfo.CurrentCulture = new CultureInfo("en-US", false);

            Console.WriteLine("");
        }

    }
}
