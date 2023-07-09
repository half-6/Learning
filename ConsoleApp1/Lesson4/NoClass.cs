using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Lesson4
{
    internal class NoClass
    {
        public static void CountNotebook(string fileName)
        {
            var lines = File.ReadLines(fileName);

            var firstLine = true;

            decimal totalSalary = 0;
            decimal totalMaleSalary = 0;
            decimal totalFemaleSalary = 0;
            var totalPerson = 0;
            var totalAge = 0;
            foreach (var line in lines)
            {
                if (!firstLine)
                {
                    //start parse
                    var contents = line.Split(',');
                    var name = contents[0];
                    var age = Convert.ToInt16(contents[1]);
                    var gender = contents[2] == "male" ? "Male" : "Female";
                    var salary = Convert.ToDecimal(contents[3]);

                    totalSalary += salary;
                    totalPerson += 1;
                    totalAge += age;
                    if (gender.Equals("Male"))
                    {
                        totalMaleSalary += salary;
                    }
                    if (gender.Equals("Female"))
                    {
                        totalFemaleSalary += salary;
                    }
                }
                else
                {
                    firstLine = false;
                }
            }

            Console.WriteLine("The average salary for all employees is: " + Math.Round(totalSalary / totalPerson, 2));
            Console.WriteLine("The average male salary for all employees is: " + Math.Round(totalMaleSalary / totalPerson, 2));
            Console.WriteLine("The average female salary for all employees is: " + Math.Round(totalFemaleSalary / totalPerson, 2));
            Console.WriteLine("The avergage age for all employees is: " + Math.Round((double)totalAge / totalPerson));
        }
    }
}
