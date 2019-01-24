using System;
using System.Collections.Generic;
using QueueApp.DTO.Items;

namespace QueueApp.Logic.Interfaces
{
    public interface IRoomService:IDisposable
    {
        IEnumerable<RoomDTO> GetAll();
        void Add(RoomDTO room);
        void Remove(RoomDTO queue);
        void Update(RoomDTO queue);
    }
}
