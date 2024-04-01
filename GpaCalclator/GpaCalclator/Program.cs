using GpaCalclator.classes;
using static GpaCalclator.classes.InputDetails;

namespace GpaCalclator
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Course> courses = InputDetails.GetCoursesFromUser();
            double gpa = GpaCalculator.CalculateGpa(courses);
            OutputFormatter.DisplayResults(courses, gpa);

        }
    }
}
