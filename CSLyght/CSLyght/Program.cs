using System;

namespace CSLyght
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name = "David Gwyn";
            char Gender = 'M';
            short Level = 27;
            long Experience = 0;
            int Health = 100;
            byte Stamina = 50;
            sbyte Damage = -1;
            float Speed = 2.5f;
            double Height = 2.3;
            bool IsAlive = true;

            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Gender: " + Gender);
            Console.WriteLine("Level: " + Level);
            Console.WriteLine("Experiance: " + Experience);
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("Stamina " + Stamina);
            Console.WriteLine("Damage: " +  Damage);
            Console.WriteLine("Speed: " + Speed);
            Console.WriteLine("Hieght: " +  Height);
            Console.WriteLine("IsAlive: " + IsAlive);
        }
    }
}
