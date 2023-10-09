using System.Collections.Generic;
using System.Linq;

namespace OOStepByStep
{
    public class Class
    {
        private readonly int classNumber;
        private Teacher teacher;
        private HashSet<Student> students;

        public Class(int classNumber, Teacher teacher, HashSet<Student> students)
        {
            this.classNumber = classNumber;
            // NOTE: use Teacher and Student could get the benefit of private set method
            this.Teacher = teacher;
            this.Students = students;
        }

        public Teacher Teacher
        {
            get => teacher;

            private set
            {
                this.teacher = value;
                teacher.JoinClass(classNumber);
            }
        }

        public HashSet<Student> Students
        {
            get => students;

            private set
            {
                this.students = value;
                foreach (var student in students)
                {
                    student.JoinClass(classNumber);
                }
            }
        }

        public void AddNewStudent(Student newStudent)
        {
            if (!students.Contains(newStudent))
            {
                NotifyObservers(newStudent);
                students.Add(newStudent);
            }
        }

        private void NotifyObservers(Student newStudent)
        {
            List<IObserver> observers = new List<IObserver>() { teacher }.Concat(students).ToList();
            foreach (var observer in observers)
            {
                observer.OnStudentJoined(newStudent);
            }
        }
    }
}
