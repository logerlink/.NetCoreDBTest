using DBFirstCore.DB;
using DBFirstService.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBFirstService.Impl
{
    public class UserService : BaseService, IUserService
    {
        public UserService(testContext testContext) : base(testContext) { }
        public IQueryable<User> GetUsers()
        {
            return _db.User.AsQueryable();
        }
    }
}
