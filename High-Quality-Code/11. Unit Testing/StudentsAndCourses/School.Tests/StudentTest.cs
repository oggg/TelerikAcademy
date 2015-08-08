using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace School.Tests
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestStudentWithoutName()
        {
            Student unknown = new Student("", 20000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestStudentNumberValueOutOfRangeLoW()
        {
            Student gosho = new Student("Gosho", 150);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestStudentNumberValueOutOfRangeHigh()
        {
            Student gosho = new Student("Gosho", 150000);
        }

        [TestMethod]
        public void TestStudentNumberValueInRange()
        {
            Student gosho = new Student("Gosho", 30000);
            Assert.IsTrue(Helper.isBetween(gosho.Number), "Student number is out of range");
        }

        [TestMethod]
        public void StudentShouldNotThrowExceptionWhenAddedToCourse()
        {
            Course newCourse = new Course("First course");
            Student newStudent = new Student("Ivan", 40000);
            newStudent.AddToCourse(newCourse);
        }

        [TestMethod]
        public void StudentShouldNotThrowExceptionWhenRemovedFromCourseThatPreviouslyAttended()
        {
            Course newCourse = new Course("First course");
            Student newStudent = new Student("Ivan", 40000);
            newStudent.AddToCourse(newCourse);
            newStudent.RemoveFromCourse(newCourse);
        }
    }
}
