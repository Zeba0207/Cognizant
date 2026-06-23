namespace MVCPattern
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Grade { get; set; }

        public Student(int id, string name, string grade)
        {
            Id = id;
            Name = name;
            Grade = grade;
        }
    }
}