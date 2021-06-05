using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    [Serializable]
    public class Hotel
    {
      public  Room[] rooms = new Room[15];
        public void sell_Room(Person person, int i)
        { 
            person.Buy_Room(this.rooms[i]);
        }
        public Hotel()
        {
            for(int i = 0; i < 15; i++)
            {
                rooms[i] = new Room();
            }
        }
    }

}
