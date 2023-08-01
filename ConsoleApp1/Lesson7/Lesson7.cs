using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Lesson7
{
    internal class Lesson7
    {
        public int FindNum(string num)
        {
            if (num == "111")
            {
                throw new Exception("I can't find any number");
            }
            if (num == "333")
            {
                throw new Exception("I can't find any input");
            }
            // real code logic, skip here
            return 1;
        }
        public void HowToUseException()
        {
            try
            {
                int res = FindNum("111");
                Console.WriteLine(res);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
