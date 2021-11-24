using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis, mitu 'h', 'o' ja 'l' tahte on lauses "Hello World!

            string tekst = "Hello World!".ToLower();

            int hCounter = 0;
            int oCounter = 0;
            int lCounter = 0;

            for (int i = 0; i < tekst.Length; i++)
            {
                if (tekst[i] == 'h')
                {
                    hCounter++;
                }
                if (tekst[i] == 'o')
                {
                    oCounter++;
                }
                if (tekst[i] == 'l')
                {
                    lCounter++;
                }
            }

            if (hCounter >= 1 || oCounter >= 1 || lCounter >= 1)
            {
                Console.WriteLine($"Tekstis {hCounter} 'h' tahte.");
                Console.WriteLine($"Tekstis {oCounter} 'o' tahte.");
                Console.WriteLine($"Tekstis {lCounter} 'l' tahte.");
            }
            
        }
    }
}
