using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FloraServer.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime EventTime { get; set; }
    }
}
