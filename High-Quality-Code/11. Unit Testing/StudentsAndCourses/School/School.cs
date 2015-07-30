using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class School
    {
        private string schoolName;
        private IList<Course> courses;
        private IList<Student> students;

        public School(string name)
        {
            this.Name = name;
            this.courses = new List<Course>();
            this.students = new List<Student>();
        }

        public string Name
        {
            get
            {
                return this.schoolName;
            }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("School name is empty");
                }
                if (value.GetType().Name != "String")
                {
                    throw new ArgumentException("School name should be a string");
                }
                this.schoolName = value;
            }
        }

        public IList<Course> Cources
        {
            get
            {
                return this.courses;
            }
        }

        public void AddCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("Trying to add empty course to school");
            }

            if (this.Cources.Contains(course))
            {
                throw new ArgumentException("Course already added");
            }

            this.courses.Add(course);
        }

        public void RemoveCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("course", "Course cannot be null.");
            }

            if (!this.courses.Contains(course))
            {
                throw new InvalidOperationException("There is no such course.");
            }

            this.courses.Remove(course);
        }
    }
}
