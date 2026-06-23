namespace MVCPattern
{
    public class StudentController
    {
        private Student model;
        private StudentView view;

        public StudentController(Student model, StudentView view)
        {
            this.model = model;
            this.view = view;
        }

        public void SetStudentName(string name)
        {
            model.Name = name;
        }

        public void SetStudentGrade(string grade)
        {
            model.Grade = grade;
        }

        public Student GetStudent()
        {
            return model;
        }

        public void UpdateView()
        {
            view.DisplayStudentDetails(model);
        }
    }
}