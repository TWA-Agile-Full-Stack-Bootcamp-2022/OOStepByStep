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
}
