using System.Domain.Models;

namespace System.Domain.Repositories;

public interface IOderDetailRepository
{
    Task<OrderDetail?> GetByIdAsync();
    Task<IEnumerable<OrderDetail>> GetAllAsync();
    Task AddAsync(OrderDetail orderDetail);
    Task DeleteAsync(int id);
}