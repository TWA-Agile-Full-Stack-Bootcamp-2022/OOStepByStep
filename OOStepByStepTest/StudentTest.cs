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

            // When
            string info = person.Introduce();

            // Then
            Assert.Equal($"My name is {givenName}. I am {givenAge} years old. I am a student.", info);
        }

        [Fact]
        public void Should_return_the_student_with_class_infomation_when_introduce_given_a_student_belong_to_some_classroom()
        {
            // Given
            string givenName = "Tom";
            int givenAge = 21;
            int givenClassNumber = 2;
            var classroom = new Classroom(givenClassNumber);
            var person = new Student(givenName, givenAge, classroom);

            var fakeOutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeOutput));

            // When
            string info = person.Introduce();

            // Then
            Assert.Equal($"My name is {givenName}. I am {givenAge} years old. I am a student of class {givenClassNumber}.", info);
        }
    }
}
