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
        public void Should_get_introduce_result_when_give_a_person()
        {
            var person = new Person("Tom", 21);
            var result = person.Introduce();
            Assert.Equal("My name is Tom. I am 21 years old.", result);
        }

        [Fact]
        public void Should_get_introduce_result_when_give_a_student()
        {
            var student = new Student("Tom", 21);
            var result = student.Introduce();
            Assert.Equal("My name is Tom. I am 21 years old. I am a student.", result);
        }

        [Fact]
        public void Should_get_introduce_result_when_give_a_teacher()
        {
            var teacher = new Teacher("Amy", 30);
            var result = teacher.Introduce();
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher.", result);
        }

        [Fact]
        public void Should_get_class_name_when_create_a_class()
        {
            var class1 = new Class("class 1");
            var result = class1.GetName();
            Assert.Equal("class 1", result);
        }

        [Fact]
        public void Should_get_introduce_with_class_when_give_a_student_and_Class()
        {
            var class1 = new Class("class 1");
            var student = new Student("Tom", 21);

            class1.AddStudent(student);

            var result = student.Introduce();
            Assert.Equal("My name is Tom. I am 21 years old. I am a student of class 1.", result);
        }

        [Fact]
        public void Should_get_introduce_with_class_when_give_a_Teacher_and_Class()
        {
            var class2 = new Class("class 2");
            var teacher = new Teacher("Amy", 30);
            class2.AddTeacher(teacher);

            var result = teacher.Introduce();
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher of class 2.", result);
        }

        [Fact]
        public void Should_get_teacher_welcome_message_when_student_add_a_class()
        {
            var class1 = new Class("class 1");
            var teacher = new Teacher("Amy", 30);
            class1.AddTeacher(teacher);

            var student = new Student("Tom", 21);

            var result = class1.AddStudent(student);

            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher of class 1. Welcome Tom join class 1.", result);
        }

        [Fact]
        public void Should_get_students_welcome_message_when_student_add_a_class()
        {
            var class1 = new Class("class 1");
            var student1 = new Student("Tom", 21);
            var student2 = new Student("Jerry", 22);
            class1.AddStudent(student1);
            class1.AddStudent(student2);
            var student3 = new Student("Bob", 23);

            var result = class1.AddStudent(student3);

            Assert.Equal("My name is Tom. I am 21 years old. I am a student of class 1. Welcome Bob join class 1.My name is Jerry. I am 22 years old. I am a student of class 1. Welcome Bob join class 1.", result);
        }
    }
}
