using System;

namespace HelloWorldReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab lauset "Hello, World!" tagurpidi

            string str = "Hello World!"; 
            string reverse = "";
            int length = str.Length - 1;

            while (length >= 0)
            {
                reverse += str[length];
                length--;
            }

            Console.WriteLine(reverse); ;
        }
    }
}
