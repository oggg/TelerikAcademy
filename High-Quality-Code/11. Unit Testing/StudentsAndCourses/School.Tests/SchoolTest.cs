namespace School.Test
{
    using System;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SchoolTest
    {
        [TestMethod]
        public void SchoolShouldNotThrowException()
        {
            var school = new School("The School");
        }

        [TestMethod]
        public void SchoolShouldReturnNameCorrectly()
        {
            var school = new School("The School");
            Assert.AreEqual("The School", school.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolShouldThrowExceptionWhenNameIsNull()
        {
            var school = new School(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolShouldThrowExceptionWhenNameIsEmpty()
        {
            var school = new School(string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolShouldThrowExceptionWhenNullCourseAdded()
        {
            var school = new School("The School");
            Course course = null;
            school.AddCourse(course);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void SchoolShouldThrowExceptionWhenExistingCourseAdded()
        {
            var school = new School("The School");
            var course = new Course("The Course");
            school.AddCourse(course);
            school.AddCourse(course);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolShouldThrowExceptionWhenRemovingNullCourse()
        {
            var school = new School("The School");
            Course course = null;
            school.RemoveCourse(course);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void SchoolShouldThrowExceptionWhenRemovingNotExistingCourse()
        {
            var school = new School("The School");
            var course = new Course("The Course");
            school.RemoveCourse(course);
        }
    }
}