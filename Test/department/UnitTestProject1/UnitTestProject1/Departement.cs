using System;
using System.Collections.Generic;
namespace UnitTestProject1
{
    internal class Departement
    {
        internal List<Employed> Employeds = new List<Employed>();

        public Departement()
        {
        }

        internal int size()
        {
            return Employeds.Count;
        }

        public void Add(Employed employed)
        {
            this.Employeds.Add(employed);
            employed.setPosition("Dev1");
            employed.setSalary(100010);
        }

        internal void Move(Employed employed)
        {
            //throw new NotImplementedException();

            employed.setPosition("123");
            employed.setSalary(15000);
        }

        public void Remove(Employed employed)
        {
            Employeds.Remove(employed);
            employed.setSalary(0);
            employed.setPosition(" ");

           

        }
            
    }
}