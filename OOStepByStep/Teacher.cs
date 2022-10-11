using System.Collections.Generic;

namespace OOStepByStep
{
    public class Teacher : Person
    {
        private GradeClass @class;
        public Teacher(string name, int age) : base(name, age)
        {
        }

        public string Introduce()
        {
            return this.@class == null
                ? base.Introduce() + " I am a teacher."
                : base.Introduce() + " I am a teacher of " + this.@class.GetName() + ".";
        }

        public void SetClass(GradeClass gradeClass)
        {
            this.@class = gradeClass;
        }

        public string Welcome(Student newStudent)
        {
            return this.Introduce() + $" Welcome {newStudent.GetName()} join {@class.GetName()}.";
        }
    }
}