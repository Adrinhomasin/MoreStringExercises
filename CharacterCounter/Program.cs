using System;

namespace CharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kõsoib ksautajal sisestada ees ja perekonnanimi
            //programm kuvab kasutaja eesnime ja perekanoanni pikkust kokku
            //lenght omadust kasutamatta
            int counter = 0;
            Console.WriteLine("sisestage eesnimi");
            string firstname = Console.ReadLine();
            Console.WriteLine("sisestage perekonnanimi");
            string lastname = Console.ReadLine();

            string fullname = $"{firstname }{lastname}";
            foreach (char c in fullname)
            {
                counter++;
            }
            Console.WriteLine($"teie nimes on {counter} tähte");
        }
    }
}
