using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Letter Grade Converter!");
            bool parsedGradeOne;
            char userContinue;
            int studentGrade;
            do
            {

                do
                {
                    Console.Write("Enter a numerical grade: ");
                    string studentGradeString = Console.ReadLine();

                    parsedGradeOne = int.TryParse(studentGradeString, out studentGrade);
                } while (!parsedGradeOne);

                var findGrade = new Grade();
                findGrade.FindGrade(studentGrade);
                Console.Write("Would you like to enter another grade? (y/n)   ");
                userContinue = Console.ReadKey().KeyChar;

            } while (userContinue.ToString().ToLower() == "y");

            Console.ReadKey();
        }
    }
        public class Grade
        {

            public string FindGrade(int studentGrade)
            {
                
                string gradeA, gradeB, gradeC, gradeD, gradeF;
                
                gradeA = "A";
                gradeB = "B";
                gradeC = "C";
                gradeD = "D";
                gradeF = "F";


                if (studentGrade >= 88 && studentGrade <= 100)
                {
                    Console.WriteLine($"Letter Grade: {gradeA}");
                return gradeA;
                }
                else if (studentGrade >= 80 && studentGrade <= 87)
                {
                    Console.WriteLine($"Letter Grade: {gradeB}");
                return gradeB;
                }
                else if (studentGrade >= 67 && studentGrade <= 79)
                {
                    Console.WriteLine($"Letter Grade: {gradeC}");
                return gradeC;
                }
                else if (studentGrade >= 60 && studentGrade <= 66)
                {
                    Console.WriteLine($"Letter Grade: {gradeD}");
                return gradeD;
                }
                else if (studentGrade >= 0 && studentGrade < 60)
                {
                    Console.WriteLine($"Letter Grade: {gradeF}");
                return gradeF;
                }
                else
                {
                    Console.WriteLine("Not a valid grade!");
                return "Not a valid grade!";
                }

            }
        }
    }

