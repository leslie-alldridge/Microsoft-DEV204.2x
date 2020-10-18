using System;
using System.Collections.Generic;

namespace SelfAssessment
{
    class Course
    {
        private string _courseName;
        private List<Student> _currentStudents = new List<Student>();
        public Course(string courseName)
        {
            this._courseName = courseName;
        }

        public void AddStudent(Student student)
        {
            this._currentStudents.Add(student);
            Console.WriteLine($"We have added {student._name} to {this._courseName}");
        }
    }
}
