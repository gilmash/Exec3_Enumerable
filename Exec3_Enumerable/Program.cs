using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec3_Enumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> source = Enumerable.Range(1, 10);                   
            foreach (var item in source)
            {
                Console.Write(item);
            }

            Console.WriteLine("\r\n");

            IEnumerable<int> items = Enumerable.Range(10, 5);
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }

        }
    }
}
