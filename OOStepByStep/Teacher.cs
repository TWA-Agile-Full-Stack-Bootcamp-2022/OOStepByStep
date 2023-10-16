namespace OOStepByStep
{
    public class Teacher : Person
    {
        public Teacher(string name, int age) : base(name, age)
        {
        }

        public string Introduce()
        {
            return base.Introduce() + " I am a teacher.";
        }
    }
}