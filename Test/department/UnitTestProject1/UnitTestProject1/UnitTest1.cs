using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Person VPupkin = new Person("Vasya", "Pupkin", "male", 22);
            Assert.AreEqual("Vasya", VPupkin.firstName);
            Assert.AreEqual("Pupkin", VPupkin.secondName);
            Assert.AreEqual("male", VPupkin.gender);
            Assert.AreEqual(22, VPupkin.age);
           Person VPupkina = new Person();
            string FName = "Marina";
            string SName = "Pupkina";
            string gender = "female";
            int age = 22;
            VPupkina.firstName = FName;
            VPupkina.secondName = SName;
            VPupkina.gender = gender;
            VPupkina.age = age;
            Assert.AreEqual("Marina", VPupkina.firstName);
            Assert.AreEqual("Pupkina", VPupkina.secondName);
            Assert.AreEqual("female", VPupkina.gender);
            Assert.AreEqual(22, VPupkina.age);

        }
        [TestMethod]
        public void TestAddEmployed()
        {
            Person VPupkin = new Person("Vasya", "Pupkin", "male", 22);
            Employed employed = new Employed();
            employed.setPerson(VPupkin);
            employed.setSalary(10000);
            employed.setPosition("Dev");
            Assert.AreEqual("Vasya", employed.firstName);
            Assert.AreEqual(10000, employed.selary);
            Assert.AreEqual("Dev", employed.position);
        }
        [TestMethod]
        public void TestAddDepartment()
        {
            Departement Otdel = new Departement();
            Assert.IsNotNull(Otdel.Employeds);
            Assert.AreEqual(0, Otdel.size());

            Person VPupkin = new Person("Vasya", "Pupkin", "male", 22);
            Employed employed = new Employed();
            employed.setPerson(VPupkin);
            employed.setSalary(10000);
            employed.setPosition("Dev");
            
        }
        [TestMethod]
        public void TestMoveEmployed()
        {
            Departement Otdel = new Departement();
            Assert.IsNotNull(Otdel.Employeds);
            Assert.AreEqual(0, Otdel.size());

            Person VPupkin = new Person("Vasya", "Pupkin", "male", 22);
            Employed employed = new Employed();
            employed.setPerson(VPupkin);
            employed.setSalary(10000);
            employed.setPosition("Dev");
            Otdel.Add(employed);
            Otdel.Move(employed);
            Assert.AreEqual("123", employed.position);
            Assert.AreEqual(15000, employed.selary);
            
        
        }
    }
}
