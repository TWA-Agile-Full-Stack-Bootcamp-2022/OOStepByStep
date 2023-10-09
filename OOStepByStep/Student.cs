using System;

namespace OOStepByStep
{
    public class Student : Person, IObserver
    {
        private int? classNumber = null;

        public Student(string name, int age) : base(name, age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; }
        public int Age { get; }

        public override string IntroduceSelf()
        {
            return classNumber != null
                ? $"{base.IntroduceSelf()} I am a student of class {classNumber}."
                : $"{base.IntroduceSelf()} I am a student.";
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
