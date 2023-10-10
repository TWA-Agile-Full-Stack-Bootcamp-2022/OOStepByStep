namespace OOStepByStepTest
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using OOStepByStep;
    using Xunit;

    public class ClassTest
    {
        public static IEnumerable<object[]> ClassMembers() =>
        new List<object[]>
        {
            new object[]
            {
                2,
                new Teacher("Amy", 30),
                new HashSet<Student>
                {
                    new Student("Tom", 18),
                    new Student("Jim", 19),
                    new Student("Jerry", 20),
                },
                new Student("Harry", 21),
            },
        };

        [Theory]
        [MemberData(nameof(ClassMembers))]
        public void Teacher_of_class_will_say_welcome_words_when_a_new_student_join(int classNumber, Teacher teacher, HashSet<Student> students, Student newStudent)
        {
            // given
            var @class = new Class(classNumber, teacher, students);
            var fakeOutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeOutput));
            HashSet<Student> studentsBeforeAction = new HashSet<Student>(students);

            // when
            @class.AddNewStudent(newStudent);

            // then
            Assert.Equal(studentsBeforeAction.Count + 1, @class.Students.Count);
            Assert.Contains($"My name is {teacher.Name}. I am {teacher.Age} years old. I am a teacher of class {classNumber}. Welcome {newStudent.Name} join class 2.",
                fakeOutput.ToString());
        }

        [Theory]
        [MemberData(nameof(ClassMembers))]
        public void Other_students_in_this_class_will_say_welcome_words_when_a_new_student_join(int classNumber, Teacher teacher, HashSet<Student> students, Student newStudent)
        {
            // given
            var @class = new Class(classNumber, teacher, students);
            var fakeOutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeOutput));
            HashSet<Student> studentsBeforeAction = new HashSet<Student>(students);

            // when
            @class.AddNewStudent(newStudent);

            // then
            Assert.Equal(studentsBeforeAction.Count + 1, @class.Students.Count);
            foreach (var student in studentsBeforeAction)
            {
                Assert.Contains($"My name is {student.Name}. I am {student.Age} years old. I am a student of class {classNumber}. Welcome {newStudent.Name} join class 2.",
                    fakeOutput.ToString());
            }

            Assert.DoesNotContain($"My name is {newStudent.Name}. I am {newStudent.Age} years old. I am a student of class {classNumber}. Welcome {newStudent.Name} join class 2.",
                    fakeOutput.ToString());
        }
    }
}
