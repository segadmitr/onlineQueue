using System;

namespace QueueApp.Core.Domain
{
    public class Queue
    {
        public int Id { get; set; }
        public int? RoomId { get; set; }
        public virtual Room Room { get; set; }
        public DateTime StartDate { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
