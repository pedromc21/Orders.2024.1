using Orders.Shared.Entities;
using Orders.Shared.Responses;

namespace Orders.Backend.Repositories.Interfaces
{
    public interface ICategoriesRepository
    {
        Task<ActionResponse<IEnumerable<Category>>> GetAsync();

        //Task<ActionResponse<int>> GetTotalPagesAsync();

        //Task<IEnumerable<Category>> GetComboAsync();
    }
}
