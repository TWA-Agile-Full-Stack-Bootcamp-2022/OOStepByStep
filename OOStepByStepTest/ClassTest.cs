using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OOStepByStep;
using Xunit;

namespace OOStepByStepTest
{
    public class ClassTest
    {
        [Fact]
        public void Should_introduce_self_with_class_info_given_a_teacher_belong_to_a_class()
        {
            var teacher = new Teacher("Amy", 30);
            var clss = new Class(1);
            clss.Teacher = teacher;

            var introduction = teacher.IntroduceSelf();

            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher of class 1.", introduction);
        }

        [Fact]
        public void Should_introduce_self_with_class_info_given_a_student_belong_to_a_class()
        {
            var student = new Student("Tom", 18);
            var clss = new Class(1);
            clss.Students = new List<Student>() { student };

            var introduction = student.IntroduceSelf();

            Assert.Equal("My name is Tom. I am 18 years old. I am a student of class 1.", introduction);
        }

        [Fact]
        public void Should_say_welcome_when_a_student_join_class_given_a_teacher_belong_to_a_class()
        {
            var teacher = new Teacher("Amy", 30);
            var clss = new Class(1);
            clss.Teacher = teacher;
            var fakeOutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeOutput));

            clss.AddNewStudent(new Student("Jim", 18));

            Assert.Single(clss.Students);
            Assert.Contains("My name is Amy. I am 30 years old. I am a teacher of class 1. Welcome Jim join class 1.",
                fakeOutput.ToString());
        }
    }
}