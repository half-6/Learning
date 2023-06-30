using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StringOperations
    {
        public static string Select(string input, int position)
        {
            return input[position].ToString();
        }

        public static string Delete(string input, int start, int count)
        {
            return input.Remove(start, count);
        }

        public static string Delete(string input, string del)
        {
            //var index = input.IndexOf(del);
            //return input.Remove(index, del.Length);

            //return input.Replace(del, "");

            var index = input.IndexOf(del);
            while (index >= 0)
            { 
                input = input.Remove(index, del.Length);
                index = input.IndexOf(del);
            }
            return input;
        }

        /// <summary>
        /// Replace string output = StringOperations.Replace("Hello Hello", "ll", "****");
        /// </summary>
        /// <param name="input"></param>
        /// <param name="replaced"></param>
        /// <param name="replacement"></param>
        /// <returns></returns>
        public static string Replace(String input, string replaced, string replacement)
        {
            //return input.Replace(replaced, replacement);
            var index = input.IndexOf(replaced);
            while (index >= 0)
            {
                var start = input.Substring(0, index);

                var end = input.Substring(index + replaced.Length, input.Length - (index + replaced.Length));

                input = start + replacement + end;

                index = input.IndexOf(replaced);
            }

            return input;
        }

        public static string Update(string input, int index, string replacement)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (i != index)
                {
                    sb.Append(input[i]);
                }
                else
                {
                    sb.Append(replacement);
                }
            }
            return sb.ToString();
        }

        public static string Insert(string input, int index, string replacement)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (i == index)
                {
                    sb.Append(replacement);
                }
                sb.Append(input[i]);
            }
            return sb.ToString();
        }
    }
}
