using System;

public class SimpleMathExam : Exam
{
    private const int MIN_PROBLEMS_SOLVED = 0;
    private const int MAX_PROBLEMS_SOLVED = 10;

    private int problemsSolved;

    public SimpleMathExam(int problemsSolved)
    {
        this.ProblemsSolved = problemsSolved;
    }

    public int ProblemsSolved
    {
        get
        {
            return this.problemsSolved;
        }
        private set
        {
            if (value.GetType() != typeof(int))
            {
                throw new ArgumentException("Number of exams should be integer value");
            }
            if (value < 0)
            {
                this.problemsSolved = MIN_PROBLEMS_SOLVED;
            }
            if (value > 10)
            {
                this.problemsSolved = MAX_PROBLEMS_SOLVED;
            }
        }
    }

    public override ExamResult Check()
    {
        switch (this.ProblemsSolved)
        {
            case 0:
                {
                    return new ExamResult(2, 2, 6, "Bad result: nothing done.");
                }
            case 1:
                {
                    return new ExamResult(4, 2, 6, string.Format("Average result: {0} provided.", this.problemsSolved));
                }
            case 2:
                {
                    return new ExamResult(6, 2, 6, string.Format("Average result: {0} provided.", this.problemsSolved));
                }
            default:
                return new ExamResult(0, 0, 0, "Invalid number of problems solved!");
        }
    }
}
