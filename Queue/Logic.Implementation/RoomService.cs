using System.Collections.Generic;
using QueueApp.Core.Interfaces;
using QueueApp.DTO.Items;
using QueueApp.Logic.Interfaces;

namespace QueueApp.Logic.Implementation
{
    public class RoomService : IRoomService
    {
        private readonly IUnitOfWork _unitOfWork;

        public RoomService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IEnumerable<RoomDTO> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Add(RoomDTO room)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(RoomDTO queue)
        {
            throw new System.NotImplementedException();
        }

        public void Update(RoomDTO queue)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();
        }
    }
}