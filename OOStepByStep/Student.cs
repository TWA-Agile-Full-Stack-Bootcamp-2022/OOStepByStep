using OOStepByStepTest;
using System;
using System.Collections.Generic;

namespace OOStepByStep
{
    public class Student : Person
    {
        private Classroom classroom;

        public Student(string name, int age) : base(name, age)
        {
        }

        public Student(string name, int age, Classroom classroom) : this(name, age)
        {
            this.classroom = classroom;
        }

        public override void Introduce()
        {
            var studentInfo = "I am a student";
            if (classroom != null)
            {
                studentInfo += " of class " + classroom.Number;
            }

            Console.WriteLine($"My name is {Name}. I am {Age} years old. {studentInfo}.");
        }
    }
}
