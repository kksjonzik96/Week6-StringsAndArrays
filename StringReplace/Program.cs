using System;

namespace StringReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab koik 'o' tahed lauses "Hello World!" tarniga (*)

            string helloW = "Hello World!";

            /* for(int i = 0; i < helloW.Length; i++)
             {
                helloW[i] = '*'; // soned on muutumatu
            } */

            helloW = helloW.Replace('o', '*');
            helloW = helloW.Replace('!', '1');
            Console.WriteLine(helloW);
             
        }
    }
}
