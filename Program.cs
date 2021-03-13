using System;
using Week6Course.Models;


namespace Week6Course
{
    class Program
    {
        static void Main(string[] args)
        {  

            //TEST HARNESS
            CourseManager.LoadCourses("course.txt");

            Console.WriteLine("\nAll courses");
            CourseManager.Display(DisplayOption.All);

            string toSearch = "COMP100";
            Console.WriteLine("\nWith prerequsite " + toSearch + "\n");
            CourseManager.Display(DisplayOption.Prerequsites, toSearch);

            Console.WriteLine("\nWith title " + toSearch + "\n");
            CourseManager.Display(DisplayOption.Code, toSearch);

            toSearch = "Programing I";
            Console.WriteLine("\nWith name " + toSearch + "\n");
            CourseManager.Display(DisplayOption.Name, toSearch);

            toSearch = "2";
            Console.WriteLine("\nIn semester " + toSearch + "\n");
            CourseManager.Display(DisplayOption.Semester, toSearch);

            //Testing no match
            toSearch = "COMP 100";
            Console.WriteLine("\nWith prerequsite " + toSearch + "\n");
            CourseManager.Display(DisplayOption.Prerequsites, toSearch);
        }
    }
}
