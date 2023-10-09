using System;

namespace OOStepByStep
{
    public class Teacher : Person, IObserver
    {
        private int? classNumber = null;

        public Teacher(string name, int age) : base(name, age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; }
        public int Age { get; }

        public override string IntroduceSelf()
        {
            return classNumber != null
                ? $"{base.IntroduceSelf()} I am a teacher of class {classNumber}."
                : $"{base.IntroduceSelf()} I am a teacher.";
        }

        public void JoinClass(int classNumber)
        {
            this.classNumber = classNumber;
        }

        public void OnStudentJoined(Student newStudent)
        {
            Console.WriteLine($"{IntroduceSelf()} Welcome {newStudent.Name} join class {classNumber}.");
        }
    }
}
