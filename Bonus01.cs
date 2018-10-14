using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Letter Grade Converter!");

            Console.Write("Enter a numerical grade: ");
            String studentGradeString = Console.ReadLine();

            bool parsedGradeOne = int.TryParse(studentGradeString, out int studentGrade);

            String gradeA, gradeB, gradeC, gradeD, gradeF;

            gradeA = "A";
            gradeB = "B";
            gradeC = "C";
            gradeD = "D";
            gradeF = "F";


            if (studentGrade >= 88 && studentGrade <= 100)
            {
                Console.WriteLine($"Letter Grade: {gradeA}");
            }
            else if (studentGrade >= 80 && studentGrade <= 87)
            {
                Console.WriteLine($"Letter Grade: {gradeB}");
            }
            else if (studentGrade >= 67 && studentGrade <=79)
            {
                Console.WriteLine($"Letter Grade: {gradeC}");
            }
            else if (studentGrade >= 60 && studentGrade <= 66)
            {
                Console.WriteLine($"Letter Grade: {gradeD}");
            }
            else if (studentGrade >= 0 && studentGrade < 60)
            {
                Console.WriteLine($"Letter Grade: {gradeF}");
            }
            else
            {
                Console.WriteLine("Not a valid grade!");
            }

            Console.Write("Continue? (y/n): ");
            Console.ReadLine();

            

            Console.ReadKey(); 






        }
    }
}
