using System.Domain.Models;
using System.Domain.Repositories;
using System.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace System.Infrastructure.Repositories;

public class CustomerRepository : ICustomerRepository
{
    private readonly AppDbContext _dbContext;
    public CustomerRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<Customer?> GetByIdAsync(int id)
    {
        var customer = await _dbContext.Customers.FirstOrDefaultAsync(c => c.Id == id);
        return customer;
    }

    public async Task<IEnumerable<Customer>> GetAllAsync()
    {
        var customers = await _dbContext.Customers.ToListAsync();
        return customers;
    }

    public Task AddAsync(Customer customer)
    {
        _dbContext.Customers.Add(customer);
        return _dbContext.SaveChangesAsync();
    }

    public Task UpdateAsync(Customer customer)
    {
        _dbContext.Customers.Update(customer);
        return _dbContext.SaveChangesAsync();
    }

    public Task DeleteAsync(int id)
    {
        var deleteCustomer = _dbContext.Customers.FirstOrDefault(c => c.Id == id);
        if (deleteCustomer != null) _dbContext.Customers.Remove(deleteCustomer);
        return _dbContext.SaveChangesAsync();
    }
}