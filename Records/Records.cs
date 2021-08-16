using System;
using Persons;

namespace Records
{
    public class Record
    {
        public Person Person ;
        public DateTime DateTimeEntered ;
        public int Duration ;  

        public Record(Person Person,  DateTime DateTimeEntered, int Duration )
        {
            this.Person = Person;
            this.DateTimeEntered = DateTimeEntered;
            this.Duration = Duration;
        }
    }
}    
