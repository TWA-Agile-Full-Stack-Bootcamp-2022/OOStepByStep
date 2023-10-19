using OOStepByStepTest;
using System;
using System.Collections.Generic;

namespace OOStepByStep
{
    public class Teacher : Person, IClassroomObserver
    {
        private const int NO_CLASSROOM = 0;

        public Teacher(string name, int age) : base(name, age)
        {
        }

        public int ClassroomNumber { get; set; }

        public void OnStudentJoined(string name)
        {
            Console.WriteLine(BuildIntroductionInfo() + $" Welcome {name} join class {ClassroomNumber}.");
        }

        public override string BuildIntroductionInfo()
        {
            var teacherInfo = "I am a teacher";
            if (ClassroomNumber != NO_CLASSROOM)
            {
                teacherInfo += " of class " + ClassroomNumber;
            }

            return $"My name is {Name}. I am {Age} years old. {teacherInfo}.";
        }
    }
}
