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
        }

        public Classroom Classroom { get; set; }

        public override void Introduce()
        {
            var studentInfo = "I am a student";
            if (Classroom != null)
            {
                studentInfo += " of class " + Classroom.Number;
            }

            Console.WriteLine($"My name is {Name}. I am {Age} years old. {studentInfo}.");
        }
    }
}
