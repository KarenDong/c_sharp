using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an array to hold integer values 0 through 9
            int[] smallint = new int[10];
            for (int i=0; i<10; i++)
            {
                smallint[i] = i;
            }
            foreach (int check1 in smallint)
            {
                Console.WriteLine("Item in Smallint: " + check1);
            }
            //Create an array of the names "Tim", "Martin", "Nikki", &"Sara"
            string[] smallstr = new string[4]
            {
                "Tim", "Martin", "Nikki", "Sara"
            };
            foreach(string check2 in smallstr)
            {
                Console.WriteLine("Item in Smallstr: " + check2);
            }
            //Create an array of length 10 that alternates between true and false values, starting with true
            bool[] smallbool = new bool[10];
            for (int j = 2; j < 12; j++)
            {
                if (j % 2 == 0)
                {
                    smallbool[j - 2] = false;
                }
                else
                {
                    smallbool[j - 2] = true;
                }
            }
            for (int k=0; k<10; k++)
            {
                Console.WriteLine("item {0}: {1}", k, smallbool[k]);
            }

            //Multiplication Table
            int[,] multi = new int[10,10];
            for (int x=0; x<10; x++)
            {
                for (int y=0; y<10; y++)
                {
                    multi[x,y] = (x + 1) * (y + 1);
                    Console.WriteLine((x+1)*(y+1));
                }
            }
            //Create a list of Ice Cream flavors that holds at least 5 different flavors(feel free to add more than 5!)
            List<string> flavor = new List<string>();
            flavor.Add("strawberry");
            flavor.Add("chocolate");
            flavor.Add("vanilla");
            flavor.Add("caramel");
            flavor.Add("mango");
            //Output the length of this list after building it
            Console.WriteLine(flavor.Count);
            //Output the third flavor in the list, then remove this value.
            Console.WriteLine(flavor[2]);
            flavor.RemoveAt(2);
            //Output the new length of the list
            Console.WriteLine(flavor.Count);
            foreach (string item in flavor)
            {
                Console.WriteLine(item);
            }

            //Create a Dictionary that will store both string keys as well as string values
            Dictionary<string, string> userInfo = new Dictionary<string, string>();
            //For each name in the array of names you made previously, add it as a new key in this dictionary with value null
            //For each name key, select a random flavor from the flavor list above and store it as the value
            Random assign = new Random();
            foreach (string name in smallstr)
            {
                userInfo[name] = flavor[assign.Next(flavor.Count)];
            }
            //Loop through the Dictionary and print out each user's name and their associated ice cream flavor
            foreach (var pair in userInfo)
            {
                Console.WriteLine(pair.Key + "-" + pair.Value);
            }
        }
    }
}