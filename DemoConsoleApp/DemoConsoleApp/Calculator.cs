﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleApp
{
    internal class Calculator
    {

        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void Subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        public void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        public void Divide(int a, int b)
        {
            Console.WriteLine(a / b);
        }

        public void Modulo(int a, int b)
        {
            Console.WriteLine(a % b);
        }
    }
}
