using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class EventModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int Priority { get; set; }
    }
}
