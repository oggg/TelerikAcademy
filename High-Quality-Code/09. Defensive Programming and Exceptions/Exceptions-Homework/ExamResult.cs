using System;

public class ExamResult
{
    private int grade;
    private int minGrade;
    private int maxGrade;
    private string coments;

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }

    public int Grade
    {
        get
        {
            return this.grade;
        }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Grade should be positive number");
            }
            this.grade = value;
        }
    }

    public int MinGrade
    {
        get
        {
            return this.minGrade;
        }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Min grade should be positive number");
            }
            this.minGrade = value;
        }
    }

    public int MaxGrade
    {
        get
        {
            return this.maxGrade;
        }
        private set
        {
            if (value <= this.MinGrade)
            {
                throw new ArgumentException("Max grade should be bigger than min grade");
            }
            this.maxGrade = value;
        }
    }

    public string Comments
    {
        get
        {
            return this.coments;
        }
        private set
        {
            if (value == null || value == "")
            {
                throw new ArgumentNullException("Comments caoont be null");
            }
        }
    }
}