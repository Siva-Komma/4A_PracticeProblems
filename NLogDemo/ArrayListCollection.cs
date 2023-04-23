using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogDemo
{
    class ArrayListCollection
    {
        public static void Collection()
        {
            ArrayList list = new ArrayList();
            list.Add("Hi");
            list.Add(1);
            list.Add(2);
            list.Add("HWR");
            list.Add(3);
            foreach(var data in list)
            {
                Console.WriteLine("Printing array list elements"+data);
            }
            Console.WriteLine("\n");
            list.Insert(3, 10);
            foreach (var data in list)
            {
                Console.WriteLine("Printing after inserting array elemen" + data);
            }
            Console.WriteLine("\n");
            list.Remove(10);
            foreach (var data in list)
            {
                Console.WriteLine("Printing after deleting array elemen" + data);
            }
        }
    }
}
