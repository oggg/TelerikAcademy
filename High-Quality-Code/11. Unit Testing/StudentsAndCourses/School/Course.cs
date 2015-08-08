using System;
using System.Collections.Generic;

namespace School
{
    public class Course
    {
        private const int MAX_NUMBER_OF_STUDENTS = 29;

        private string courseName;
        private ICollection<Student> students;

        public Course(string name)
        {
            this.Name = name;
            this.students = new List<Student>();
        }

        public string Name
        {
            get
            {
                return this.courseName;
            }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Course name is empty");
                }
                if (value.GetType().Name != "String")
                {
                    throw new ArgumentException("Course name should be a string");
                }
                this.courseName = value;
            }
        }

        public List<Student> Students
        {
            get
            {
                return new List<Student>(this.students);
            }
        }

        public void AddStudent(Student student)
        {
            if (this.students.Count >= MAX_NUMBER_OF_STUDENTS)
            {
                throw new ArgumentException("Maximum number of studenst was reached");
            }
            if (student == null)
            {
                throw new ArgumentNullException("Cannot add non-existing student to course!");
            }

            if (this.students.Contains(student))
            {
                throw new ApplicationException("This student already attends the course");
            }
            this.students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            if (!this.students.Contains(student))
            {
                throw new MissingMemberException("No such student in this course");
            }
            this.students.Remove(student);
        }
    }
}
