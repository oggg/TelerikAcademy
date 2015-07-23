using System.Collections.Generic;
using System.Linq;

namespace Exceptions_Homework
{
    public static class Calculator
    {
        public static double AverageExamResultInPercents(Student student)
        {
            if (student.Exams.Count == 0)
            {
                // No exams --> return -1;
                return -1;
            }

            double[] examScore = new double[student.Exams.Count];
            IList<ExamResult> examResults = student.CheckExams();
            for (int i = 0; i < examResults.Count; i++)
            {
                examScore[i] =
                    ((double)examResults[i].Grade - examResults[i].MinGrade) /
                    (examResults[i].MaxGrade - examResults[i].MinGrade);
            }

            return examScore.Average();
        }
    }
}
