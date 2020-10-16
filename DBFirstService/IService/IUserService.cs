using DBFirstCore.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBFirstService.IService
{
    public interface IUserService
    {
        IQueryable<User> GetUsers();
    }
}
