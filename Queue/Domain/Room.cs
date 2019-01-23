using System.Collections.Generic;

namespace QueueApp.Core.Domain
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Queue> Queues { get; set; }
    }
}
