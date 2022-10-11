using System.Collections.Generic;

namespace OOStepByStep
{
    public class GradeClass
    {
        private string name;
        private Teacher teacher;
        private List<Student> students;

        public GradeClass(string name)
        {
            this.name = name;
            this.students = new List<Student>();
        }

        public string JoinStudent(Student student)
        {
            var welcomes = string.Empty;
            if (this.teacher != null)
            {
                welcomes += this.teacher.Welcome(student);
                welcomes += "\n";
            }

            foreach (var t in students)
            {
                welcomes += t.Welcome(student);
                welcomes += "\n";
            }

            student.SetClass(this);
            this.students.Add(student);

            return welcomes;
        }

        public string GetName()
        {
            return this.name;
        }

        public void JoinTeacher(Teacher teacher)
        {
            if (this.teacher != null)
            {
                throw new OneClassOneTeacherException();
            }

            this.teacher = teacher;
            teacher.SetClass(this);
        }
    }
}