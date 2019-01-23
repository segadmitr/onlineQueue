using System.Threading.Tasks;
using QueueApp.Core.Domain;

namespace QueueApp.Core.Interfaces
{
    public interface IQueueRepository
    {
        Task Create(Queue queue);
        Task Delete(Queue queue);
    }
}
