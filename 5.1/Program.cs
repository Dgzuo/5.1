using System;
using System.Linq;
namespace _5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int n = r.Next(5, 30);
            int[] arr = new int[n];

            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(1, 200);
            }

            string result = string.Join(", ", arr);

            Console.WriteLine(result);
            Console.WriteLine("Min = " + Enumerable.Min(arr));
            Console.WriteLine("Max = " + Enumerable.Max(arr));
        }
    }
}
