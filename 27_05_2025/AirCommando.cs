using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_05_2025
{
    internal class AirCommando : Commando
    {
        public AirCommando(string name, string nameCode, string status) : base(name, nameCode, status) { }
            public override void Attack()
        {
            Console.WriteLine("Air Commando The ground commando is advancing across the terrain");
        }
    }

}
    

