using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    public class Person
    {
        public Person()
        {
        }

        public Person(string firstName, string secondName, string gender, int age)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.gender = gender;
            this.age = age;
        }

        public int age { get; internal set; }
        public string firstName { get; internal set; }
        public string gender { get; internal set; }
        public string secondName { get; internal set; }
    }
}
