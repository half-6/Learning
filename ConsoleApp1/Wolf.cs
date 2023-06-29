using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Wolf : Animal
    {
        public Wolf() {
            this.Legs = 4;
        }
        public void Bark() {
            Console.WriteLine("Bark...");
            Console.WriteLine("Bark...");
            Console.WriteLine("Bark...");
            Console.WriteLine($"{this.Name} is Bark...");
        }
    }
}
