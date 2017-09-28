using System;

namespace class_human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Ashley = new Human("Ashley M.");
            Human Kevin = new Human("Kevin W.");
            Ashley.Constructor();
            Kevin.Constructor(6,6,6);
            Ashley.Print();
            Kevin.Print();
            Kevin.Attack(Ashley);
            Ashley.Print();
            Kevin.Print();
        }
    }
}