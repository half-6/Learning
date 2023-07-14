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
                    Console.WriteLine(myStorage.ShowAll());
                }
                if (input.StartsWith("Add ", StringComparison.CurrentCultureIgnoreCase) || input.StartsWith("insert ", StringComparison.CurrentCultureIgnoreCase))
                {
                    var addition = input.Substring(4);
                    myStorage.Add(addition);
                    Console.WriteLine("Add success");
                }
                if (input.StartsWith("Delete ", StringComparison.CurrentCultureIgnoreCase) || input.StartsWith("remove ", StringComparison.CurrentCultureIgnoreCase))
                {
                    var deleted = input.Substring(7);
                    myStorage.Delete(deleted);
                    Console.WriteLine("Delete success");
                }
                if (input.StartsWith("Search ", StringComparison.CurrentCultureIgnoreCase))
                {
                    var searched = input.Substring(7);
                    var found = myStorage.Search(searched);
                    if (found.Length == 0)
                    {
                        Console.WriteLine("Not found");
                    }
                    else
                    {
                        Console.WriteLine(found);
                    }
                    
                }

                input = Console.ReadLine();
            }

        }
    }
}
