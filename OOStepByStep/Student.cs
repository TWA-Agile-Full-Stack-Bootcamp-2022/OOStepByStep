using System.Collections.Generic;

namespace OOStepByStep
{
    public class Student : Person
    {
        private GradeClass @class;

        public Student(string name, int age) : base(name, age)
        {
        }

        public string Introduce()
        {
            return this.@class == null
                ? base.Introduce() + " I am a student."
                : base.Introduce() + " I am a student of " + this.@class.GetName() + ".";
        }

        public void SetClass(GradeClass gradeClass)
        {
            this.@class = gradeClass;
        }

        public string Welcome(Student newStudent)
        {
            return this.Introduce() + $" Welcome {newStudent.GetName()} join {@class.GetName()}.";
        }

        public string GetName()
        {
            return this.name;
        }
    }
}