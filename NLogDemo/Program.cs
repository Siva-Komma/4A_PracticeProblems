﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            AddNumbers num = new AddNumbers();
            num.Sum(10, 20);
            Console.ReadLine();
        }
    }
}
