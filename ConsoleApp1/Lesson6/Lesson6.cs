using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Lesson6
{
    internal class Lesson6
    {
        public string Welcome(String person)
        {
            //person = "abc";

            if (person.Equals("dad", StringComparison.CurrentCultureIgnoreCase))
            {
                return "Welcome dad";
            }
            else if (person == "mom")
            {
                return "Welcome mom";
            }
            else if (person == "jiayi")
            {
                return "Welcome jiayi";
            }
            else if (person == "abc")
            {
                return "Welcome abc";
            }
            else
            {
                return "Get our";
            }
        }

        public string WelcomeSwitch(String person)
        {
            //person = "abc";
            switch (person.ToLower())
            {
                case "dad":
                    return "Welcome dad";
                case "mom":
                    return "Welcome mom";
                case "jiayi":
                    return "Welcome jiayi";
                case "abc":
                    return "Welcome abc";
                case "1":
                    return "Welcome 1";
                default:
                    return "Get out";
            }
        }

        public string WelcomeAllowPerson(String person)
        {
            String[] allowPersons = { "dad", "mom", "jiayi", "abc" };
            if (allowPersons.Contains(person.ToLower()))
            {
                return "Welcome " + person;
            }
            return "Get out";
        }

        public void Abc()
        {
            string[] toys = { "balls", "cars", "planes", "ffff", "Ffffff" };
            for (int i = 0; i < toys.Length; i++)
            {
                Console.WriteLine(toys[i]); //indexer
            }
            foreach (string a in toys)
            {
                Console.WriteLine(a);
            }
            int wi = 0;
            while (wi < toys.Length)
            {
                Console.WriteLine(toys[wi]); //indexer
                wi++;
            }

            for (int j = 1; j > 50; j = j * 2)
            {
                Console.WriteLine(j);
            }

        }
    }
}
