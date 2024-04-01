using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GpaCalclator.classes
{
    public class OutputFormatter
    {
        public static void DisplayResults(List<Course> courses, double gpa)
        {
            Console.WriteLine(new string ('-',87));
            Console.WriteLine("Course Title  |Course Code  |Units     |Score    |Grade     |Grade Point   |Remark    |");
            Console.WriteLine(new string('-',87));
            

            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Title,-13} | {course.Code,-11} | {course.Units,-8} | {course.Score,-7} | {course.Grade,-8} | {course.GradePoint,-12} | {course.Remark,-8} |");
                //Console.WriteLine(new string('-', 75));-
                
            }

            Console.WriteLine(new string('-', 87));
            Console.WriteLine($"GPA: {gpa}");
            Console.WriteLine(new string ('-',87));
        }
    }
}
