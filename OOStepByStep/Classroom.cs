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
            Students.Add(newJoinedStudent);
            newJoinedStudent.Classroom = this;
            Teacher.IntroduceAndWelcome(newJoinedStudent.Name);
        }
    }
}