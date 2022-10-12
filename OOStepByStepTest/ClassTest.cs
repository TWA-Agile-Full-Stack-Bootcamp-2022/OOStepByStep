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
            clss.Students = new Student[] { student };

            var introduction = student.IntroduceSelf();

            Assert.Equal("My name is Tom. I am 18 years old. I am a student of class 1.", introduction);
        }
    }
}