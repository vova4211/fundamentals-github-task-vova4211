using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    internal class Person
    {
        private string name;
        private DateTime birtYear;

        public string Name
        {
            get { return name; }
            
        }

        public DateTime BirtYear
        {
            get { return birtYear; }
           
        }

        public Person() { }

        public Person(string name, DateTime birtYear)
        {
            this.name = name;
            this.birtYear = birtYear;
        }

        public int Age() 
        {
         
            int age = DateTime.Now.Year - birtYear.Year;
            return age;
        }

        public static Person Input(int i)
        {
            Console.WriteLine($"Enter name {i + 1}th person");
            string name = Console.ReadLine();
            Console.WriteLine($"enter  year of birth {i + 1}th person" );
            DateTime birtYear = new DateTime(Convert.ToInt16(Console.ReadLine()),1,1);
            Person person = new Person(name, birtYear);
            return person;
        }

        public void ChangeName(string newName)
        {
            name = newName;
        }

        public void Output()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return ($"{name} was borned in {birtYear.Year}");
        }

        public static bool operator == ( Person a, Person b )
        {
            return (a.name == b.name);
        }
        public static bool operator != ( Person a, Person b)
        {
            return !(a.name == b.name);
        }
    }
}
