namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class StudentTest
    {
        [Theory]
        [InlineData("Tom", 21)]
        public void Student_should_be_able_to_introduce_self(string name, int age)
        {
            // given
            var student = new Student(name, age);

            // when
            var echo = student.IntroduceSelf();

            // then
            Assert.Equal($"My name is {name}. I am {age} years old. I am a student.", echo);
        }

        [Theory]
        [InlineData("Tom", 21, 2)]
        public void Student_should_be_able_to_introduce_self_with_class_number_when_belong_to_a_class(string name, int age, int classNumber)
        {
            // given
            var student = new Student(name, age);
            student.JoinClass(classNumber);

            // when
            var echo = student.IntroduceSelf();

            // then
            Assert.Equal($"My name is {name}. I am {age} years old. I am a student of class {classNumber}.", echo);
        }
    }
}
