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
        List<StorageItem> box = new List<StorageItem>();
        public List<StorageItem> ShowAll() 
        { 
            return box;
        }
        public bool Add(StorageItem item)
        {
            box.Add(item);
            return true;
        }
        public bool Delete(String itemName)
        {
            foreach (var things in box)
            {
                if (things.Name.Equals(itemName, StringComparison.CurrentCultureIgnoreCase))
                {
                    box.Remove(things);
                    return true;
                }
            }
            return false;
        }
        public List<StorageItem> Search(String itemName)
        {
            var found = new List<StorageItem>();
            foreach (var things in box)
            {
                if (things.Name.Equals(itemName,StringComparison.CurrentCultureIgnoreCase))
                {
                    found.Add(things);
                }
            }
            return found;
        }
    }
}
