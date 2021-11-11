using MyDal.Data;
using MyDal.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyDal.Services
{
    public class CommonDal
    {
        private const string fileName = "MyDb.Json";
        private readonly string filePath = Environment.CurrentDirectory;
        private DbContext dbContext;

        

        public MyDB GetMyDb()
        {
            OpenDb();
            return dbContext.db;
        }

        private void SaveChanges()
        {
            string s = JsonHelper.FromClass<DbContext>(dbContext);
            File.WriteAllText(Path.Combine(filePath, fileName), s);
        }

        internal IEnumerable<CurrentLocation> GetAllLocations()
        {
            OpenDb();
            return dbContext.db.Locations;
        }

        internal void SaveCurrentLocation(CurrentLocation curLocation)
        {
            OpenDb();
            dbContext.db.Locations.Add(curLocation);
            SaveChanges();
        }

        
        public void SavePerson(Person m)
        {
            OpenDb();
            //var mToSave = db._db.Persons.Find(m1 => m.Month == m1.Month && m.Yaer == m1.Yaer);
            //if (mToSave == null)
            //{
            //    db.Clock.Months.Add(m);
            //}
            //else
            //{
            //    int index = db.Clock.Months.IndexOf(mToSave);
            //    db.Clock.Months[index] = m;
            //}
            //mToSave = m;
            dbContext.db.Persons.Add(m);
            SaveChanges();
        }

        private void OpenDb()
        {
            if (!File.Exists(Path.Combine(filePath, fileName)))
            {
                var f = File.Create(Path.Combine(filePath, fileName));
                f.Close();
                dbContext = new DbContext();
                SaveChanges();
            }
            string s = File.ReadAllText(Path.Combine(filePath, fileName));
            dbContext = JsonHelper.ToClass<DbContext>(s);
        }

       
    }
}
