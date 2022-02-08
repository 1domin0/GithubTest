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
            int[,,] tablice = new int[10,2,5];
            int x = 10; int z = 20;
            Console.WriteLine($"x = {x} z = {z}");
            Console.WriteLine("");
            
            Konstruktory();

            Klasy();

            Console.WriteLine(GenerowanieTekstu.WyswietlTekst("Mam na imie #0 i mam #1 lat", "Dominik", 17));

            Props();

            MyStringBuilder.StringBuilderTest(1000);

            NewCulture.ShowNewCulture();

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
        static void Props()
        {
            Properties.Prop = 11;
            Console.WriteLine("");
            Console.WriteLine($"Properties {Properties.Prop}");
            Console.WriteLine("");
        }
    }
}
