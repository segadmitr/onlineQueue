using System;

namespace QueueApp.Core.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        IQueueRepository Queues { get; }
        IRoomRepository Rooms { get; }
        void Save();
    }
}
