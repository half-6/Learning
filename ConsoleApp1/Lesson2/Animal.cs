using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Animal
    {

        // protcect level + type + variable name = value


        // private member / variable
        int score = 0;

        string abc;

        List<int> myBox = new List<int>();

        //constructor
        public Animal(string name)
        {
            this.Name = name;
        }
       
        //property
        public int Legs { get; protected set; }

        public string Name { get;  set; }


        //private string name; // field

        //public string Name   // property
        //{
        //    get { return name; }   // get method
        //    set { name = value; }  // set method
        //}

        //method/function
        public void Run() {
            Console.WriteLine("running...");
            Console.WriteLine("running...");
            Console.WriteLine("running...");
            Console.WriteLine($"{this.Name} is running...");
        }

        public void Yall(string message)
        {
            Console.WriteLine($"{this.Name} {message}...");
        }

        public int Sum(int num1, int num2)
        {
            int count = num1 + num2;
            Console.WriteLine($"it is {count}...");
            return count;
        }

        public int Max(int[] nums)
        {
            return 1;
        }

        public int Max(List<int> nums)
        {
            return 1;
        }
    }
}
