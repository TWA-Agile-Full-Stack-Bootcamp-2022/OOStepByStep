using System;

namespace OOStepByStep
{
    public class Student : Person, IClassroomObserver
    {
        private const int NO_CLASSROOM = 0;

        public Student(string name, int age) : base(name, age)
        {
        }

        public int ClassroomNumber { get; set; }

        public void OnStudentJoined(string name)
        {
            Console.WriteLine(BuildIntroductionInfo() + $" Welcome {name} join class {ClassroomNumber}.");
        }

        public override string BuildIntroductionInfo()
        {
            var studentInfo = "I am a student";
            if (ClassroomNumber != NO_CLASSROOM)
            {
                studentInfo += " of class " + ClassroomNumber;
            }

            string introduceInfo = $"My name is {Name}. I am {Age} years old. {studentInfo}.";
            return introduceInfo;
        }
    }
}
