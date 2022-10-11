namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var class1 = new Class1();
            Assert.NotNull(class1);
        }

        [Fact]
        public void Should_return_info_when_introduce_given_a_person()
        {
            string name = "Tom";
            int age = 21;
            var person = new Person(name, age);
            Assert.Equal("My name is Tom. I am 21 years old.", person.IntroduceSelf());
        }

        [Fact]
        public void Should_return_info_when_introduce_given_a_student()
        {
            string name = "Tom";
            int age = 18;
            var student = new Student(name, age);
            Assert.Equal("My name is Tom. I am 18 years old. I am a student.", student.IntroduceSelf());
        }
    }
}
