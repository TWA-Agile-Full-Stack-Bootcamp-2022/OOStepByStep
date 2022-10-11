namespace OOStepByStep
{
    public class Student : Person
    {
        public Student(string name, int age) : base(name, age)
        {
        }

        public new string IntroduceSelf()
        {
            return base.IntroduceSelf() + " I am a student.";
        }
    }
}