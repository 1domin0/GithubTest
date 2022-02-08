using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nauka
{
    static class MyStringBuilder
    {
        public static void StringBuilderTest(int numberOfLoops)
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
    }
}
