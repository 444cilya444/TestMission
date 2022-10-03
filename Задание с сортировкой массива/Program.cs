using System;
using System.Linq;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Массив состоящий из целочисленных данных");
            int[] arryInputInt = { 3, 12, 4, 10 };
            int[] arryOutputInt = SortArry(arryInputInt);
            foreach (var item in arryOutputInt)
                Console.Write(item + " ");

            Console.WriteLine("\nМассив состоящий из строковых данных");
            string[] arryInputStr = { "z", "1", "Арбуз", "x", "2" };
            string[] arryOutputStr = SortArry(arryInputStr);
            foreach (var item in arryOutputStr)
                Console.Write(item + " ");
            Console.ReadKey();
        }
        static TArry[] SortArry<TArry>(TArry[] arry)
        {
            var orderedArry = arry.OrderBy(n => n).ToArray(); ;
            return orderedArry;
        }
    }
}
