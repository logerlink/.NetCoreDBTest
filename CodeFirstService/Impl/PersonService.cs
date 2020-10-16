using CodeFirstCore.DB;
using CodeFirstCore.Model;
using CodeFirstService.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeFirstService.Impl
{
    public class PersonService : BaseService, IPersonService
    {
        public PersonService(CodeFirstContext db) : base(db) { }

        public int Add(Person person)
        {
            _db.Add(person);
            return _db.SaveChanges();
        }

        public IQueryable<Person> GetList()
        {
            return _db.Person.AsQueryable();
        }
    }
}
