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
                Console.Write($" name students {i + 1}: ");
                studentNames[i] = Console.ReadLine();

                Console.Write($" score students {i + 1}: ");
                studentGrades[i] = Convert.ToDouble(Console.ReadLine());
            }

            // مرتب کردن نمره‌ها به صورت صعودی
            Array.Sort(studentGrades, studentNames);

            // چاپ نام و نمره دانشجوها بر اساس نمره‌های مرتب شده
            Console.WriteLine("Name and grade of students based on ascending grades:");
            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine($"{studentNames[i]} - score: {studentGrades[i]}");
            }

            Console.ReadKey(); // برنامه را منتظر نگه دارید

        }
        //نمرین دوم برنامه ای بنویسید که نام و نمره داشنجو را دریافت و نمره ها را بر اساس صعودی مرتب کند
    }
}



