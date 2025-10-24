using System.Application.Services;
using System.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace System.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomerController : Controller
{
    private readonly CustomerService _service;
    public CustomerController(CustomerService service)
    {
        _service = service;
    }
    
    //GetById
    [HttpGet("/{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var customer = await _service.GetCustomerByIdAsync(id);
        return Ok(customer);
    }
    
    //GetAll
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var customers = await _service.GetAllCustomerAsync();
        return Ok(customers);
    }
    
    //Add
    [HttpPost]
    public async Task<IActionResult> AddCustomer(Customer customer)
    {
        await _service.AddCustomerAsync(customer);
        return Ok(customer);
    }
    
    //Update
    [HttpPatch]
    public async Task<IActionResult> UpdateCustomer(Customer customer)
    {
        await _service.UpdateCustomerAsync(customer);
        return Ok(customer);
    }
    
    //Delete
    [HttpDelete]
    public async Task<IActionResult> DeleteCustomer(int id)
    {
        await _service.DeleteCustomerAsync(id);
        return Ok();
    }
}