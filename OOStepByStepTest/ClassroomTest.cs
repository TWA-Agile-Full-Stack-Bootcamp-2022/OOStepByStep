using OOStepByStep;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace OOStepByStepTest
{
    public class ClassroomTest
    {
        [Fact]
        public void Should_teacher_say_welcom_when_student_join_the_classroom()
        {
            // Given
            int givenClassroomNumber = 2;
            Classroom classroom = new Classroom(givenClassroomNumber);
            Teacher teacher = new Teacher("Amy", 30, classroom);
            var newJoinedStudent = new Student("Tom", 21);

            var fakeOutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeOutput));

            // When
            classroom.AddStudent(newJoinedStudent);

            // Then
            string actual = fakeOutput.ToString();
            Assert.Equal($"My name is {teacher.Name}. I am {teacher.Age} years old. " +
                $"I am a teacher of class {givenClassroomNumber}. " +
                $"Welcome {newJoinedStudent.Name} join class {givenClassroomNumber}.\r\n", actual);
        }

        [Fact]
        public void Should_joined_student_say_welcom_when_student_join_the_classroom()
        {
            // Given
            int givenClassroomNumber = 2;
            Classroom classroom = new Classroom(givenClassroomNumber);
            var joinedStudent = new Student("Tom", 18, classroom);
            var newJoinedStudent = new Student("Jim", 18);

            var fakeOutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeOutput));

            // When
            classroom.AddStudent(newJoinedStudent);

            // Then
            string actual = fakeOutput.ToString();
            Assert.Equal($"My name is {joinedStudent.Name}. I am {joinedStudent.Age} years old. " +
                $"I am a student of class {givenClassroomNumber}. " +
                $"Welcome {newJoinedStudent.Name} join class {givenClassroomNumber}.\r\n", actual);
        }
    }
}
