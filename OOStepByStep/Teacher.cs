namespace OOStepByStep
{
    public class Teacher : Person
    {
        private int classNumber = 0;

        public Teacher(string name, int age) : base(name, age)
        {
        }

        public override string IntroduceSelf()
        {
            return classNumber > 0
                ? $"{base.IntroduceSelf()} I am a teacher of class {classNumber}."
                : $"{base.IntroduceSelf()} I am a teacher.";
        }

        public void JoinClass(Class clss)
        {
            this.classNumber = clss.ClassNumber;
        }

        public string Welcome(Student newStudent)
        {
            return IntroduceSelf() + $" Welcome {newStudent.Name} join class {classNumber}.";
        }
    }
}