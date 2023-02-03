using TD.Infrastructure.Abstraction.Entities;

namespace TD.Infrastructure.Abstraction.Repositories
{
    /// <summary>
    /// IWaitingListRepository
    /// </summary>
    public interface IWaitingListRepository : IRepository<ListaEspera>
    {
        Task<IEnumerable<ListaEspera>> GetWaitingList(int franchise, int brand);
    }
}
