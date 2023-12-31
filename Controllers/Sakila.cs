﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Grad_Project.Sakila;

namespace Grad_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Sakila : ControllerBase
    {
        private readonly sakilaContext _context;

        public Sakila(sakilaContext context)
        {
            _context = context;
        }

        // GET: api/SakilaCustomers
        [HttpGet("customers")]
        public async Task<ActionResult<IEnumerable<Customer>>> GetSakilaCustomers()
        {
          if (_context.Customers == null)
          {
              return NotFound();
          }
            return await _context.Customers.ToListAsync();
        }

        // GET: api/SakilaCustomers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetSakilaCustomer(ushort id)
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


        [HttpGet("product")]
        public async Task<ActionResult<IEnumerable<Film>>> SakilaProducts(ushort id)
        {
            var products = await _context.Films.ToListAsync();

            return products;
        }

        [HttpGet("product/{id}")]
        public async Task<ActionResult<Film>> SakilaProduct(ushort id)
        {
            if (_context.Films == null)
            {
                return NotFound();
            }
            var films = await _context.Films.FindAsync(id);

            if (films == null)
            {
                return NotFound();
            }

            return films;
        }


        //// PUT: api/SakilaCustomers/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutCustomer(ushort id, Customer customer)
        //{
        //    if (id != customer.CustomerId)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(customer).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!CustomerExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/SakilaCustomers
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Customer>> PostCustomer(Customer customer)
        //{
        //  if (_context.Customers == null)
        //  {
        //      return Problem("Entity set 'sakilaContext.Customers'  is null.");
        //  }
        //    _context.Customers.Add(customer);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetCustomer", new { id = customer.CustomerId }, customer);
        //}

        //// DELETE: api/SakilaCustomers/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteCustomer(ushort id)
        //{
        //    if (_context.Customers == null)
        //    {
        //        return NotFound();
        //    }
        //    var customer = await _context.Customers.FindAsync(id);
        //    if (customer == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Customers.Remove(customer);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        private bool CustomerExists(ushort id)
        {
            return (_context.Customers?.Any(e => e.CustomerId == id)).GetValueOrDefault();
        }
    }
}
