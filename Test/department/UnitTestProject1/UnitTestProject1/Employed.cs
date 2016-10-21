using System;

namespace UnitTestProject1
{
    internal class Employed : Person
    {
        public int selary { get; private set; }

        public string position { get; private set; }

        internal void setPerson(Person vPupkin)
        {
            this.firstName = vPupkin.firstName;
            this.secondName = vPupkin.secondName;
            this.gender = vPupkin.gender;
            this.age = vPupkin.age;
            
        }

        internal void setSalary(int v)
        {
            this.selary = v;
        }

        internal void setPosition(string v)
        {
            this.position = v;
        }
    }
}