using System;
using Xunit;
using Roooms;
using Records;
using Persons;
using System.Collections.Generic;

namespace UnitTests
{
    public class RooomsTest /*can name same as class with Test at end */
    { /*in this example the first fact is incorrect and the 2nd fact is correct */

        public string roomNumber;
                Room ClassRoomTest = new Room("ABC111");
                Room ClassRoomTest1 = new Room("AB224");
                Room ClassRoomTest2 = new Room("DDD111");


                [Fact]
                public void GetRoomNumberTest()
                {
                Assert.Equal("ABC11", this.ClassRoomTest.GetRoomNumber());
                
                }
                [Fact]
                public void GetPopularRoomDetailsTest() {
         
                Assert.Equal("AB224 is the most popular room", this.ClassRoomTest1.GetPopularRoomDetails());
                }
                
                

             
             
    }
}
