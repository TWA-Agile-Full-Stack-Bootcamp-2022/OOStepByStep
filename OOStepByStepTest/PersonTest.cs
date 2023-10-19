namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class PersonTest
    {
        [Fact]
        public void Should_return_the_person_information_when_introduce_given_the_name_and_age()
        {
            // Given
            string givenName = "Tom";
            int givenAge = 21;
            var person = new Person(givenName, givenAge);

            // When
            string info = person.Introduce();

            // Then
            Assert.Equal($"My name is {givenName}. I am {givenAge} years old.", info);
        }
    }
}
