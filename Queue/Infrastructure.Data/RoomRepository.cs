using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QueueApp.Core.Domain;
using QueueApp.Core.Interfaces;

namespace QueueApp.Infrastructure.Data
{
    public class RoomRepository : IRoomRepository
    {
        private readonly ApplicationContext _context;

        public RoomRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Room>> GetAll()
        {
            return await _context.Rooms.ToListAsync();
        }

        public async Task<Room> Get(int id)
        {
            return await _context.Rooms.FindAsync(id);
        }

        public async Task Create(Room room)
        {
            await _context.Rooms.AddAsync(room);
        }

        public async Task Update(Room room)
        {
            await Task.Run(() => _context.Entry(room).State = EntityState.Modified);
        }

        public async Task Delete(Room room)
        {
            await Task.Run(() => _context.Entry(room).State = EntityState.Deleted);
        }
    }
}