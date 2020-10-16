using CodeFirstCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeFirstService.IService
{
    public interface IPersonService
    {
        public IQueryable<Person> GetList();
        int Add(Person person);
    }
}
