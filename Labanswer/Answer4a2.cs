using System;
using System.Collections.Generic;

namespace BANKAI
{
    public class Answer4
    {
        public static void AnswerQuestion4()
        {
            int[] valueNumber = new int[] { 10, 20, 30, 40, 50, 60, 70, 80 };
            Number numbers = new Number(valueNumber);

            string[] valueLetter = new string[] { "D", "D", "D", "C", "C", "B", "B", "A" };
            Letter letters = new Letter(valueLetter);

            //  Call the generic method twice
            printGrade<Number>(numbers);
            printGrade<Letter>(letters);
        }

        // Generic method: T must implement Grade interface
        public static void printGrade<T>(T obj) where T : Grade
        {
            obj.CalculatePoint();
        }
    }

    // Interface definition
    public interface Grade
    {
        void CalculatePoint(); // Must be implemented
    }

    // Number class implements Grade
    public class Number : Grade
    {
        int[] numbers;

        public Number(int[] numbers)
        {
            this.numbers = numbers;
        }

        public void CalculatePoint()
        {
            double total = 0;

            foreach (int mark in numbers)
            {
                if (mark >= 80 && mark <= 100)
                    total += 4.00;
                else if (mark >= 60)
                    total += 3.00;
                else if (mark >= 40)
                    total += 2.00;
                else
                    total += 0.00;
            }

            double gpa = total / numbers.Length;
            Console.WriteLine("GPA from numbers: " + gpa.ToString("0.00"));
        }
    }

    //  Letter class implements Grade
    public class Letter : Grade
    {
        string[] letters;

        public Letter(string[] letters)
        {
            this.letters = letters;
        }

        public void CalculatePoint()
        {
            double total = 0;

            foreach (string grade in letters)
            {
                switch (grade.ToUpper())
                {
                    case "A":
                        total += 4.00;
                        break;
                    case "B":
                        total += 3.00;
                        break;
                    case "C":
                        total += 2.00;
                        break;
                    case "D":
                    default:
                        total += 0.00;
                        break;
                }
            }

            double gpa = total / letters.Length;
            Console.WriteLine("GPA from letters: " + gpa.ToString("0.00"));
        }
    }
}
