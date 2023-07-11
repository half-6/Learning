using ConsoleApp1.Lesson4;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
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


            //var arrOperation = new ArrayOperation();
            //arrOperation.Run();

            //var cat1 = new Cat("yu ling");

            //var worlf1 = new Wolf();
            //worlf1.Name = "jiayi";

            //var worlf2 = new Wolf();
            //worlf2.Name = "jun zhang";

            //var worlf3 = new Wolf();
            //worlf3.Name = "grama zhang";



            //var world = new World();

            //world.Cats.Add(cat1);
            //world.Worlfs.Add(worlf1);
            //world.Worlfs.Add(worlf2);
            //world.Worlfs.Add(worlf3);

            //Console.WriteLine(world.Worlfs.Count);
            //Console.WriteLine(world.Cats.Count);

            //world.AllRun();



            //string[] list = { "Gordon", "Enaudi", "Gordon", "Saint-Saens", "Gordon" };


            //// Select (Selects Gordon)
            //for (var i = 0; i < list.Length; i++)
            //{
            //    Console.WriteLine(i);
            //}



            //var myNotebook = new Notebook();

            //var person1 = new Person();
            //person1.Salary = 10;
            //person1.Age = 20;

            //var person3 = new Person();
            //person3.Salary = 20;
            //person3.Age = 50;

            //myNotebook.PersonList.Add(person1);
            //myNotebook.PersonList.Add(person3);



            //Console.WriteLine("The average salary for all employees is: " + myNotebook.GetAvgSalary());
            //Console.WriteLine("The avergage age for all employees is: " + myNotebook.GetAvgAge());

            //string fileName = args[0];
            //var myNotebook = new Notebook(fileName);

            //Console.WriteLine("The average salary for all employees is: " + myNotebook.GetAvgSalary());
            //Console.WriteLine("The average male salary for all employees is: " + myNotebook.GetAvgSalary(Gender.Male));
            //Console.WriteLine("The average female salary for all employees is: " + myNotebook.GetAvgSalary(Gender.Female));
            //Console.WriteLine("The avergage age for all employees is: " + myNotebook.GetAvgAge());


            //NoClass.CountNotebook(fileName);

            ListOperations.Run();


            Console.ReadLine();

        }
        
    }
}
