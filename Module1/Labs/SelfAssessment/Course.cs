using System;
using System.Collections.Generic;

namespace SelfAssessment
{
    class Course
    {
        public string _courseName;
        public List<Student> _currentStudents = new List<Student>();
        private Teacher teacher;
        public Course(string courseName)
        {
            this._courseName = courseName;
        }

        public void AddStudent(Student student)
        {
            this._currentStudents.Add(student);
            Console.WriteLine($"We have added {student._name} to {this._courseName}");
        }

        public void AddTeacher(Teacher teacher)
        {
            this.teacher = teacher;
            Console.WriteLine($"We have added {teacher._name} to {this._courseName}");
        }
    }
}
