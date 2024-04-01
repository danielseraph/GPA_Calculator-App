using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GpaCalclator.classes
{
    public class GpaCalculator
    {
        public static double CalculateGpa(List<Course> courses)
        {
            int totalUnits = 0;
            int totalGradePoints = 0;

            foreach (var course in courses)
            {
                totalUnits += course.Units;
                totalGradePoints += course.GradePoint * course.Units;
            }

            return (double)totalGradePoints / totalUnits;
        }
    }
}
