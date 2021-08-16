using System;
using Persons;
using Records;
using Roooms;
using System.Collections.Generic;

namespace Hello1
{
    class Program
    {
        static void Main(string[] args)
        {
         /* Create a program that receives data from user input for people entering a class room.
                    The data that needs to be collected is:
                    Room number - TD224, AGSE111
                    Name - John Doe, Jane Black
                    Date entered - 03/08/2020, 23/02/2020
                    Time entered - 14:30, 08:20- THIS LINE
                    Amount of time person stayed in min - 12, 15, 300  */
           // read this later: https://www.tutorialsteacher.com/csharp/csharp-datetime

            Room ClassRoom1 = new Room("TD224");
            Room ClassRoom2 = new Room("AGSE111");

            Person p1 = new Person("John Doe");
            DateTime DateTimeEntered1 = new DateTime(2020,08,03,14,30,0);

            Record r1 = new Record(p1,DateTimeEntered1, 300); /*record class stores person, datetime & duration */


            // below is entered into one line instead 
            //ClassRoom1.AddRecord(new Record(p1,new DateTime(2020,08,03,14,30,0), 15));//assigns year, month, day, hour, min, seconds
                       //ClassRoom2.AddRecord(new Record(p1,new DateTime(2020,02,23,08,20,0), 300));

            
            Person p2 = new Person("Jane Black");
            DateTime DateTimeEntered2 = new DateTime(2020,02,23,08,20,0);
            Record r2 = new Record(p2,DateTimeEntered2,15);

            ClassRoom1.AddRecord(r1);
            ClassRoom2.AddRecord(r2);

             //ClassRoom1.AddRecord(new Record(p2,new DateTime(2020,08,03,14,30,0), 12)); /*function within ROOM class*/
            
             //ClassRoom2.AddRecord(new Record(p2,new DateTime(2020,02,23,08,20,0), 15));

             // all data is collected now, each person set up in a classroom. 

            ClassRoom1.printDuration(); /*prints total duration of how long the room has people in there for */
            ClassRoom2.printDuration();

            AddDurationTogether(ClassRoom1+ClassRoom2);

            
        }
    }
}

