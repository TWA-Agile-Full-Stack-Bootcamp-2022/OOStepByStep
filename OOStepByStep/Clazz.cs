namespace OOStepByStep
{
    using System;
    using System.Transactions;

    public class Class1
    {
        public void Print()
        {
            Console.WriteLine("console");
        }
    }

    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual string SelfIntroduce()
        {
            return $"My name is {name}. I am {age} years old.";
        }
    }

    public class Student : Person
    {
        public Student(string name, int age) : base(name, age)
        {
        }

        public override string SelfIntroduce()
        {
            return base.SelfIntroduce() + " I am a student.";
        }
    }

    public class Teacher : Person
    {
        public Teacher(string name, int age) : base(name, age)
        {
        }

        public override string SelfIntroduce()
        {
            return base.SelfIntroduce() + " I am a teacher.";
        }
    }
}
