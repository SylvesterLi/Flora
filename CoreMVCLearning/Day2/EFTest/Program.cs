using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTest
{
    class Program
    {
        static void Main(string[] args)
        {
            EFDBContext eFDB = new EFDBContext();
            Person person = new Person();
            person.Id = 1;
            person.Time = DateTime.Now;
            person.Name = "Lily";
            eFDB.Persons.Add(person);
            eFDB.SaveChanges();
            Console.WriteLine("success");
        }
    }
}
