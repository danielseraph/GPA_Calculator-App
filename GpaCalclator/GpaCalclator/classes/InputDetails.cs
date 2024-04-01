using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GpaCalclator.classes
{
    public class InputDetails
    {
        public static List<Course> GetCoursesFromUser()
        {
            List<Course> courses = new List<Course>();

            Console.WriteLine("Enter number of courses:"); 
            int numberOfCourses = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCourses; i++)
            {
                Console.WriteLine($"Enter details for Course {i + 1}:");
                Console.Write("Title: ");
                string title = Console.ReadLine();
                Console.Write("Code: ");
                string code = Console.ReadLine();
                Console.Write("Units: ");
                int units = int.Parse(Console.ReadLine());
                Console.Write("Score: ");
                int score = int.Parse(Console.ReadLine());

                courses.Add(new Course(title, code, units, score));
            }

            return courses;
        }
    }
       
}
