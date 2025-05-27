using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_05_2025
{
    internal class SeaCommando:Commando
    {
        public SeaCommando(string name, string nameCode, string status) : base(name, nameCode, status){}
        public override void Attack()
        {
            Console.WriteLine("The sea commando is swimming through the waves");
        }
    }
}
