using System;

namespace WordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloW = "Hello World!";

            /*int i = 0;*/
            int counter = 1;
            /*while (i < helloW.Length)
            {
                if(helloW[i] == ' ')
                {
                    counter++;
                }
                i++;
            }
            Console.WriteLine($"teie lauses on {helloW} on {counter} sõna");*/
            for (int i = 0; i < helloW.Length;) 
            {
                if(helloW[i] == ' ')
                {
                    counter++;  
                }
                Console.WriteLine($"teie lauses on {helloW} on {counter} sõna");
            }
            
        }
    }
}
