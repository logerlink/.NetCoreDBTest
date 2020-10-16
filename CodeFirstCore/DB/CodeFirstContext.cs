using CodeFirstCore.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstCore.DB
{
    public class CodeFirstContext:DbContext
    {
        public CodeFirstContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Person> Person { get; set; }
    }
}
