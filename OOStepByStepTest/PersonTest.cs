using OOStepByStep;
using Xunit;

namespace OOStepByStepTest
{
    public class PersonTest
    {
        [Fact]
        public void Should_self_with_name_and_age()
        {
            var person = new Person("Tom", 21);

            var introduction = person.Introduction();

            Assert.Equal("My name is Tom. I am 21 years old.", introduction);
        }
    }
}