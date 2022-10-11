using System;
using System.Collections.Generic;

namespace OOStepByStep
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string IntroduceSelf()
        {
            return $"My name is {name}. I am {age} years old.";
        }

        public string GetName()
        {
            return name;
        }
    }
}