using CodeFirstCore.DB;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstService
{
    public class BaseService
    {
        protected CodeFirstContext _db;
        public BaseService(CodeFirstContext db)
        {
            _db = db;
        }
    }
}
