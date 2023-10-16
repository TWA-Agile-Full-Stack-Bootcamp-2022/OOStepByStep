namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class TeacherTest
    {
        [Theory]
        [InlineData("Amy", 30)]
        public void Teacher_should_be_able_to_introduce_self(string name, int age)
        {
            // given
            var teacher = new Teacher(name, age);

            // when
            var echo = teacher.IntroduceSelf();

            // then
            Assert.Equal($"My name is {name}. I am {age} years old. I am a teacher.", echo);
        }

        [Theory]
        [InlineData("Amy", 30, 2)]
        public void Teacher_should_be_able_to_introduce_him_herself_with_class_number(string name, int age, int classNumber)
        {
            // given
            var teacher = new Teacher(name, age);
            teacher.JoinClass(classNumber);
            // when
            var echo = teacher.IntroduceSelf();

            // then
            Assert.Equal($"My name is {name}. I am {age} years old. I am a teacher of class {classNumber}.", echo);
        }
    }
}
