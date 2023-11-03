namespace OOStepByStepTest
{
    using OOStepByStep;
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

            // When
            string info = person.BuildIntroductionInfo();

            // Then
            Assert.Equal($"My name is {givenName}. I am {givenAge} years old. I am a teacher.", info);
        }

        [Fact]
        public void Should_return_the_teacher_with_class_information_when_introduce_given_the_name_and_age()
        {
            // Given
            string givenName = "Amy";
            int givenAge = 30;
            int givenClassNumber = 2;
            var classroom = new Classroom(givenClassNumber);
            var person = new Teacher(givenName, givenAge);
            classroom.Join(person);

            // When
            string info = person.BuildIntroductionInfo();

            // Then
            Assert.Equal($"My name is {givenName}. I am {givenAge} years old. I am a teacher of class {givenClassNumber}.", info);
        }
    }
}
