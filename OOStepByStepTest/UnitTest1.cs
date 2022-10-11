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
    }

    public class PersonTest
    {
        [Fact]
        public void Should_return_introduce_when_person_introduce_given_person_with_name_and_age()
        {
            //given
            var person = new Person("Tom", 30);
            //when
            var introduce = person.Introduce();
            //then
            Assert.Equal("My name is Tom. I am 30 years old.", introduce);
        }

        [Fact]
        public void Should_return_introduce_like_a_student_when_student_introduce_given_student_with_name_and_age()
        {
            //given
            var student = new Student("Tom", 30);
            //when
            var introduce = student.Introduce();
            //then
            Assert.Equal("My name is Tom. I am 30 years old. I am a student.", introduce);
        }
    }
}
