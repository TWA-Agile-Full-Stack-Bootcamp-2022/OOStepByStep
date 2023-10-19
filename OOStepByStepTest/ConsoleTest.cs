using System;
using System.IO;
using System.Text;

namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class PersonTest
    {
        [Fact]
        public void Test_Person()
        {
            Person person = new Person("Tom", 21);

            string result = person.SelfIntroduce();

            Assert.Equal("My name is Tom. I am 21 years old.", result);
        }
    }

    public class StudentTest
    {
        [Fact]
        public void Test_Student()
        {
            Student student = new Student("Tom", 18);
            Assert.Equal("My name is Tom. I am 18 years old. I am a student.", student.SelfIntroduce());
        }

        [Fact]
        public void Test_Student_with_class()
        {
            Student student = new Student("Tom", 18, new Class(2));
            Assert.Equal("My name is Tom. I am 18 years old. I am a student of class 2.", student.SelfIntroduce());
        }
    }

    public class TeacherTest
    {
        [Fact]
        public void Test_Teacher()
        {
            Teacher teacher = new Teacher("Amy", 30);
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher.", teacher.SelfIntroduce());
        }

        [Fact]
        public void Teacher_with_class()
        {
            Teacher teacher = new Teacher("Amy", 30, new Class(2));
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher of class 2.", teacher.SelfIntroduce());
        }
    }
}
