using System.Domain.Models;
using System.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace System.Application.Services;

public class CustomerService
{
    private readonly ICustomerRepositorie _repository;
    public CustomerService(ICustomerRepositorie repository)
    {
        _repository = repository;
    }
    
    public Task<IEnumerable<Customer>> GetAllCustomerAsync()
    {
        return _repository.GetAllAsync();
    }
    
    public Task<Customer?> GetProductByIdAsync(int id)
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