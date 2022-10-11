namespace OOStepByStep
{
    public class GradeClass
    {
        private string name;

        public GradeClass(string name)
        {
            this.name = name;
        }

        public void JoinStudent(Student student)
        {
            student.SetClass(this);
        }

        public string GetName()
        {
            return this.name;
        }

        public void JoinTeacher(Teacher teacher)
        {
            teacher.SetClass(this);
        }
    }
}