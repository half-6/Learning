using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ArrayOperation
    {
        public void Run()
        {
            string[] list = { "AAA", "BBB", "CCC" };

            Console.WriteLine($"Current in list: {String.Join(",", list)}");

            Console.WriteLine($"Second one in the list => {list[1]}");


            Console.WriteLine("Removed second one");
            list = RemoveAt(list,1);
            Console.WriteLine($"Current in list: {String.Join(",", list)}");


            Console.WriteLine("Insert at second");
            list = Insert(list, 1, "**********");
            Console.WriteLine($"Current in list: {String.Join(",", list)}");

            Console.WriteLine("Update third one to GGGGGGGGGG");
            list[2] = "GGGGGGGGGG";
            Console.WriteLine($"Current in list: {String.Join(",", list)}");
        }

        public string[] RemoveAt(string[] list, int index) {
            string[] output = new string[list.Length - 1];
            for (var i = 0; i < list.Length; i++)
            {
                if (i < index)
                {
                    output[i] = list[i];
                }
                if (i > index)
                {
                    output[i-1] = list[i];
                }
            }
            return output;
        }

        public string[] Insert(string[] list, int index, string value)
        {
            string[] output = new string[list.Length + 1];
            for (var i = 0; i < output.Length; i++)
            {
                if ((i < index))
                {
                    output[i] = list[i];
                }
                if (i == index)
                {
                    output[i] = value;
                }
                if ((i > index))
                {
                    output[i] = list[i-1];
                }
            }
            return output;
        }
    }
}
