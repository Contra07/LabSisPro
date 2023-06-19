using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace TestApp
{
    internal class MyDbContext: DbContext
    {
        public DbSet<Record> Records { get; set; }

        public MyDbContext() : base("DbConnectionString")
        {

        }

        public List<Record> GetAll() 
        {
            return Records.OrderBy(x => x.Id).ToList();
        }


    }
}
