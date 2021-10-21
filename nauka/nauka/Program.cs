using System;

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

    }
}
