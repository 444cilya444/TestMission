using System;
using System.Linq;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arry = { 3, 12, 4, 10 };
            var orderedArry = arry.OrderBy(n => n);
            foreach (int i in orderedArry)
                Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
