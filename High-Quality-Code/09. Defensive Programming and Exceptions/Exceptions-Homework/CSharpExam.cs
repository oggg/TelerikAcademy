using System;

public class CSharpExam : Exam
{
    private const int MIN_SCORE = 0;
    private const int MAX_SCORE = 100;

    private int score;

    public CSharpExam(int score)
    {
        this.Score = score;
    }

    public int Score
    {
        get
        {
            return this.score;
        }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Score should not be negative number.");
            }
            if (this.Score < MIN_SCORE || this.Score > MAX_SCORE)
            {
                throw new ArgumentOutOfRangeException("Score should be from 0 to 100.");
            }
            this.score = value;
        }
    }

    public override ExamResult Check()
    {
        return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
    }
}
