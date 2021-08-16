using System;
using Records;
using System.Collections.Generic;

namespace Roooms
{
    public class Room
    {
        public string roomNumber;
        public List<Record> myRoomRecords;    
        /*public string RoomName; */
      

            public Room(string roomNum) 
            {
                this.roomNumber = roomNum;
                this.myRoomRecords = new List<Record>();
                
            }

            public void AddRecord(Record Record)    
            {
               this.myRoomRecords.Add(Record);     
            }

            public void printDuration() /*prints duration of how long the room has people in there for */
            {
                int total = 0;

                for ( int i = 0 ; i < this.myRoomRecords.Count ; ++i )
                {
                    total += this.myRoomRecords[i].Duration;
                }

                Console.WriteLine("Total Duration for " + this.roomNumber + " is " + total);
            }

                public string GetRoomNumber() {
            return $"{this.roomNumber}";
        }
           
           public string GetPopularRoomDetails() {
            return $"{this.roomNumber} is the most popular room";
        }

        
    }
}
