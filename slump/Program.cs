using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slump
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int sum = 0;
            int[] tal = new int[10];
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                
                
                 tal[i] = rand.Next(1, 21);
                sum += tal[i];
                Console.Write(tal[i]+" ");



            }
            Console.WriteLine("medelvärdet blir: "+sum/tal.Length);
            */

            
            int[] tal = new int[20];
            Random rand = new Random();
            for (int i = 0; i < 20; i++)
            {


                tal[i] = rand.Next(15, 31);
                
               



            }
            
            
            Array.Sort(tal);
            for (int z = 0; z < tal.Length; z++)
            {
                Console.Write(tal[z]+" ");
                if (z==tal.Length/2-1)
                {
                    Console.Write(":" +" ");
                }

            }
             double min=tal[tal.Length/2-1];
            double max = tal[tal.Length/2];
            Console.WriteLine();
            Console.WriteLine((min + max) / 2);
            
            




            Console.ReadKey();
        }
    }
}
