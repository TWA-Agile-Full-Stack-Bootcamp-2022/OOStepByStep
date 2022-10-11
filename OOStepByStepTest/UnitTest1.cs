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
            var student = new Student(name, age, new Class("2"));
            Assert.Equal("My name is Tom. I am 18 years old. I am a student of class 2.", student.IntroduceSelf());
        }

        [Fact]
        public void Should_return_info_when_introduce_given_a_teacher()
        {
            string name = "Amy";
            int age = 30;
            var teacher = new Teacher(name, age, new Class("2"));
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher of class 2.", teacher.IntroduceSelf());
        }

        [Fact]
        public void Should_return_info_when_welcome_new_student_given_a_student()
        {
            string name = "Tom";
            int age = 18;
            var student = new Student(name, age, new Class("2"));
            Assert.Equal("My name is Tom. I am 18 years old. I am a student of class 2. Welcome Jim join class 2.",
                student.WelcomeNewStudent(new Student("Jim", 18)));
        }

        [Fact]
        public void Should_return_info_when_welcome_new_student_given_a_teacher()
        {
            string name = "Amy";
            int age = 30;
            var teacher = new Teacher(name, age, new Class("2"));
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher of class 2. Welcome Tom join class 2.",
                teacher.WelcomeNewStudent(new Student("Tom", 18)));
        }
    }
}
