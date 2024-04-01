using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GpaCalclator.classes
{
    public class Course
    {
        public string Title { get; set; }
        public string Code { get; set; }
        public int Units { get; set; }
        public int Score { get; set; }
        public string Grade { get; set; }
        public int GradePoint { get; set; }
        public string Remark { get; set; }

        public Course(string title, string code, int units, int score)
        {
            Title = title;
            Code = code;
            Units = units;
            Score = score;
            CalculateGrade();
        }

        private void CalculateGrade()
        {
            if (Score >= 70)
            {
                Grade = "A";
                GradePoint = 5;
                Remark = "Excellent";
            }
            else if (Score >= 60)
            {
                Grade = "B";
                GradePoint = 4;
                Remark = "Very Good";
            }
            else if (Score >= 50)
            {
                Grade = "C";
                GradePoint = 3;
                Remark = "Good";
            }
            else if (Score >= 40)
            {
                Grade = "D";
                GradePoint = 2;
                Remark = "Average";
            }
            else if (Score >= 39)
            {
                Grade = "E";
                GradePoint = 1;
                Remark = "Poor";
            }
            else
            {
                Grade = "F";
                GradePoint = 0;
                Remark = "Fail";
            }
        }
    }
}
