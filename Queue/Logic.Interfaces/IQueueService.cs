using System;
using System.Collections.Generic;
using QueueApp.DTO.Items;

namespace QueueApp.Logic.Interfaces
{
    public interface IQueueService:IDisposable
    {
        IEnumerable<QueueDTO> GetAll();
        QueueDTO Add(QueueDTO queue);
        void Remove(QueueDTO queue);
        QueueDTO Find(PersonDTO person);
    }
}
