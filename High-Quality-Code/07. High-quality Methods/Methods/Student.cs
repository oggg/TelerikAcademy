using System;

namespace Methods
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private string otherInfo;

        public Student(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.otherInfo = string.Empty;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (value is string && value.Length > 0)
                {
                    this.firstName = value;
                } 
                else
                {
                    throw new ArgumentException("First name cannot be empty string");
                }
            }
        }

        public string LastName 
        { 
            get
            {
                return this.lastName;
            }
            set
            {
                if (value is string && value.Length > 0)
                {
                    this.lastName = value;
                }
                else
                {
                    throw new ArgumentException("Last name cannot be empty string");
                }
            }
        }
        public string OtherInfo 
        { 
            get
            {
                return this.otherInfo;
            }
            set
            {
                if(value.GetType() == "string")
                {
                    this.otherInfo = value;
                }
                else
                {
                    throw new ArgumentException("This data should be a string");
                }
            }
        }

        public bool IsOlderThan(Student otherStudent)
        {
            DateTime currentStudentBirth, otherStudentBirth;

            try
            {
                currentStudentBirth = DateTime.Parse(this.OtherInfo.Substring(this.OtherInfo.Length - 10));
            }
            catch (FormatException)
            {
                throw new FormatException("Birth date is not in the correct format");
            }

            try
            {
                otherStudentBirth = DateTime.Parse(otherStudent.OtherInfo.Substring(otherStudent.OtherInfo.Length - 10));
            }
            catch (Exception)
            {
                throw new FormatException("Birth date is not in the correct format");
            }
            
            return currentStudentBirth < otherStudentBirth;
        }
    }

}