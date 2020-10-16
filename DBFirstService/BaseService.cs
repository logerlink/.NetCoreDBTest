using DBFirstCore.DB;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBFirstService
{
    public class BaseService
    {
        protected testContext _db;
        public BaseService(testContext db)
        {
            this._db = db;
        }
    }
}
