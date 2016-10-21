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

        internal void Add(Employed employed)
        {
            this.Employeds.Add(employed);
            employed.setPosition("Dev1");
            employed.setSalary(100010);

        }
    }
}