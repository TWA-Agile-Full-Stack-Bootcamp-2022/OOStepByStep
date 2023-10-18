using System;
using System.IO;
using System.Text;

namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class ConsoleTest
    {
        [Fact]
        public void Test_Console()
        {
            // given
            var fakeOutput = new StringBuilder();
            StringWriter newOut = new StringWriter(fakeOutput);
            Console.SetOut(newOut);

            // when
            new Class1().Print();

            // then
            Assert.Equal("console\r\n", fakeOutput.ToString());
        }
    }

    public class PersonTest
    {
        [Fact]
        public void Test_Person()
        {
            Person person = new Person("Tom", 21);

            string result = person.SelfIntroduce();

            Assert.Equal("My name is Tom. I am 21 years old.", result);
        }
    }
}
