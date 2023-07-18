using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage_Management
{
    internal class StorageItem
    {
        public string Name { get; set; }

        public string Category { get; set; }

        public DateTime Expiration { get; set; }

        public int Size { get; set; }

        public double Weight { get; set; }

        public override string ToString()
        {
            return $"{Name} : {Category}";
        }
    }
}
