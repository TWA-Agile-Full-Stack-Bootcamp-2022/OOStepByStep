using OOStepByStep;
using Xunit;

namespace OOStepByStepTest
{
    public class PersonTest
    {
        [Fact]
        public void Should_introduce_self_with_name_and_age()
        {
            var person = new Person("Tom", 21);

            var introduction = person.IntroduceSelf();

            Assert.Equal("My name is Tom. I am 21 years old.", introduction);
        }

        [Fact]
        public void Should_introduce_self_given_a_student()
        {
            var student = new Student("Tom", 18);

            var introduction = student.IntroduceSelf();

            Assert.Equal("My name is Tom. I am 18 years old. I am a student.", introduction);
        }

        [Fact]
        public void Should_introduce_self_given_a_teacher()
        {
            var teacher = new Teacher("Amy", 30);

            var introduction = teacher.IntroduceSelf();

            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher.", introduction);
        }
    }
}