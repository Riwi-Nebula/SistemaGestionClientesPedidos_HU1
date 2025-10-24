using System.Domain.Models;
using System.Domain.Repositories;
using System.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace System.Infrastructure.Repositories;

public class CustomerRepository : ICustomerRepository
{
    private readonly AppDbContext _context;

    public CustomerRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<Customer?> FindByIdAsync(int id)
    {
        var customer = await _context.Customers.FirstOrDefaultAsync(c => c.Id == id);
        return customer;
    }
    public async Task<List<Customer?>> GetAllAsync()
    {
        var customers = _context.Customers.ToList();
    }

    public Task AddAsync(Customer newCustomer)
    {
        var customer = _context.Customers.Add(newCustomer);
        return _context.SaveChangesAsync();
    }

    public Task UpdateAsync(Customer updatedCustomer)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}