using System.Domain.Models;
using System.Domain.Repositories;

namespace System.Infrastructure.Repositories;

public class OrderDetailRepository : IOderDetailRepository
{
    public Task<OrderDetail?> GetByIdAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<OrderDetail>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(OrderDetail orderDetail)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}
