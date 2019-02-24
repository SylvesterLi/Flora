using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTest
{
    public class EFDBContext : DbContext
    {
        public EFDBContext() : base("name=efCon")
        {

        }
        public DbSet<Person> Persons { get; set; }

    }
}
