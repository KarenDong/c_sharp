using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = JsonToFile<Artist>.ReadJson();
            List<Group> Groups = JsonToFile<Group>.ReadJson();

            //========================================================
            //Solve all of the prompts below using various LINQ queries
            //========================================================

            //There is only one artist in this collection from Mount Vernon, what is their name and age?
            IEnumerable<Artist> mount = from temp in Artists.Where(theartist => theartist.Hometown == "Mount Vernon")
                                        select temp;
            Console.WriteLine(mount.Count());
            foreach (Artist i in mount)
            {
                Console.WriteLine("Name: {0}; Age: {1}",i.ArtistName,i.Age);
            }

            //Who is the youngest artist in our collection of artists?
            Artist young = Artists.OrderBy(Artist => Artist.Age).First();
            Console.WriteLine(young.ArtistName + "is the youngest.");

            //Display all artists with 'William' somewhere in their real name
            IEnumerable<Artist> william = from temp in Artists.Where(theartist => theartist.RealName.Contains("William"))
                                          select temp;
            foreach (Artist i in william)
            {
                Console.WriteLine(i.RealName);
            }

            //Display the 3 oldest artist from Atlanta
            IEnumerable<Artist> olds = Artists.OrderByDescending(Artist => Artist.Age).Take(3);
            foreach (Artist i in olds)
            {
                Console.WriteLine("Old ones:" + i.ArtistName);
            }

            //(Optional) Display the Group Name of all groups that have members that are not from New York City

            //(Optional) Display the artist names of all members of the group 'Wu-Tang Clan'
        }
    }
}
