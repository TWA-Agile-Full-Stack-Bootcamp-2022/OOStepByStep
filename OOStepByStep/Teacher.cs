using OOStepByStepTest;
using System;
using System.Collections.Generic;

namespace OOStepByStep
{
    public class Teacher : Person
    {
        private Classroom classroom;

        public Teacher(string name, int age) : base(name, age)
        {
        }

        public Teacher(string name, int age, Classroom classroom) : this(name, age)
        {
            this.classroom = classroom;
            classroom.Teacher = this;
        }

        public override string Introduce()
        {
            string introduceInfo = BuildSelfIntroduction();
            return introduceInfo;
        }

        public void IntroduceAndWelcome(string joinedStudentName)
        {
            Console.WriteLine(BuildSelfIntroduction() + $" Welcome {joinedStudentName} join class {classroom.Number}.");
        }

        private string BuildSelfIntroduction()
        {
            var teacherInfo = "I am a teacher";
            if (classroom != null)
            {
                teacherInfo += " of class " + classroom.Number;
            }

            string introduceInfo = $"My name is {Name}. I am {Age} years old. {teacherInfo}.";
            return introduceInfo;
        }
    }
}
