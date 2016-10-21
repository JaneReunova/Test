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

        }

        internal void Move(Employed employed)
        {
            employed.setPosition("123");
            employed.setSalary(15000);
           

        }
            
    }
}