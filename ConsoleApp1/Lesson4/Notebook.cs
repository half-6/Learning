using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Lesson4
{
    internal class Notebook
    {
        internal Notebook(string fileName) {
            var lines = File.ReadLines(fileName);
            var firstLine = true;
            foreach (var line in lines)
            {
                if (!firstLine)
                {
                    //start parse
                    var contents = line.Split(',');
                    var person = new Person();
                    person.Name = contents[0];
                    person.Age = Convert.ToInt16(contents[1]);
                    person.Gender = contents[2] == "male" ? Gender.Male : Gender.Female;
                    person.Salary = Convert.ToDecimal(contents[3]);
                    this.PersonList.Add(person);
                }
                else
                {
                    firstLine = false;
                }
            }
        }

        public List<Person> PersonList { get; set; } = new List<Person>();

        public decimal GetAvgSalary()
        {
            if (PersonList.Count == 0)
            {
                return 0;
            }
            decimal count = 0;
            foreach (var person in PersonList)
            {
                count += person.Salary;
            }
            
            return  Math.Round(count / PersonList.Count,2);
        }

        public decimal GetAvgAge()
        {
            if (PersonList.Count == 0)
            {
                return 0;
            }
            decimal count = 0;
            foreach (var person in PersonList)
            {
                count += person.Age;
            }
            return Math.Round(count / PersonList.Count);
        }

        public decimal GetAvgSalary(Gender gender) {
            if (PersonList.Count == 0)
            {
                return 0;
            }
            decimal count = 0;
            foreach (var person in PersonList)
            {
                if (person.Gender == gender)
                {
                    count += person.Salary;
                }
            }
            return Math.Round(count / PersonList.Count, 2);
        }

    }
}
