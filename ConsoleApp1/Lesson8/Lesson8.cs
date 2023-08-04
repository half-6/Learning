using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Lesson8
    {
        public void ExceptionTester()
        {

            try
            {
                //int ans1 = Square(2, -2);
                //Console.WriteLine("answer is " + ans1);

                int ans2 = Square(4, 2);
                Console.WriteLine("answer is " + ans2);
            }
            catch (Exception e)
            {
                Console.WriteLine("input is wrong, because of " + e.Message);
            }
            finally
            {
                Console.WriteLine("wheve you do, doesn't matter exception or not, you always go here");
            }
        }

        int Square(int width, int length)
        {
            if (width < 0)
            {
                throw new Exception("width is not less than 0");
            }
            if (length < 0)
            {
                throw new Exception("length is not less than 0");
            }
            return width * length;
        }

        int Message(int abc)
        {
            if (abc < 0)
            {
                throw new Exception("Message error");
            }
            //
            return abc * 100; 
        }
    }
}
