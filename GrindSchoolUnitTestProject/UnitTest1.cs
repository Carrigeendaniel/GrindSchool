using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace GrindSchoolUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddGrind()
        {
            //Assertions
            //Create a new grind object 
            //myGrind = new Grind();
            Grind newGrind = new Grind();
            //Add Grind
            newGrind.Add("Maths");
            //Add the Grind to the list
            //MyGrinid.AddToList()
            List<Grind> grinds = new List<Grind>();
            grinds.Add(newGrind);
            //get a list of all the grinds

            //check that the new grind is in the list
            //Assert
            //Assert.IsTrue();
        }

        [TestMethod]
        public void AddTeacher()
        {
            
        }

        [TestMethod]
        public void AddStudent()
        {

        }

        [TestMethod]
        public void BookGrind()
        {

        }
    }
}
