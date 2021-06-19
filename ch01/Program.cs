using System;
using System.Collections.Generic;
using System.Linq;

namespace ch01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Triples();
            // NoMutation();
            // ListWithMutableSort();
            LinqExample();
        }

        private static void Triples()
        {
            Func<int, int> triple = x => 3 * x;
            var range = Enumerable.Range(1, 3);
            var triples = range.Select(triple);
            foreach (var x in triples)
            {
                Console.WriteLine(x);
            }
        }
        private static void NoMutation()
        {
            Func<int, bool> isOdd = x => x % 2 == 1;
            int[] original = {7, 6, 1};
            var sorted = original.OrderBy(x => x);
            var filtered = original.Where(isOdd);
            Console.WriteLine(string.Join(',', original));
            Console.WriteLine(string.Join(',', sorted));
            Console.WriteLine(string.Join(',', filtered));
        }
        private static void ListWithMutableSort()
        {
            var original = new List<int> {5, 7, 1};
            Console.WriteLine(string.Join(',', original));
            original.Sort();
            Console.WriteLine(string.Join(',', original));
        }
        private static void LinqExample()
        {
            var query = Enumerable.Range(1, 100)
                                  .Where(x => x % 20 == 0)
                                  .OrderBy( x => -x)
                                  .Select(x => $"\"{x}%\"");
            Console.WriteLine($"[{string.Join(", ", query)}]");
        }
    }
}
