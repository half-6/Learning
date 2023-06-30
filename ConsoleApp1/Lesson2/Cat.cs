using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Cat : Animal 
    {
        public Cat(string name) : base(name)
        {
            this.Legs = 4;
        }
    }
}
