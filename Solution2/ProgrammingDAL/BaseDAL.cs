using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingDAL
{
    public class BaseDAL
    {
        protected ProgrammingDbEntities db;
        public BaseDAL()
        {
            db = new ProgrammingDbEntities();     
        }
    }
}
 