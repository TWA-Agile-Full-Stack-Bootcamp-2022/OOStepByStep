namespace OOStepByStep
{
    public class Student : Person
    {
        private Class classClass;
        public Student(string name, int age) : base(name, age)
        {
        }

        public Student(string name, int age, Class classClass) : base(name, age)
        {
            this.classClass = classClass;
        }

        public new string IntroduceSelf()
        {
            return $"{base.IntroduceSelf()} I am a student of class {classClass.GetName()}.";
        }

        public string WelcomeNewStudent(Student student)
        {
            return this.IntroduceSelf() + " Welcome " + student.GetName() + " join class 2.";
        }
    }
}