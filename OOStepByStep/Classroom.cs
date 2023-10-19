using OOStepByStep;
using System;
using System.Collections.Generic;

namespace OOStepByStepTest
{
    public class Classroom
    {
        public Classroom(int number)
        {
            Number = number;
        }

        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();

        public int Number { get; set; }

        public void AddTeacher(Teacher teacher)
        {
            Teacher = teacher;
            teacher.ClassroomNumber = Number;
        }

        public void AddStudent(Student newJoinedStudent)
        {
            newJoinedStudent.ClassroomNumber = Number;
            if (Teacher != null)
            {
                Teacher.OnStudentJoined(newJoinedStudent.Name);
            }

            foreach (var student in Students)
            {
               student.OnStudentJoined(newJoinedStudent.Name);
            }

            Students.Add(newJoinedStudent);
        }
    }
}