namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class PersonTest
    {
        [Theory]
        [InlineData("Tom", 21)]
        [InlineData("Amy", 30)]
        public void Person_should_be_able_to_introduce_self_with_name_and_age(string name, int age)
        {
            // given
            var person = new Person(name, age);

            // when
            var echo = person.IntroduceSelf();

            // then
            Assert.Equal($"My name is {name}. I am {age} years old.", echo);
        }
    }
}
