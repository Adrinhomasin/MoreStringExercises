using System;

namespace SubstituteCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib ees ja perekonnanime
            //programm asendab kõik 'a' tähed '*'
            //programm kuvab tulemust konsoioolis
            Console.WriteLine("sisesta oma eesnimi");
            string firstname = Console.ReadLine();
            Console.WriteLine("sisesta oma perekonnanimi");
            string lastname = Console.ReadLine();

            string fullname = $"{firstname}{lastname}";
            fullname = fullname.Replace('a', '*');
            Console.WriteLine($"{fullname}");
        }
    }
}
