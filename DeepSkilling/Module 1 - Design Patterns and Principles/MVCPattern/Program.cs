namespace MVCPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(101, "Zeba", "A");

            StudentView view = new StudentView();

            StudentController controller =
                new StudentController(student, view);

            controller.UpdateView();

            controller.SetStudentName("Fathima");
            controller.SetStudentGrade("A+");

            System.Console.WriteLine("\nAfter Update:\n");

            controller.UpdateView();
        }
    }
}