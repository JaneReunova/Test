﻿using System;
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
            //throw new NotImplementedException();
        }

        public void Remove(Employed employed)
        {
            Employeds.Remove(employed);
            employed.setSalary(0);
            employed.setPosition(" ");

            employed.setPosition("123");
            employed.setSalary(15000);
           

        }
            
    }
}