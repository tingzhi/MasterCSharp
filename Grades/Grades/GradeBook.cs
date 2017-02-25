using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// General structure: constructors, methods, and fields.
namespace Grades
{
    public class GradeBook
    {
        /* State or Behavior*/
        /*
           State: The grades a user entered
           Behavior: Add a new grade or Calculate statistics        
        */

        public GradeBook()
        {
            _grades = new List<float>();    // Initiate floating point list
        }

        public void AddGrade(float grade)       // This is a method
        {
            if (grade >= 0 && grade <= 100)
            {
                _grades.Add(grade);
            }
        }

        public GradeStatistics ComputerStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            float sum = 0f;

            foreach(float grade in _grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }

            stats.AverageGrade = sum / _grades.Count;
            return stats;
        }

        // This is a field
        public string Name;
        private List<float> _grades;    // List needs to be constructed first, see GradeBook constructor

        /* A list of floating point numbers. 
  Internal variable starts with a _ and lower-case first letter.
*/
    }
}
