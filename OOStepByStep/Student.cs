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

        public new string Introduce()
        {
            if (classClass != null)
            {
                return base.Introduce() + $" I am a student of {classClass.GetName()}.";
            }

            return base.Introduce() + " I am a student.";
        }
    }
}