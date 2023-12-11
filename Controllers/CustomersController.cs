using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Grad_Project.Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace Grad_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly grad_projectContext _context;

        public CustomersController(grad_projectContext context)
        {
            _context = context;
        }

        // GET: api/Customers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Models.Customer>>> GetCustomers()
        {
          if (_context.Customers == null)
          {
              return NotFound();
          }
            return await _context.Customers.ToListAsync();
        }

        // GET: api/Customers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Models.Customer>> GetCustomer(int id)
        {
          if (_context.Customers == null)
          {
              return NotFound();
          }
            var customer = await _context.Customers.FindAsync(id);

            if (customer == null)
            {
                return NotFound();
            }

            return customer;
        }

        // PUT: api/Customers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomer(int id, Models.Customer customer)
        {
            if (id != customer.CustomerId)
            {
                return BadRequest();
            }

            _context.Entry(customer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Customers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Models.Customer>> PostCustomer(  Models.Customer customer)
        //{
        //  if (_context.Customers == null)
        //  {
        //      return Problem("Entity set 'grad_projectContext.Customers'  is null.");
        //  }
        //    _context.Customers.Add(customer);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetCustomer", new { id = customer.CustomerId }, customer);
        //}

        // DELETE: api/Customers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            if (_context.Customers == null)
            {
                return NotFound();
            }
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }

            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();


            return NoContent();
        }

        private bool CustomerExists(int id)
        {
            return (_context.Customers?.Any(e => e.CustomerId == id)).GetValueOrDefault();
        }

        [HttpPost]
        public IActionResult PostCustomer([FromBody] CustomerModel customer)
        {
            try
            {
                // _context.Database.ExecuteSqlRaw(
                //"InsertCustomerAndCredentials",
                //new CustomerModel
                //{
                //    FirstName = customer.FirstName,
                //    LastName = customer.LastName,
                //    Email = customer.Email,
                //    JobTitle = customer.JobTitle,
                //    BusinessPhone = customer.BusinessPhone,
                //    HomePhone = customer.HomePhone,
                //    MobilePhone = customer.MobilePhone,
                //    Address = customer.Address,
                //    City = customer.City,
                //    StateProvince = customer.StateProvince,
                //    ZipPostalCode = customer.ZipPostalCode,
                //    CountryRegion = customer.CountryRegion,
                //    WebPage = customer.WebPage,
                //    Notes = customer.Notes,
                //    Attachments = customer.Attachments,
                //    CustomerName = customer.CustomerName,
                //    PasswordHash = customer.PasswordHash
                //}

                //);
                // Insert data into Customers table
                var newCustomer = new Models.Customer
                {
                    FirstName = customer.FirstName,
                    LastName = customer.LastName,
                    Email = customer.Email,
                    JobTitle = customer.JobTitle,
                    BusinessPhone = customer.BusinessPhone,
                    HomePhone = customer.HomePhone,
                    MobilePhone = customer.MobilePhone,
                    Address = customer.Address,
                    City = customer.City,
                    StateProvince = customer.StateProvince,
                    ZipPostalCode = customer.ZipPostalCode,
                    CountryRegion = customer.CountryRegion,
                    WebPage = customer.WebPage,
                    Notes = customer.Notes,
                    Attachments = customer.Attachments
                };

                _context.Customers.Add(newCustomer);
                _context.SaveChanges();

                // Get the auto-generated customer_id for the newly inserted customer
                var newCustomerId = newCustomer.CustomerId;

                // Insert data into CustomerCredentials table
                var newCustomerCredentials = new Customercredential
                {
                    CustomerId = newCustomerId,
                    CustomerName = customer.CustomerName,
                    PasswordHash = customer.PasswordHash,
                };

                _context.Customercredentials.Add(newCustomerCredentials);
                _context.SaveChanges();

                return Ok("Customer and credentials inserted successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }

    }
}
