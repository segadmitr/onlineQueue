using System.Collections.Generic;
using System.Threading.Tasks;
using QueueApp.Core.Domain;

namespace QueueApp.Core.Interfaces
{
    public interface IRoomRepository
    {
        Task<IEnumerable<Room>> GetAll();
        Task<Room> Get(int id);
        Task Create(Room room);
        Task Update(Room room);
        Task Delete(Room room);
    }
}
