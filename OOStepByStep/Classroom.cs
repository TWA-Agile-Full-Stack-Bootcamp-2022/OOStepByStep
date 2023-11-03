using OOStepByStep;
using System;
using System.Collections.Generic;

namespace OOStepByStepTest
{
    public class Classroom
    {
        private List<IClassroomObserver> observers = new List<IClassroomObserver>();
        public Classroom(int number)
        {
            RoomNumber = number;
        }

        public int RoomNumber { get; set; }

        public void Join(IClassroomObserver observer)
        {
            if (observer is Student)
            {
                Student studentJoined = observer as Student;
                studentJoined.ClassroomNumber = RoomNumber;
                NotifyStudentJoin(studentJoined.Name);
            }

            if (observer is Teacher)
            {
                Teacher teacherJoined = observer as Teacher;
                teacherJoined.ClassroomNumber = RoomNumber;
            }

            observers.Add(observer);
        }

        public void NotifyStudentJoin(string studentName)
        {
            observers.ForEach(observer => observer.OnStudentJoined(studentName));
        }
    }
}