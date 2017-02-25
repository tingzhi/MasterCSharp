using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

/*
    Requirement: An electronic grade book to read the scores of an individual student 
    and then compute some statistics from the scores.

    The grades are entered as floating point numbers from 0 to 100, and the statistics
    should show us the highest grade, the lowest grade, and the average grade.

    Keywords: grade book, add grade, and compute statistics.
*/

namespace Grades
{
    class Program
    {     
        static void Main(string[] args)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("Hello!");

            Arrays();


            //GradeBook book = new GradeBook();   // Create a GradeBook object
            //book.AddGrade(91f);
            //book.AddGrade(89.5f);
            //book.AddGrade(75f);

            //GradeStatistics stats = book.ComputerStatistics();
            //Console.WriteLine(stats.AverageGrade);
            //Console.WriteLine(stats.HighestGrade);
            //Console.WriteLine(stats.LowestGrade);
        }

        private static void Arrays()
        {
            float[] grades;  // List<float> _grades
            grades = new float[3];

            AddGrades(grades);

            foreach (float grade in grades)
            {
                Console.WriteLine(grade);
            }
        }

        private static void AddGrades(float[] grades)
        {
            grades[0] = 91f;
            grades[1] = 98f;
            grades[2] = 86f;
        }

    }
}
