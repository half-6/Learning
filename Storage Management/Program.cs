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
            Storage myStorage = new Storage();
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

            Dictionary<string, int> years = new Dictionary<string, int>();
            years.Add("John", 2007);
            Console.WriteLine(years["John"]);
            // Consoles out 2007

            Queue<String> frog = new Queue<String>();
            frog.Enqueue("toadstool");
            Console.WriteLine(frog.Peek());

            List<int> numbers = new List<int>();
            numbers.Add(2);
            Console.WriteLine(numbers[0]);


        }

        public int SeriesSum(int num)
        {
            int sum = 0;

            for (int i = 1; i <= Math.Abs(num); i++)
            {
                sum += i;
            }

            if (num <= 0)
            {
                return sum * -1;
            }
               

            return sum;
        }

        public int AbsoluteSum(int[] arr)
        {
            int result = 0;

            int index = 0;
            foreach (int num in arr)
            {
                if (index == 2)
                {
                    continue;
                }
                result += Math.Abs(num);
                index++;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 2)
                {
                    continue;
                }
                var num = arr[i];
                result += Math.Abs(num);
            }
                

            return result;
        }
    }
}
