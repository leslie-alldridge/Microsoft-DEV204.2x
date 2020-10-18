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
            var course2 = new Course("Programming with F#");
            course.AddStudent(student1);
            course.AddStudent(student2);
            course.AddStudent(student3);

            course2.AddStudent(student1);

            var teacher = new Teacher("Mr Kaplan");
            course.AddTeacher(teacher);

            var degree = new Degree("Bachelor");
            degree.AddCourseToDegree(course);
            degree.AddCourseToDegree(course2);

            infoTech.AddDegree(degree);

            Console.WriteLine($"Program: {infoTech._programName} contains degree: {degree._degree}");

            foreach (Course courseItem in degree._courses)
            {
                Console.WriteLine($"The name of the course in the degree: {courseItem._courseName} with {courseItem._currentStudents.Count} students.");
            }


        }
    }
}
