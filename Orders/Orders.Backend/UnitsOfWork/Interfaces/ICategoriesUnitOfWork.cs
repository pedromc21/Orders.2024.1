using Orders.Shared.Entities;
using Orders.Shared.Responses;

namespace Orders.Backend.UnitsOfWork.Interfaces
{
    public interface ICategoriesUnitOfWork
    {
        Task<ActionResponse<IEnumerable<Category>>> GetAsync();

        //Task<ActionResponse<int>> GetTotalPagesAsync(PaginationDTO pagination);

        //Task<IEnumerable<Category>> GetComboAsync();
    }
}
