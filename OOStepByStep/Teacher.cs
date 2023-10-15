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
        }

        public override void Introduce()
        {
            var teacherInfo = "I am a teacher";
            if (classroom != null)
            {
                teacherInfo += " of class " + classroom.Number;
            }

            Console.WriteLine($"My name is {Name}. I am {Age} years old. {teacherInfo}.");
        }
    }
}
