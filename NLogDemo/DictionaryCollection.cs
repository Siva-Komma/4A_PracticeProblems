using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace NLogDemo
{
    internal class DictionaryCollection
    {
        public static void  DCollection() 
        {
            Dictionary<int, string> dist = new Dictionary<int, string>();
            dist.Add(1, "siva");
            dist.Add(2, "Hari");
            dist.Add(3, "Sai");
            Console.WriteLine("Displaying Distionary values");
            foreach(var key in dist.Keys)
            {
                Console.WriteLine(key);
            }
            foreach (var value in dist.Values)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("\n");
            Console.WriteLine("After Adding Distionary values");
            dist.Add(4, "Komma");
            foreach (var key in dist.Keys)
            {
                Console.WriteLine(key);
            }
            foreach (var value in dist.Values)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("\n");
            Console.WriteLine("After deleting Distionary values");
            dist.Remove(3);
            foreach (var key in dist.Keys)
            {
                Console.WriteLine(key);
            }
            foreach (var value in dist.Values)
            {
                Console.WriteLine(value);
            }

        }
    }
}
