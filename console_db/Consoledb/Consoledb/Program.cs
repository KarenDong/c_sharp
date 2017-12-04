using System;
using System.Collections.Generic;
using DbConnection;

namespace Consoledb
{
    class Program
    {
        // read all records in User table
        public static void Read()
        {
            List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();
            result = DbConnector.Query("SELECT * from user");
            foreach (Dictionary<string, object> individual in result)
            {
                Console.WriteLine("ID: {3}; Name: {0} {1}; Favourite Number: {2}", individual["FirstName"], individual["LastName"], individual["FavouriteNumber"], individual["id"]);
            }
        }


        // create new user
        public static void Create_new(String first_n, String last_n, int fav_n)
        {
            DbConnector.Execute("INSERT INTO user (FirstName, LastName, FavouriteNumber) VALUES ('first_n', 'last_n', 'fav_n')");
            Console.WriteLine("User {0} {1} is created!", first_n, last_n);
        }

        // create new user with inputs
        public static void Create()
        {
            Console.WriteLine("Please enter first name:");
            string first_n = Console.ReadLine();
            Console.WriteLine("Please enter last name:");
            string last_n = Console.ReadLine();
            Console.WriteLine("Please enter the favourite number:");
            string fav_n = Console.ReadLine();
            DbConnector.Execute($"INSERT INTO user (FirstName, LastName, FavouriteNumber) VALUES ('{first_n}','{last_n}',{fav_n})");
            Console.WriteLine("User {0} {1} is created!", first_n, last_n);
        }

        // delate user from table
        public static void Delete()
        {
            Console.WriteLine("Please enter the user's id that you want to delete:");
            string del_id = Console.ReadLine();
            DbConnector.Execute($"DELETE FROM user WHERE id = {del_id}");
            Console.WriteLine("User with ID of {0} is deleted!", del_id);
        }

        // update the record
        public static void Update()
        {
            Console.WriteLine("Please enter the user's id that you want to update:");
            string up_id = Console.ReadLine();
            Console.WriteLine("Please enter new first name:");
            string up_first = Console.ReadLine();
            Console.WriteLine("Please enter new last name:");
            string up_last = Console.ReadLine();
            Console.WriteLine("Please enter new fav number:");
            string up_fav = Console.ReadLine();
            DbConnector.Execute($"UPDATE user SET FirstName = '{up_first}', LastName = '{up_last}', FavouriteNumber = {up_fav} WHERE id = {up_id}");
        }


        // test the methods
        static void Main(string[] args)
        {
            Read();
            //Create();
            //Delete();
            Update();
            Read();
        }

    }
}