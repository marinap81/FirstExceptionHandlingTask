using System;

namespace Persons
{
    public class Person
    {
        public string Name;

        public Person(string name)
        {
            this.Name = name;
        }

        public string GetDetails() {
            return $"{this.Name}";
        }
    } 
}
