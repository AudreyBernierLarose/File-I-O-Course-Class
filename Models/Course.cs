using System;

namespace Week6Course.Models
{
    public class Course
    {
        //PROPERTIES
        public string Code { get; }
        public string Description { get; }
        public string Name { get; }
        public string Prerequsites { get; }
        public int Semester { get; }

        //CONSTRUCTOR(S)
        public Course(string code, string name, string description, string semester, string prerequsites)
        {
            //Assigning arguments to properties
            this.Code = code;
            this.Name = name;
            this.Description = description;
            this.Semester = Convert.ToInt32(semester);
            this.Prerequsites = prerequsites;
            
        }

        //METHOD(S)
        public override string ToString()
        {
            //Constraint for the description length
            if(Description.Length > 60)
                return $"Name: {this.Name}\n" +
                       $"Code: {this.Code}\n" +
                       $"Description: {this.Description.Substring(0,57) + "..."}\n" +
                       $"Prerequisite: {this.Prerequsites}\n" +
                       $"Semester: {this.Semester}\n";
            else
                return $"Name: {this.Name}\n" +
                       $"Code: {this.Code}\n" +
                       $"Description: {this.Description}\n" +
                       $"Prerequisite: {this.Prerequsites}\n" +
                       $"Semester: {this.Semester}\n";
        }
       
    }
}
