using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Day2.Models
{
    [Table("T_Events")]
    public class Event
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime EventTime { get; set; }
    }
}