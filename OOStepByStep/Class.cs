namespace OOStepByStep
{
    public class Class
    {
        private Teacher teacher;

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
    }
}