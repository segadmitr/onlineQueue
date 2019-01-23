using System;
using Microsoft.EntityFrameworkCore;
using QueueApp.Core.Interfaces;

namespace QueueApp.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Private

        private readonly ApplicationContext _context;
        private readonly Lazy<IQueueRepository> _queues;
        private readonly Lazy<IRoomRepository> _rooms;
        private bool _disposed = false;

        #endregion

        public UnitOfWork(DbContextOptions<ApplicationContext> options)
        {
            _context = new ApplicationContext(options);
            _queues = new Lazy<IQueueRepository>(() => new QueueRepository(_context));
            _rooms = new Lazy<IRoomRepository>(() => new RoomRepository(_context));
        }

        #region Properties

        public IQueueRepository Queues => _queues.Value;

        public IRoomRepository Rooms => _rooms.Value;

        #endregion

        #region Methods

        public void Save()
        {
            _context.SaveChanges();
        }

        public virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion

    }
}