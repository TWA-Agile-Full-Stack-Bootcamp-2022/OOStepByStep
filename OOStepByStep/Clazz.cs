namespace OOStepByStep
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Transactions;

    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name { get => name; set => name = value; }

        public virtual string SelfIntroduce()
        {
            return $"My name is {name}. I am {age} years old.";
        }
    }

    public class Student : Person
    {
        private Class clazz;
        public Student(string name, int age) : base(name, age)
        {
        }

        public Student(string name, int age, Class clazz) : base(name, age)
        {
            this.clazz = clazz;
        }

        public override string SelfIntroduce()
        {
            if (clazz == null)
            {
                return base.SelfIntroduce() + " I am a student.";
            }

            return base.SelfIntroduce() + $" I am a student of class {clazz.Number}.";
        }

        internal string Notify(string name)
        {
            return SelfIntroduce() + $" Welcome Jim join class {clazz.Number}";
        }
    }

    public class Teacher : Person
    {
        private readonly Class clazz;

        public Teacher(string name, int age, Class clazz) : base(name, age)
        {
            this.clazz = clazz;
        }

        public Teacher(string name, int age) : base(name, age)
        {
        }

        public override string SelfIntroduce()
        {
            if (clazz == null)
            {
                return base.SelfIntroduce() + " I am a teacher.";
            }

            return base.SelfIntroduce() + $" I am a teacher of class {clazz.Number}.";
        }

        internal string Notify(string name)
        {
            return SelfIntroduce() + $" Welcome Jim join class {clazz.Number}";
        }
    }

    public class Class
    {
        private readonly int number;
        private readonly List<Student> students = new();
        private Teacher teacher;

        public Class(int number)
        {
            this.number = number;
        }

        public int Number => number;

        public Teacher Teacher { get => teacher; set => teacher = value; }

        public void AddStudent(Student student)
        {
            students.ForEach(s => { s.Notify(student.Name); });
            teacher.Notify(student.Name);
            students.Add(student);
        }
    }
}
