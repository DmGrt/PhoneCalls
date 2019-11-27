using System;

namespace PhoneCalls.Domain.Classes
{
    public class Person
    {
        public Person(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }

        public Guid Id { get; }
        public string Name { get; protected set; }
    }
}
