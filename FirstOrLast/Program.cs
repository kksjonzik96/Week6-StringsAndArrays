using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutajal sisestada ees-ja perekonnanume
            //origramm kontrollib andmete pikkus
            //programm kuvab kumb nendes on pikem, kas ees-voi perekonnanimi

            Console.WriteLine("sisesta eesnimi:");
            string firstName = Console.ReadLine();

            Console.WriteLine("sisesta perekonnanimi:");
            string lastName = Console.ReadLine();


            int firstNameLength = firstName.Length;
            int lastNameLength = lastName.Length;

            if(firstNameLength > lastNameLength)
            {
                Console.WriteLine($"Sinu eesnimes on {firstNameLength} sumbolit. Ehk pikkem, kui perekonnanimi.");
            }
            else if (firstNameLength < lastNameLength)
            {
                Console.WriteLine($"Sinu perekonnanimes on {lastNameLength} sumbolit. Ehk pikkem, kui eesnimi.");
            }
            
        }
    }
}
