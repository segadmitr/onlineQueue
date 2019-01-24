using System.Collections.Generic;
using QueueApp.Core.Interfaces;
using QueueApp.DTO.Items;
using QueueApp.Logic.Interfaces;

namespace QueueApp.Logic.Implementation
{
    public class QueueService : IQueueService
    {
        private readonly IUnitOfWork _unitOfWork;

        public QueueService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<QueueDTO> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public QueueDTO Add(QueueDTO queue)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(QueueDTO queue)
        {
            throw new System.NotImplementedException();
        }

        public QueueDTO Find(PersonDTO person)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();
        }
    }
}