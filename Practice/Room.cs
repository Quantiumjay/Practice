using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
 
    [Serializable]
    public class Room
    {
        public Boolean is_Empty;
        Person inhabitant;
        public void buy_Room(Person person)
        {
            is_Empty = false;
            inhabitant = person;
        }
        public Room()
        {
            is_Empty = true;
            inhabitant = new Person();
        }
    }
}
