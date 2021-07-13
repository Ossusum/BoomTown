using System;

namespace BoomTown
{
    public class Note
    {
        public int ID { get; set; }
        public string Body { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastUpdated { get; set; }

    }
}
