using System.Collections.Generic;

namespace OOStepByStep
{
    public class Class
    {
        private string name;
        private Teacher teacher;
        private List<Student> students;

        public Class(string name)
        {
            this.name = name;
            this.students = new List<Student>();
        }

        public string GetName() => name;

        public void AddTeacher(Teacher teacher)
        {
            this.teacher = teacher;
            teacher.SetClass(this);
        }

        public string AddStudent(Student student)
        {
            student.SetClass(this);

            var result = string.Empty;
            if (this.teacher != null)
            {
                result = this.teacher.Introduce() + $" Welcome {student.GetName()} join {this.name}.";
            }

            students.ForEach(s =>
            {
                result += s.Introduce() + $" Welcome {student.GetName()} join {this.name}.";
            });

            this.students.Add(student);

            return result;
        }
    }
}