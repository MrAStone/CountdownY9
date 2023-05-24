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
            // shuffle large
            for(int i = 0; i < 1000; i++)
            {
                int a = r.Next(0, 4);
                int b = r.Next(0,4);
                int temp = large[a];
                large[a] = large[b];
                large[b] = temp;
            }
            // shuffle small
            for (int i = 0; i < 1000; i++)
            {
                int a = r.Next(0, 20);
                int b = r.Next(0, 20);
                int temp = small[a];
                small[a] = small[b];
                small[b] = temp;
            }
            int[] numbers = new int[6];
            int index = 0;
            for (int i = 0;i< largeCount;i++)
            {
                numbers[index++] = large[i];
            }
            for (int i = 0;i< smallCount;i++)
            {
                numbers[index++]= small[i];
            }
            foreach(int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            int numToGet = r.Next(100, 1000);
            Console.WriteLine(numToGet);
            Console.Write("Enter your answer: ");
            string answer = Console.ReadLine();
            string result = new DataTable().Compute(answer, "").ToString();
            Console.WriteLine(result);
            if(result == numToGet.ToString())
            {
                Console.WriteLine("WINNER");
            }
            else
            {
                Console.WriteLine("LOOSER!");
            }
        }
    }
}
