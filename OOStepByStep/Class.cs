namespace OOStepByStep
{
    public class Class
    {
        private Teacher teacher;
        private Student[] students;

        public Class(int classNumber)
        {
            this.ClassNumber = classNumber;
        }

        public Teacher Teacher
        {
            get => this.teacher;

            set
            {
                this.teacher = value;
                this.teacher.JoinClass(this);
            }
        }

        public int ClassNumber { get; set; }

        public Student[] Students
        {
            get => this.students;

            set
            {
                this.students = value;
                foreach (var student in this.students)
                {
                    student.JoinClass(this);
                }
            }
        }
    }
}