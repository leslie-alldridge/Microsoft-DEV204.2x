using System;
using System.Collections.Generic;

namespace SelfAssessment
{
    class Degree
    {
        public string _degree;
        public List<Course> _courses = new List<Course>();

        public Degree()
        {
            this._degree = "Certificate";
        }

        public Degree(string degree)
        {
            this._degree = degree;
        }

        public void AddCourseToDegree(Course course)
        {
            this._courses.Add(course);
            Console.WriteLine($"Added {course._courseName} to {this._degree}");
        }
    }
}
