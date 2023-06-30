using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class World
    {
        public IList<Cat> Cats { get; set; } = new List<Cat>();

        public IList<Wolf> Worlfs { get; set; } = new List<Wolf>();

        public void AllRun() {
            foreach(var cat in this.Cats)
            {
                cat.Run();
            }

            foreach (var worlf in this.Worlfs)
            {
                worlf.Run();
            }
        }
    }
}
