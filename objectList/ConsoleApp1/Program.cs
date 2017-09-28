using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List < object > typeBox = new List<object>();
            typeBox.Add(7);
            typeBox.Add(28);
            typeBox.Add(-1);
            typeBox.Add(true);
            typeBox.Add("Chair");

            foreach (object item in typeBox)
            {
                Console.WriteLine(item);
            }

            int sum = 0;
            foreach (object test in typeBox)
            {
                if (test is int)
                {
                    sum += (int)test;
                }
            }
            Console.WriteLine("The sum of all int object is: " + sum);
        }
    }
}