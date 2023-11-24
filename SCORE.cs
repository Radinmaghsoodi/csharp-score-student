
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
// تعداد دانشجویان
            int numberOfStudents = 5;

            // آرایه‌ها برای نام و نمره دانشجوها
            string[] studentNames = new string[numberOfStudents];
            double[] studentGrades = new double[numberOfStudents];

            // وارد کردن نام و نمره برای هر دانشجو
            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.Write($"name Student {i + 1}: ");
                studentNames[i] = Console.ReadLine();

                Console.Write($"SCORE Student {i + 1}: ");
                studentGrades[i] = Convert.ToDouble(Console.ReadLine());
            }

            // یافتن کمترین و بیشترین نمره
            double minGrade = studentGrades[0];
            double maxGrade = studentGrades[0];
            int minIndex = 0;
            int maxIndex = 0;

            for (int i = 1; i < numberOfStudents; i++)
            {
                if (studentGrades[i] < minGrade)
                {
                    minGrade = studentGrades[i];
                    minIndex = i;
                }

                if (studentGrades[i] > maxGrade)
                {
                    maxGrade = studentGrades[i];
                    maxIndex = i;
                }
            }

            // چاپ نام و نمره دانشجو با کمترین نمره
            Console.WriteLine($"Student min: {studentNames[minIndex]} - Score: {minGrade}");

            // چاپ نام و نمره دانشجو با بیشترین نمره
            Console.WriteLine($"Student mix: {studentNames[maxIndex]} - Score: {maxGrade}");

            Console.ReadLine(); // برنامه را منتظر نگه دارید

        }
    }
}