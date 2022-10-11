namespace OOStepByStep
{
    public class Teacher : Person
    {
        private Class classClass;
        public Teacher(string name, int age) : base(name, age)
        {
        }

        public Teacher(string name, int age, Class classClass) : base(name, age)
        {
            this.classClass = classClass;
        }

        public new string IntroduceSelf()
        {
            return $"{base.IntroduceSelf()} I am a teacher of class {classClass.GetName()}.";
        }

        public string WelcomeNewStudent(Student student)
        {
            return this.IntroduceSelf() + " Welcome " + student.GetName() + " join class 2.";
        }
    }
}