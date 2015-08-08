using System;

namespace School
{
    public class Student
    {
        public const int STUDENT_NUMBER_START = 10000;
        public const int STUDENT_NUMBER_END = 99999;

        private int studentNumber;
        private string studentName;

        public Student(string name, int number)
        {
            this.Name = name;
            this.Number = number;
        }

        public string Name
        {
            get
            {
                return this.studentName;
            }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Student name is empty");
                }
                if (value.GetType().Name != "String")
                {
                    throw new ArgumentException("Student name should be a string");
                }
                this.studentName = value;
            }
        }

        public int Number
        {
            get
            {
                return this.studentNumber;
            }
            private set
            {
                if (value < STUDENT_NUMBER_START || STUDENT_NUMBER_END < value)
                {
                    throw new ArgumentOutOfRangeException(string.Format("Student number should be between {0} and {1}", STUDENT_NUMBER_START, STUDENT_NUMBER_END));
                }
                this.studentNumber = value;
            }
        }

        public void AddToCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("Student cannot be added to ");
            }

            course.AddStudent(this);
        }

        public void RemoveFromCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("Student cannot be added to ");
            }
            course.RemoveStudent(this);
        }
    }
}
