using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using arrayLib;
using BiggestNumber;
using ClassLibrary1;
using MathArray;
namespace ConsoleRelease2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArraInt array = new ArraInt(10);

            Console.WriteLine(array.GetSum());

            Console.WriteLine(Massiv.GetSumOdd(array.GetArray()));

            FindClass instance = new FindClass();

            Console.WriteLine(instance.FindMax());

			Console.WriteLine("hello from D.Kurilo");
			Console.WriteLine("hello from D.Kurilo");

            Console.ReadKey();
        }
    }
}
