using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTest
{
    
    [Table("T_Persons")]
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Time { get; set; }
    }
}
