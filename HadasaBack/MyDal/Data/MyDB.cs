using System.Collections.Generic;

namespace MyDal
{
    public class MyDB
    {
        public List<Person> Persons { get; set; }
        public List<CurrentLocation> Locations { get;set;}
        public MyDB()
        {
            Persons = new List<Person>();
            Locations = new List<CurrentLocation>();
        }
    }
}