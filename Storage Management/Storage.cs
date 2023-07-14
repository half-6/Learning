using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage_Management
{
    internal class Storage
    {
        List<string> box = new List<string>();
        public string ShowAll()
        {
            return String.Join(",", box);
        }
        public void Add(string item)
        {
            box.Add(item);
        }
        public void Delete(string item)
        {
            box.Remove(item);
        }    
        public string Search(string item)
        {
            if (box.IndexOf(item) == -1)
            {
                return "";
            }
            var number = 0;
            foreach (var things in box)
            {
                if (things == item)
                {
                    number++;
                }
            }
            if (number == 1)
            {
                return "There is " + number + " " + item + " in the box.";
            }
            return "There are " + number + " " + item + "s in the box.";
        }
    }
}
