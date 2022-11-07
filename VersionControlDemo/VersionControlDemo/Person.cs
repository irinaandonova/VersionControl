using System;
using System.Collections.Generic;
using System.Text;

namespace VersionControlDemo
{
    internal class Person
    {
        public string name;

        Person(string name)
        {
            this.name = name;
        }

        public void GreetPreson()
        {
            Console.WriteLine($"Hello, {name}");
        }
    }
}
