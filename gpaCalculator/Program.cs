using System;
using System.Collections.Generic;

namespace gpaCalculator
{
    class Courses
    {
        public string Title { get; set; }
        public string Code { get; set; }
        public int Units { get; set; }
        public int Score { get; set; }
        public string Grade { get; set; }
        public int GradePoint { get; set; }
        public string Remark { get; set; }

        // Method of getting the GradePoint and R/.emark 
        public void CalculatingGradepointAndRemark()
        {
            if(Score >= 70)
            {
                Grade = "A";
                GradePoint = 5;
                Remark = "Exellence";
            }
            else if(Score >= 60 && Score < 70)
            {
                Grade = "B";
                GradePoint = 4;
                Remark= "Very Good";
            }
            else if( Score >= 50 && Score < 60)
            {
                Grade = "C";
                GradePoint = 3;
                Remark = "Good";
            }
            else if (Score >= 40 && Score < 50)
            {
                Grade = "D";
                GradePoint = 2;
                Remark = "Average";
            }
            else if ( Score >= 30 && Score < 40)
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
    public class Program
    {
        static void Main(string[] args)
        {
            //TITLE
            Console.WriteLine("GPA CALCULATOR\n");
            //Enter the number of courses 
            Console.WriteLine("Enter the number of courses");
            int numOfCourse = int.Parse(Console.ReadLine());
            List<Courses> list = new List<Courses>();

            //Inputing the courses 
            for(int i = 0; i < numOfCourse; i++)
            {
                Console.WriteLine($"\nEnter details for Course {i + 1}:");
                //Creating an Object 
                Courses course = new Courses();

                Console.Write("Course Title: ");
                course.Title = Console.ReadLine();

                Console.Write("Couse Code: ");
                course.Code = Console.ReadLine();

                Console.Write("Course Unit: ");
                course.Units = int.Parse(Console.ReadLine());

                Console.Write("Score: ");
                course.Score = int.Parse(Console.ReadLine());

                course.CalculatingGradepointAndRemark();

                list.Add(course);

            }
            //out Details
     
            String courseTitle = "Course Title";

            Console.WriteLine("\n------------------------------------------------------------------------------");
            Console.WriteLine($"{courseTitle.PadRight(12)} | Course Code | Units | Score | Grade | Grade Point | Remark    |");
            Console.WriteLine("------------------------------------------------------------------------------");

            int totalunit = 0;
            int totalGradePoint = 0;

            int spacewidth = 9;

            foreach (Courses course in list)
            {
                Console.WriteLine($"{course.Title.PadRight(12)} | {course.Code,-11} | {course.Units,-5} | {course.Score,-5} | {course.Grade,-5} | {course.GradePoint,-11} | {course.Remark.PadRight(spacewidth)} |");

                totalunit += course.Units;
                totalGradePoint += course.Units * course.GradePoint;
            }

            double gpa = (double)totalGradePoint / totalunit;


            int spaceWidth = 78; 
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine($"GPA : {Math.Round(gpa,2)} |".PadLeft(spaceWidth));
            Console.WriteLine("==============================================================================");



        }
    }
}
