using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountdownY9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r=new Random();
            string e = "3*4/2";
            string result = new DataTable().Compute(e,"").ToString();
            Console.WriteLine(result);
            int[] large = new int[] { 100, 75, 50, 25 };
            int[] small = new int[20];
            int n = 1;
            for (int i = 0; i < small.Length; i+=2)
            {
                small[i] = n;
                small[i+1] = n;
                n++;
            }
            int largeCount=0;
            int smallCount=0;
            while(largeCount +  smallCount != 6)
            {
                Console.Write("How many large: ");
                largeCount = Convert.ToInt32(Console.ReadLine());
                Console.Write("How many small: ");
                smallCount = Convert.ToInt32(Console.ReadLine());
                if (largeCount > 4)
                {
                    Console.WriteLine("There are only 4 large numbers!");
                }
                else
                {
                    if (largeCount + smallCount != 6) { Console.WriteLine("You must have 6 numbers only"); }
                }
            }

        }
    }
}
