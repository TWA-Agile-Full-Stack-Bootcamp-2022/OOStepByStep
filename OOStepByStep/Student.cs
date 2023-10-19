using OOStepByStepTest;
using System;
using System.Collections.Generic;

namespace OOStepByStep
{
    public class Student : Person
    {
        public Student(string name, int age) : base(name, age)
        {
        }

        public Student(string name, int age, Classroom classroom) : this(name, age)
        {
            Classroom = classroom;
            classroom.Students.Add(this);
        }

        public Classroom Classroom { get; set; }

        public override string Introduce()
        {
            string introduceInfo = BuildSelfIntroduction();
            return introduceInfo;
        }

        public void IntroduceAndWelcome(string name)
        {
            Console.WriteLine(BuildSelfIntroduction() + $" Welcome {name} join class {Classroom.Number}.");
        }

        private string BuildSelfIntroduction()
        {
            var studentInfo = "I am a student";
            if (Classroom != null)
            {
                studentInfo += " of class " + Classroom.Number;
            }

            string introduceInfo = $"My name is {Name}. I am {Age} years old. {studentInfo}.";
            return introduceInfo;
        }
    }
}
