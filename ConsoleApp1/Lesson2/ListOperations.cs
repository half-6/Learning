using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ListOperations
    {
        public static void Run() {
            IList<String> list = new List<string>();
            list.Add("AAA");
            list.Add("BBB");
            list.Add("CCC");
            Console.WriteLine($"Current in list: {String.Join(",", list)}");
            Console.WriteLine($"Second one in the list => {list[1]}");

            Console.WriteLine("Removed second one");
            list.RemoveAt(1);
            Console.WriteLine($"Current in list: {String.Join(",", list)}");

            Console.WriteLine("Insert at second");
            list.Insert(1, "**********");
            Console.WriteLine($"Current in list: {String.Join(",", list)}");

            Console.WriteLine("Update third one to GGGGGGGGGG");
            list[2] = "GGGGGGGGGG";
            Console.WriteLine($"Current in list: {String.Join(",", list)}");
        }
    }
}
