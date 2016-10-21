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

        internal static void Add(Employed employed)
        {
            //throw new NotImplementedException();
        }

        public void Remove(Employed employed)
        {
            Employeds.Remove(employed);
            employed.setSalary(0);
            employed.setPosition(" ");

        }
    }
}