using System.Domain.Models;
using System.Domain.Repositories;

namespace System.Application.Services;

public class CustomerService
{
    private readonly ICustomerRepository _repository;
    public CustomerService(ICustomerRepository repository)
    {
        _repository = repository;
    }
    
    public Task<IEnumerable<Customer>> GetAllCustomerAsync()
    {
        return _repository.GetAllAsync();
    }
    
    public Task<Customer?> GetCustomerByIdAsync(int id)
    {
        return _repository.GetByIdAsync(id);
    }

    public Task AddCustomerAsync(Customer customer)
    {
        return _repository.AddAsync(customer);
    }

    public Task UpdateCustomerAsync(Customer customer)
    {
        return _repository.UpdateAsync(customer);
    }

    public Task DeleteCustomerAsync(int id)
    {
        return _repository.DeleteAsync(id);
    }
}