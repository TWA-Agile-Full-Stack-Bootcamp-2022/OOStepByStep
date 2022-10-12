namespace OOStepByStep
{
    public class Student : Person
    {
        private int classNumber;

        public Student(string name, int age) : base(name, age)
        {
        }

        public override string IntroduceSelf()
        {
            return classNumber > 0
                ? $"{base.IntroduceSelf()} I am a student of class {classNumber}."
                : $"{base.IntroduceSelf()} I am a student.";
        }

        public void JoinClass(Class clss)
        {
            this.classNumber = clss.ClassNumber;
        }
    }
}