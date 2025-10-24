using System.Domain.Models;

namespace System.Domain.Repositories;

public interface ICustomerRepository
{
    Task<Customer?> FindByIdAsync(int id);
    Task<List<Customer?>> GetAllAsync();
    Task AddAsync(Customer newCustomer);
    Task UpdateAsync(Customer updatedCustomer);
    Task DeleteAsync(int id);
}