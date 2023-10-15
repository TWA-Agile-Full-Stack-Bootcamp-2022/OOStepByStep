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

        public void AddStudent(Student newJoinedStudent)
        {
            newJoinedStudent.Classroom = this;
            if (Teacher != null)
            {
                Teacher.IntroduceAndWelcome(newJoinedStudent.Name);
            }

            foreach (var student in Students)
            {
                student.IntroduceAndWelcome(newJoinedStudent.Name);
            }

            Students.Add(newJoinedStudent);
        }
    }
}