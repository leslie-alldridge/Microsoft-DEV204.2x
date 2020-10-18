using System;

namespace SelfAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            var infoTech = new UProgram("Information Technology");
            var student1 = new Student("Leslie", 2010);
            var student2 = new Student("Amanda", 2011);
            var student3 = new Student("Lisa", 2009);

            var course = new Course("Programming with C#");
            course.AddStudent(student1);
            course.AddStudent(student2);
            course.AddStudent(student3);
        }
    }
}
