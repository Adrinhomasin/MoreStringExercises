using System;

namespace ForEachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab sõna "hellow world!" pikkust lenght omaduse kasutamatta
            string helloW = "hello world!";
            int counter = 0;

            foreach (char c in helloW) 
            {
                counter++;
            }
            Console.WriteLine($"lause {helloW} on {counter} tähte pikk");

        }
    }
}
