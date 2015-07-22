using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    public abstract class Course
    {
        protected string name;
        protected string teacherName;
        protected IList<string> Students;

        protected Course(string name)
        {
            this.Name = name;
            this.Students = new List<string>();
        }

        protected Course(string courseName, string teacherName)
            :this(courseName)
        {
            this.TeacherName = teacherName;
            this.Students = new List<string>();
        }

        public Course(string courseName, string teacherName, IList<string> students)
            : this(courseName, teacherName)
        {
            foreach (var student in students)
            {
                if (student != null)
                {
                    this.AddStudents(student);
                }
            }
        }

        protected string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                Validator.Name(value);
                this.name = value;
            }
        }

        protected string TeacherName
        {
            get
            {
                return this.teacherName;
            }
            set
            {
                Validator.Name(value);
                this.teacherName = value;
            }
        }

        

        protected void AddStudents(string student)
        {
            Validator.Name(student);
            this.Students.Add(student);
        }

        protected string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("LocalCourse { Name = ");
            result.Append(this.Name);
            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }
            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());
            result.Append(" }");
            return result.ToString();
        }
    }
}
