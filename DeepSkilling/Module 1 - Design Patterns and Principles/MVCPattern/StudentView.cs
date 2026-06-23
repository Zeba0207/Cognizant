using System;

namespace MVCPattern
{
    public class StudentView
    {
        public void DisplayStudentDetails(Student student)
        {
            Console.WriteLine("Student Details:");
            Console.WriteLine($"ID: {student.Id}");
            Console.WriteLine($"Name: {student.Name}");
            Console.WriteLine($"Grade: {student.Grade}");
        }
    }
}