using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
//using NUnit.Framework;

namespace GrindSchool.Tests
{
    [TestClass]
    public class GrindSchoolTests
    {
        
        [TestMethod]
        public void TestAddNewGrindToGrindSchoolSystem() //Available grinds//Add French etc
        {
            //School 
            //Count on number of grinds, 
            //Assert equal to 0

            //***************

            //Assertions
            //Create a new grind object 
            //myGrind = new Grind();
            Grind newGrind = new Grind("Maths",20,"Thursday 18:00");//Name, amount, day time
            //Add Grind
            newGrind.Add("Maths");
            //Add the Grind to the list
            //MyGrinid.AddToList()
            List<Grind> grinds = new List<Grind>();
            grinds.Add(newGrind);
            //get a list of all the grinds
            //J - Assert now will be equal to one
            //check that the new grind is in the list
            //Assert
            Assert.IsTrue();

            //Assert equal to zero
        }
        
        /*
         Classes-
         School class - list of grinds, list of students, list of bookings//add goes into appropriate list in the school
         Grind class
         Student
         Booking
         //********
         Teachers - just added as strings
         
        //**************
        //Collection in every class, Collection of type Grind eg French
        //


        /*
        [TestMethod]
        public void TestAddNewGrindToGrindSchoolSystem() //Available grinds//Add French etc
        {
            School 
            Count on number of grinds, 
            Assert equal to 0

            //***************

            //Assertions
            //Create a new grind object 
            //myGrind = new Grind();
            Grind newGrind = new Grind("Maths",20,"Thursday 18:00");//Name, amount, day time
            //Add Grind
            newGrind.Add("Maths");
            //Add the Grind to the list
            //MyGrinid.AddToList()
            List<Grind> grinds = new List<Grind>();
            grinds.Add(newGrind);
            //get a list of all the grinds
            //J - Assert now will be equal to one
            //check that the new grind is in the list
            //Assert
            NUnit.Framework.Assert.True();

            //Assert equal to zero
        }
        */
        /*
        [TestMethod]
        public void TestAddTeacher()
        {
            //Create new Teachers List
            Teacher newTeacher = new Teacher();

            //Add new Teacher to the List
            List<Teacher> teachers = new List<Teacher>();
            teachers.Add(newTeacher);
            //get a List of all the teachers

            //Check that the new teacher is in the list.
            Assert.IsTrue(teachers.Any(p => p.Name == "Teachername"));//
            //List of Teachers making sure the teacher is in the list, checking name
        }
        */
        [TestMethod]
        public void TestAddStudent()
        {
            CalculateCurrentStudentsAmount sc = new CalculateCurrentStudentsAmount();

            int result = sc.Add("");

            NUnit.Framework.Assert.That(result, Is.EqualTo(0));
        }

        [TestMethod]
        public void Test_Add_SingleTeacher_ReturnsThatTeacher()
        {
            CalculateCurrentStudentsAmount sc = new CalculateCurrentStudentsAmount();

            int result = sc.Add("1");

            NUnit.Framework.Assert.AreEqual(1, result);
        }

        /*
        [TestMethod]
        public void TestPaidStatusInNewBooking()
        {
        ;;Check that when a new booking is made, the 'paid' attribute
        is defaulted to false until the confirmPayment() method is used
           
             Student s = new Student();
            
              Grind g = new Grind();

            Booking b = new Booking(s, g);
            
            assert(false,b.isPaid();)
            
            b.confirmPayment();
            assert(true,b.isPaid();)


        }
        */
    }

    public class CalculateCurrentStudentsAmount
        {
            public int Add(string numberOfStudents)
            {
                //throw new NotImplementedException();
                //return 0;//bug
                if(numberOfStudents.Length == 0)
                {
                    return 0;
                }
                return int.Parse(numberOfStudents);
            }
        }
}
