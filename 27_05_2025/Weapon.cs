using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_05_2025
{
    internal class Weapon
    {
        string Name;
        string Manufacturer;
        int Balls;
        public Weapon(string name, string manufacturer, int balls) 
        { 
            Name = name;
            Manufacturer = manufacturer;
            Balls = balls;
        }
        public void Shoot()
        {
            if (Balls > 0)
            {
                Console.WriteLine("Boom");
                Balls--;
            }
            else Console.WriteLine("empety");
        }
    }
}
