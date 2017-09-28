using System;
using System.Collections.Generic;

namespace functions
{
    class Program
    {
        //Print 1-255
        static void sum(int num)
        {
            int sum1 = 0;
            for (int i=1; i<=num; i++)
            {
                sum1 = sum1 + i;
            }
            Console.WriteLine("Sum from 1 to {0} is {1}",num,sum1);
        }  
        //Print odd numbers between 1-255
        static void sumOdd(int num)
        {
            int sum2 = 0;
            for (int i=1; i<=num; i++)
            {
                if (i%2 != 0)
                {
                    sum2 = sum2 + i;
                }
            }
            Console.WriteLine("Sum of odd number from 1 to {0} is {1}", num, sum2);
        }
        //Print Sum and each items
        static void sumPrint(int num)
        {
            int sum3 = 0;
            for (int i = 1; i <= num; i++)
            {
                sum3 = sum3 + i;
                Console.WriteLine("Number added: {0}; Sum: {1}", i, sum3);
            }
        }
        //Iterating through an Array
        static void arrPrint(int[] x)
        {
            for (int i=0; i< x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }
        }
        //Write a program that takes any array and prints the maximum value in the array.
        static void printMax(int[] y)
        {
            int max = y[0];
            for (int i = 0; i < y.Length; i++)
            {
                if (max < y[i])
                {
                    max = y[i];
                }
            }
            Console.WriteLine("The max number in this array is {0}", max);         
        }
        // Print the average
        static void printAvg(int[] z)
        {
            int sum = 0;
            foreach (int number in z)
            {
                sum = sum + number;
            }
            int len = z.Length;
            Console.WriteLine("The average number in this array is {0}", sum/len);
        }
        //Write a program that creates an array 'y' that contains all the odd numbers between 1 to 255
        static void oddArr(int a)
        {
            List<int> y = new List<int>();
            for (int i=0; i<=a; i++)
            {
                if (i%2 != 0)
                {
                    y.Add(i);
                }
            }
            Console.WriteLine("New Array - y:");
            foreach(int j in y)
            {
                Console.WriteLine(j);
            }
        }
        //Write a program that takes an array and returns the number of values in that array whose value is greater than a given value y. 
        static void compare(int[] arr, int y)
        {
            int counter = 0;
            foreach (int i in arr)
            {
                if (i>y)
                {
                    counter++;
                }
            }
            Console.WriteLine("{0} elements in array is greater than {1}", counter, y);
        }
        //create an algorithm (sets of instructions) that multiplies each value in the array by itself
        static void square(int[] a)
        {
            for (int i=0;i<a.Length;i++)
            {
                int num = a[i];
                a[i] = num * num;
            }
            foreach(int J in a)
            {
                Console.WriteLine(J);
            }
        }
        //create an algorithm that replaces any negative number with the value of 0
        static void replaceNeg(int[] a)
        {
            Console.WriteLine("Original Array:");
            foreach (int j in a)
            {
                Console.WriteLine(j);
            }
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i]<0)
                {
                    a[i] = 0;
                }
            }
            Console.WriteLine("New Array:");
            foreach (int j in a)
            {
                Console.WriteLine(j);
            }
        }
        //create an algorithm that prints the maximum number in the array, the minimum value in the array, and the average of the values in the array.
        static void stat(int[] x)
        {
            printMax(x);
            Console.WriteLine();
            int b = x[0];
            foreach (int a in x)
            {
                if(b>a)
                {
                    b = a;
                }
            }
            Console.WriteLine("Min number in Array is"+b);
            printAvg(x);
        }
        //create an algorithm that shifts each number by one to the front and adds '0' to the end
        static void shift(int[] x)
        {
            Console.WriteLine("Original Array:");
            foreach (int j in x)
            {
                Console.WriteLine(j);
            }
            for (int i=0;i<x.Length;i++)
            {
                if (i<x.Length-1)
                {
                    int num = x[i + 1];
                    x[i] = num;
                }
                else
                {
                    x[i] = 0;
                }
            }
            Console.WriteLine("New Array:");
            foreach (int j in x)
            {
                Console.WriteLine(j);
            }
        }
        //Write a program that takes an array of numbers and replaces any negative number with the string 'Dojo'.
        public static object[] toString(object[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if ((int)arr[i] < 0)
                {
                    arr[i] = "Dojo";
                }
            }
            return arr;
        }
        static void Main(string[] args)
        {
            //Print 1-255
            sum(255);
            //Print odd numbers between 1-255
            sumOdd(255);
            //Print Sum and each items
            sumPrint(255);
            //Iterating through an Array
            int[] x = { 1, 3, 5, 7, 9, 13 };
            arrPrint(x);
            //Write a program that takes any array and prints the maximum value in the array.
            int[] y = { -3, -5, -7 };
            printMax(y);
            //print the avg
            int[] z = { 2, 10, 3 };
            printAvg(z);
            //Write a program that creates an array 'y' that contains all the odd numbers between 1 to 255
            oddArr(225);
            //Write a program that takes an array and returns the number of values in that array whose value is greater than a given value y.
            int[] arr1 = { 1, 3, 5, 7 };
            compare(arr1, 3);
            //create an algorithm (sets of instructions) that multiplies each value in the array by itself
            Console.WriteLine("New Array Elements:");
            int[] arr2 = { 1, 5, 10, -2 };
            square(arr2);
            //create an algorithm that replaces any negative number with the value of 0
            int[] arr3 = { 1, 5, 10, -2 };
            replaceNeg(arr3);
            //create an algorithm that prints the maximum number in the array, the minimum value in the array, and the average of the values in the array.
            int[] arr4 = { 1, 5, 10, -2 };
            stat(arr4);
            //create an algorithm that shifts each number by one to the front and adds '0' to the end
            int[] arr5 = { 1, 5, 10, 7, -2 };
            shift(arr5);
            //Write a program that takes an array of numbers and replaces any negative number with the string 'Dojo'.
            Console.WriteLine("New array after replacement!");
            object[] arr6 = {2, -1, -3, 2};
            toString(arr6);
            foreach (object print in arr6)
            {
                Console.WriteLine(print);
            }
        }
    }
}