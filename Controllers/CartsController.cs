using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Grad_Project.Models;

namespace Grad_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartsController : ControllerBase
    {
        private readonly grad_projectContext _context;

        public CartsController(grad_projectContext context)
        {
            _context = context;
        }

        // GET: api/CartsWishList
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Cart>>> GetCart(int id)
        {
            if (_context.Carts.Any(x => x.CustomerId == id))
            {
                return await _context.Carts.Where(x => x.CustomerId == id).ToListAsync();
            }
            else
            {
                return NotFound();
            }

        }

        // GET: api/CartsWishList/5
        [HttpPost("{customerId}")]
        public IActionResult AddToCart(int customerId, [FromBody] CartItemModel cartItem)
        {
            // Retrieve the customer
            var customer = _context.Customers.FirstOrDefault(c => c.CustomerId == customerId);

            if (customer == null)
            {
                throw new InvalidOperationException("Customer not found");
            }

            // Create a new Cart entity
            var cartItemEntity = new Cart
            {
                CustomerId = customerId,
                ProductName = cartItem.ProductName,
                Quantity = cartItem.Quantity,
                Price = cartItem.Price
            };

            // Add the Cart entity to the database
            _context.Carts.Add(cartItemEntity);
            _context.SaveChanges();
            return Ok("Item added to the cart successfully.");
        }

        [HttpDelete("deleteCartItem/{cartid}")]
        public IActionResult DeleteCartItem(int cartid)
        {
            try
            {
                var cartItem = _context.Carts.FirstOrDefault(c => c.CartId == cartid);

                if (cartItem != null)
                {
                    _context.Carts.Remove(cartItem);
                    _context.SaveChanges();
                }
                return Ok("Item deleted from the cart successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }

        [HttpDelete("deleteAllCartItems/{customerId}")]
        public IActionResult DeleteAllCartItems(int customerId)
        {
            try
            {
                var cartItems = _context.Carts.Where(c => c.CustomerId == customerId).ToList();

                _context.Carts.RemoveRange(cartItems);
                _context.SaveChanges();
                return Ok("All items deleted from the cart successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }
        }
    }
