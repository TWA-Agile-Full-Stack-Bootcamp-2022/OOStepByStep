using System;
using System.Collections.Generic;

namespace OOStepByStep
{
    public class Class
    {
        private Teacher teacher;
        private List<Student> students;

        public Class(int classNumber)
        {
            this.ClassNumber = classNumber;
            this.teacher = null;
            this.students = new List<Student>();
        }

        public Teacher Teacher
        {
            get => this.teacher;

            set
            {
                this.teacher = value;
                this.teacher.JoinClass(this);
            }
        }

        public int ClassNumber { get; set; }

        public List<Student> Students
        {
            get => this.students;

            set
            {
                this.students = value;
                foreach (var student in this.students)
                {
                    student.JoinClass(this);
                }
            }
        }

        public void AddNewStudent(Student student)
        {
            this.students.Add(student);

            Console.WriteLine(this.teacher.Welcome(student));
        }
    }
}