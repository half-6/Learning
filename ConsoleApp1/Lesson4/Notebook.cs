using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Lesson4
{
    internal class Notebook
    {
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
            
            return  Math.Round(count / PersonList.Count);
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
    }
}
