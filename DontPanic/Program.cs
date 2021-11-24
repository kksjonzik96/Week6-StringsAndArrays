using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab koik 'o' tahed lauses "Dont't Panic" nulliga - 0
            //programm asendab koik 'a' tahed samas laused 4-ga

            string panic = "Dont't Panic!";

            panic = panic.Replace('o', '0');
            panic = panic.Replace('a', '4');
            Console.WriteLine(panic);

        }
    }
}
