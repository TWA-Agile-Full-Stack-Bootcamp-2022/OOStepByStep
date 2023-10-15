using System;
using System.Collections.Generic;

namespace OOStepByStep
{
    public class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

        public void Introduce()
        {
            Console.WriteLine($"My name is {Name}. I am {Age} years old.");
        }
    }
}
