namespace OOStepByStepTest
{
    using OOStepByStep;
    using System;
    using System.IO;
    using System.Text;
    using Xunit;

    public class TeacherTest
    {
        [Fact]
        public void Should_return_the_teacher_information_when_introduce_given_the_name_and_age()
        {
            // Given
            string givenName = "Amy";
            int givenAge = 30;
            var person = new Teacher(givenName, givenAge);

            var fakeOutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeOutput));

            // When
            person.Introduce();

            // Then
            Assert.Equal($"My name is {givenName}. I am {givenAge} years old. I am a teacher.\r\n", fakeOutput.ToString());
        }
    }
}
