namespace OOStepByStep
{
    public class GradeClass
    {
        private string name;
        private Teacher teacher;

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
            if (this.teacher != null)
            {
                throw new OneClassOneTeacherException();
            }

            this.teacher = teacher;
            teacher.SetClass(this);
        }
    }
}