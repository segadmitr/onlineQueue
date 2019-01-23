using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QueueApp.Core.Domain;
using QueueApp.Core.Interfaces;

namespace QueueApp.Infrastructure.Data
{
    public class QueueRepository : IQueueRepository
    {
        private readonly ApplicationContext _context;

        public QueueRepository(ApplicationContext context)
        {
            _context = context;
        }
        public async Task Create(Queue queue)
        {
            await _context.Queues.AddAsync(queue);
        }

        public async Task Delete(Queue queue)
        {
           await Task.Run(()=>_context.Entry(queue).State = EntityState.Deleted);
        }
    }
}