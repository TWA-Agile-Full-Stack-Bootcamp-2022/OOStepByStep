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

        [Fact]
        public void Should_return_introduce_like_a_teacher_when_teacher_introduce_given_student_with_name_and_age()
        {
            //given
            var teacher = new Teacher("Tom", 30);
            //when
            var introduce = teacher.Introduce();
            //then
            Assert.Equal("My name is Tom. I am 30 years old. I am a teacher.", introduce);
        }

        [Fact]
        public void Should_introduce_like_a_student_in_class_when_introduce_given_class_and_student()
        {
            //given
            var student = new Student("Tom", 30);
            var gradeClass = new GradeClass("class 2");
            gradeClass.JoinStudent(student);
            //when
            var introduce = student.Introduce();
            //then
            Assert.Equal("My name is Tom. I am 30 years old. I am a student of class 2.", introduce);
        }

        [Fact]
        public void Should_introduce_like_a_teacher_in_class_when_introduce_given_class_and_teacher()
        {
            //given
            var teacher = new Teacher("Tom", 30);
            var gradeClass = new GradeClass("class 2");
            gradeClass.JoinTeacher(teacher);
            //when
            var introduce = teacher.Introduce();
            //then
            Assert.Equal("My name is Tom. I am 30 years old. I am a teacher of class 2.", introduce);
        }

        [Fact]
        public void Should_throw_exception_when_add_new_teacher_given_class_all_ready_has_teacher()
        {
            //given
            var teacher = new Teacher("Tom", 30);
            var teacherNew = new Teacher("Tom2", 30);
            var gradeClass = new GradeClass("class 2");
            gradeClass.JoinTeacher(teacher);
            //then
            Assert.Throws<OneClassOneTeacherException>(() => gradeClass.JoinTeacher(teacherNew));
        }

        [Fact]
        public void Should_welcome_new_student_in_class_when_welcome_given_class_and_student()
        {
            //given
            var student = new Student("Tom", 30);
            var newStudent = new Student("TomNew", 30);
            var gradeClass = new GradeClass("class 2");
            gradeClass.JoinStudent(student);
            //when
            var introduce = student.Welcome(newStudent);
            //then
            Assert.Equal("My name is Tom. I am 30 years old. I am a student of class 2. Welcome TomNew join class 2.", introduce);
        }

        [Fact]
        public void Should_welcome_new_student_in_class_when_welcome_given_class_and_teacher()
        {
            //given
            var teacher = new Teacher("Tom", 30);
            var newStudent = new Student("TomNew", 30);
            var gradeClass = new GradeClass("class 2");
            gradeClass.JoinTeacher(teacher);
            //when
            var introduce = teacher.Welcome(newStudent);
            //then
            Assert.Equal("My name is Tom. I am 30 years old. I am a teacher of class 2. Welcome TomNew join class 2.", introduce);
        }
    }
}
