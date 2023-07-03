using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Dragon : Animal
    {
        public Dragon(string name) : base(name)
        {
            this.Legs = 8;
        }
    }
}
