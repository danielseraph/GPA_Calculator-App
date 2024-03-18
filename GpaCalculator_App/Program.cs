using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GpaCalculator_App
{
    public class Course
    {
        //Propertice 
        public string Title { get; set; }
        public string Code { get; set; }
        public int Unit { get; set; }
        public int Score { get; set; }
        public string Grade { get; set; }
        public int GradePoint { get; set; }
        public string Remark { get; set; }
        public void CalculateGradePointRemark()
        {
            GradePointCalculator calculator = new GradePointCalculator();
            GradeResult result = calculator.Calculate(Score);
            Grade = result.Grade;
            GradePoint = result.GradePoint;
            Remark = result.Remark;
        }
    }
    public class GradePointCalculator
    {
        //Method for calculating the grade and remark
        public GradeResult Calculate(int score)
        {
            if (score >= 70)
                return new GradeResult("A", 5, "Excellence");
            else if (score >= 60 && score < 70)
                return new GradeResult("B", 4, "Very Good");
            else if (score >= 50 && score < 60)
                return new GradeResult("C", 3, "Good");
            else if (score >= 40 && score < 50)
                return new GradeResult("D", 2, "Average");
            else if (score >= 30 && score < 40)
                return new GradeResult("E", 1, "Poor");
            else
                return new GradeResult("F", 0, "Fail");
        }
    }
    public class GradeResult
    {
        public string Grade { get; }
        public int GradePoint { get; }
        public string Remark { get; }

        public GradeResult(string grade, int gradePoint, string remark)
        {
            Grade = grade;
            GradePoint = gradePoint;
            Remark = remark;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GPA CALCULATOR\n");
            //Input the number of courses
            Console.WriteLine("Enter the number of courses");
            int numOfCourses = int.Parse(Console.ReadLine());
            List<Course> courses = new List<Course>();
            // input courses
            for (int i = 0; i < numOfCourses; i++)
            {
                Console.WriteLine($"Enter course Details {i + 1}:");

                Course course = new Course();

                Console.Write("Course Title: ");
                course.Title = Console.ReadLine();

                Console.Write("Coourse Code: ");
                course.Code = Console.ReadLine();

                Console.Write("Couse Unit: ");
                course.Unit = int.Parse(Console.ReadLine());

                Console.Write("Score: ");
                course.Score = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");

                course.CalculateGradePointRemark();

                courses.Add(course);
            }
            PrintCourseDetails(courses);
        }
        static void PrintCourseDetails(List<Course> courses)
        {
            //Displaying the output in tabular form 
            string courseTitle = "Course Title";
            Console.WriteLine("\n------------------------------------------------------------------------------");
            Console.WriteLine($"{courseTitle.PadRight(12)} | Course Code | Units | Score | Grade | Grade Point | Remark    |");
            Console.WriteLine("------------------------------------------------------------------------------");

            int totalUnit = 0;
            int totalGradePoint = 0;

            foreach (Course course in courses)
            {
                Console.WriteLine($"{course.Title.PadRight(12)} | {course.Code,-11} |" +
                    $" {course.Unit,-5} | {course.Score,-5} | {course.Grade,-5} | " +
                    $" {course.GradePoint,-11} | {course.Remark.PadRight(9)} |");

                totalUnit += course.Unit;
                totalGradePoint += course.Unit * course.GradePoint;
            }
            double gpa =  (double)totalGradePoint / totalUnit;
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine($"GPA : {Math.Round(gpa, 2)} |".PadLeft(78));
            Console.WriteLine("==============================================================================");

        }
    }
}