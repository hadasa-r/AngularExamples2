using MyDal.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDal
{
    public class LocationService
    {
        public void SavePerson(Person p)
        {
            new CommonDal().SavePerson(p);
        }

        public void SaveCurrentLocation(CurrentLocation curLocation)
        {
            new CommonDal().SaveCurrentLocation(curLocation);
        }

        public IEnumerable<CurrentLocation> GetAllLocations()
        {
            return new CommonDal().GetAllLocations();
        }
    }
}
