﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string greeting = "Hello";

            ////Console.WriteLine($"Select 1 from Hello => {StringOperations.Select(greeting,1)}");



            ////Console.WriteLine($"Delete 1 from Hello => {StringOperations.Delete(greeting,1,1)}");

            //Console.WriteLine($"Update 1 from Hello => {StringOperations.Update(greeting,1,"A")}");
            ////Console.WriteLine($"Insert 1 from Hello => {StringOperations.Insert(greeting,1,"HH")}");
            //string output = StringOperations.Replace("Hello Hello", "ll", "****");
            //Console.WriteLine($"Delete 1 from Hello => {output}");


            var cat1 = new Cat();
            cat1.Name = "yu ling";
            //Console.WriteLine(cat1.Name);
            //cat1.Run();


            var worlf1 = new Wolf();
            worlf1.Name = "jiayi";
            //worlf1.Bark();

            var worlf2 = new Wolf();
            worlf2.Name = "jun zhang";

            var worlf3 = new Wolf();
            worlf3.Name = "grama zhang";
            //worlf2.Bark();


            var world = new World();

            world.Cats.Add(cat1);
            world.Worlfs.Add(worlf1);
            world.Worlfs.Add(worlf2);
            world.Worlfs.Add(worlf3);

            Console.WriteLine(world.Worlfs.Count);
            Console.WriteLine(world.Cats.Count);

            world.AllRun();

            Console.ReadLine();
        }

    }
}