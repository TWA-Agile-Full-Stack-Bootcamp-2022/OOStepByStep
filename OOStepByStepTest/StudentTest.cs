namespace OOStepByStepTest
{
    using OOStepByStep;
    using System;
    using System.IO;
    using System.Text;
    using Xunit;

    public class StudentTest
    {
        [Fact]
        public void Should_return_the_student_information_when_introduce_given_the_name_and_age()
        {
            // Given
            string givenName = "Tom";
            int givenAge = 21;
            var person = new Student(givenName, givenAge);

            var fakeOutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeOutput));

            // When
            person.Introduce();

            // Then
            Assert.Equal($"My name is {givenName}. I am {givenAge} years old. I am a student.\r\n", fakeOutput.ToString());
        }
    }
}
