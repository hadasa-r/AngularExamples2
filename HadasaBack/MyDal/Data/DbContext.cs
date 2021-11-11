using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDal.Data
{
    public class DbContext
    {
        public MyDB db { get; set; }
        public DbContext()
        {
            db = new MyDB();
        }
    }
}

