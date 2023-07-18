using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Storage_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Storage Management.");
            var myStorage = new Storage();
            Console.WriteLine("Please enter operations.");
            var input = Console.ReadLine();
            while (input.Length > 0)
            {
                if (String.Equals(input,"List",StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine(String.Join(",", myStorage.ShowAll()));
                }
                if (input.StartsWith("Add ", StringComparison.CurrentCultureIgnoreCase) || input.StartsWith("insert ", StringComparison.CurrentCultureIgnoreCase))
                {
                    // add fruit apple 
                    // add <category> <name> <size>
                    var addition = new StorageItem();
                    var sep = input.Split(' ');
                    addition.Name = sep[2];
                    addition.Category = sep[1];
                    //addition.Size = Convert.ToInt16(sep[3]);

                    if (myStorage.Add(addition))
                    {
                        Console.WriteLine("Add success");
                    }
                    else
                    {
                        Console.WriteLine("Add failed");
                    }
                    
                }
                if (input.StartsWith("Delete ", StringComparison.CurrentCultureIgnoreCase) || input.StartsWith("remove ", StringComparison.CurrentCultureIgnoreCase))
                {
                    var deleted = input.Substring(7);
                    if (myStorage.Delete(deleted))
                    {
                        Console.WriteLine("Delete success");
                    }
                    else
                    {
                        Console.WriteLine("Delete failed");
                    }
                    
                }
                if (input.StartsWith("Search ", StringComparison.CurrentCultureIgnoreCase))
                {
                    var searched = input.Substring(7);
                    var found = myStorage.Search(searched);

                    //var myItem = new StorageItem();
                    //myItem.Name = "123";
                    //Console.WriteLine(myItem);

                    if (found.Count == 0)
                    {
                        Console.WriteLine("Not found");
                    }
                    else
                    {
                        Console.WriteLine(string.Join("|", found));
                    }
                    
                }

                input = Console.ReadLine();
            }

        }
    }
}
