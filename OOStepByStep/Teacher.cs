namespace OOStepByStep
{
    public class Teacher : Person
    {
        public Teacher(string name, int age) : base(name, age)
        {
        }

        public new string IntroduceSelf()
        {
            return base.IntroduceSelf() + " I am a teacher.";
        }
    }
}