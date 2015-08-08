using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Tests
{
    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        public void CheckCourseWithCorrectNameIsNotThrowing()
        {
            Course newCourse = new Course("a new course");
            Assert.AreEqual("a new course", newCourse.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CheckMissingCourseNameIsThrowing()
        {
            Course newCourse = new Course("");
        }

        [TestMethod]
        public void CheckAddingOfStudentsToCourse()
        {
            Student gosho = new Student("Gosho", 20000);
            Course firstCourse = new Course("the first Course");

            firstCourse.AddStudent(gosho);
            Assert.AreSame(gosho, firstCourse.Students.First());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CheckAddingOfNullStudentToCourse()
        {
            Student gosho = null;
            Course firstCourse = new Course("the first Course");

            firstCourse.AddStudent(gosho);
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void CheckAddingAlreadyAddedStudentToCourse()
        {
            Student gosho = new Student("Gosho", 10000);
            Course firstCourse = new Course("the first Course");

            firstCourse.AddStudent(gosho);
            firstCourse.AddStudent(gosho);
        }

        [TestMethod]
        [ExpectedException(typeof(MissingMemberException))]
        public void TryToRemoveAStudentWhoIsNotAttendingThisCourse()
        {
            Student gosho = new Student("Gosho", 10000);
            Course firstCourse = new Course("the first Course");
            firstCourse.AddStudent(gosho);
            firstCourse.RemoveStudent(gosho);
            firstCourse.RemoveStudent(gosho);
        }
    }
}
