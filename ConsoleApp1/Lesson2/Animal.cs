﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Animal
    {
        // private member
        int score = 0;

        //constructor
        public Animal(string name)
        {
            this.Name = name;
        }
        public int Legs { get; protected set; }

        public string Name { get;  set; }


        //private string name; // field

        //public string Name   // property
        //{
        //    get { return name; }   // get method
        //    set { name = value; }  // set method
        //}

        public void Run() {
            Console.WriteLine("running...");
            Console.WriteLine("running...");
            Console.WriteLine("running...");
            Console.WriteLine($"{this.Name} is running...");
        }
    }
}