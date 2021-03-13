using System;
using System.Collections.Generic;
using System.IO;

namespace Week6Course.Models
{
    static class CourseManager
    {
        //FIELDS
        private static List<Course> courses;

        //METHODS

        /* Display(); displays the information searched
         * Two parameters: DisplayOption data type holds the filter chosen
         *               : toMatch holds a search word (optional)
         */

        public static void Display(DisplayOption option, string toMatch = "")
        {
            //If not match, displaying a message to the console
            bool noMatch = false;
            for (int i = 1; i < Enum.GetNames(typeof(DisplayOption)).Length; i++)
                if (!Enum.GetName(typeof(DisplayOption), i).Contains(toMatch))
                    noMatch = true;
                else
                    noMatch = false;

            if (noMatch)
                Console.WriteLine("There is no match for your search.");

            //Loop going through all of the info (items) contained in the courses list
            foreach (Course course in courses)
            {
                //Searching for one of the conditions below to be true
                if (option == DisplayOption.All)
                    Console.WriteLine(course);

                if (option == DisplayOption.Prerequsites && course.Prerequsites.Contains(toMatch))
                    Console.WriteLine(course);
                    
                if (option == DisplayOption.Name && course.Name.Contains(toMatch))
                    Console.WriteLine(course);

                if (option == DisplayOption.Code && course.Code.Contains(toMatch))
                    Console.WriteLine(course);
               
                if (option == DisplayOption.Semester && Convert.ToString(course.Semester).Contains(toMatch))
                    Console.WriteLine(course);
            }
        }   

        public static void LoadCourses(string filename)
        {
            //Opening stream and file
            courses = new List<Course>();
            FileStream file = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);

            //Reading lines from the file, until null
            string line;
            line = reader.ReadLine();
            List<string> inputs = new List<string>();

            while (line != null)
            {
                inputs.Add(line);
                line = reader.ReadLine();
            }

            //Declaring variables for the parameters of the Course constructor
            const int groupMembers = 5;
            int name = 1;
            int code = 0;
            int description = 2;
            int semester = 3;
            int prereq = 4;

            //Assigning values to the parameters of the Course constructor
            for (int i = 0; i < inputs.Count/groupMembers; i++)
            {
                Course course = new Course(inputs[code], inputs[name], inputs[description], inputs[semester], inputs[prereq]);
                courses.Add(course);

                    name += 5;
                    code += 5;
                    description += 5;
                    semester += 5;
                    prereq += 5;
            }

            //Closing stream and file
            file.Close();
            reader.Close();
        }
    }
}
