using Day2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public class EFDBContext : DbContext
    {
        public EFDBContext() : base("name=efCon")
        {

        }
        public DbSet<Event> Events { get; set; }

    }
}
