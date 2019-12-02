using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDRE
{
    class Database
    {
        public static dynamic Connect()
        {
            return new LiteDB.LiteDatabase("myData.db");
        }
    }
}
