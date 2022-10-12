using System;
using System.Collections.Generic;

namespace OOStepByStep
{
    public class Person
    {
        private readonly string name;
        private readonly int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Introduction()
        {
            return $"My name is {name}. I am {age} years old.";
        }
    }
}