using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_05_2025
{
    internal class Commando
    {
        private string Name;
        public string NameCode { get; set; }
        public string[] Tools = { "hammer", "chisel", "rope", "bag", "water" ,"jug" };
        public string Status;

        public Commando(string name,string nameCode, string status) 
        {
            Name = name;
            NameCode = nameCode;
            Status = status ;
        }
        public void Walk()
        {
            Console.WriteLine("Walk");
            Status = "Walk";
        }
        public void Hide()
        {
            Console.WriteLine("Hide");
            Status = "Hide";
        }
        public void Attack()
        {
            Console.WriteLine("Attack");
            Status = "Attack";
        }
        public string SayName(string commanderRank)
        {
            if (commanderRank.Equals("GENERAL"))
                return Name;
            else if (commanderRank.Equals("COLONEL"))
                return NameCode;
            else
            {
                Console.WriteLine("classified");
                return "";
            }
        }
    }
}
