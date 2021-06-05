using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    [Serializable]
    public class Person
    {
        public String Name;
        public Person() { }
        public Person(String n)
        {
            Name = n;
        }
        public void Buy_Room(Room room)
        {
            room.buy_Room(this);
        }
    }
}
