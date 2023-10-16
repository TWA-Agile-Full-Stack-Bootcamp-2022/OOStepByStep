namespace OOStepByStep
{
    public class Student : Person
    {
        public Student(string name, int age) : base(name, age)
        {
        }

        public new string Introduce()
        {
            return base.Introduce() + " I am a student.";
        }
    }
}