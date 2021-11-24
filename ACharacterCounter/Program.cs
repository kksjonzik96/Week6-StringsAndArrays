using System;

namespace ACharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutajal sisestada ees-ja perekonnanime
            //programm kuvab, mitu 'a' tahte on kasutaja ees-ja perekonnanimes kokku

            Console.WriteLine("sisesta eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("sisesta perekonnanimi:");
            string lastName = Console.ReadLine();

            string fullName = $"{firstName}{lastName}".ToLower();

            Console.WriteLine(fullName);

            int aCounter = 0;

            for (int i = 0; i < fullName.Length; i++)
            {
                if (fullName[i] == 'a')
                {
                    aCounter++;
                }
            }

            if(aCounter != 1)
            {
                Console.WriteLine($"Sinu taisnime on {aCounter} 'a' tahte.");
            }
            else
            {
                Console.WriteLine($"Sinu taisnime on {aCounter} 'a' tahte.");
            }    
           
        }
    }
}
