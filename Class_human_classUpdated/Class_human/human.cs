using System;
using System.Collections.Generic;
using System.Text;

namespace class_human
{
    class Human
    {
        public String name;
        public int strength;
        public int intelligence;
        public int dexterity;
        public int health;

        public Human(String sName)
        {
            name = sName;
        }

        public void Constructor(int n_strength = 3, int n_intelligence = 3, int n_dexterity = 3, int n_health = 100)
        {
            strength = n_strength;
            intelligence = n_intelligence;
            dexterity = n_dexterity;
            health = n_health;
        }
        //print info of the object
        public void Print()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Strength: {0}", strength);
            Console.WriteLine("Intelligence: {0}", intelligence);
            Console.WriteLine("Dexterity: {0}", dexterity);
            Console.WriteLine("Health: {0}", health);
        }

        public void Attack(Human attacked)
        {
            attacked.health -= 5;
            strength += 1;
            Console.WriteLine("{0} attacked {1}!", name, attacked.name);
        }
    }
}
