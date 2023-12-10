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
    public class WishlistsController : ControllerBase
    {
        private readonly grad_projectContext _context;

        public WishlistsController(grad_projectContext context)
        {
            _context = context;
        }

        // GET: api/Wishlists
        [HttpGet("id")]
        public async Task<ActionResult<IEnumerable<Wishlist>>> GetWishlists(int id)
        {
            if (_context.Wishlists.Any(x => x.CustomerId == id))
            {
                return await _context.Wishlists.Where(x => x.CustomerId == id).ToListAsync();
            }
            else
            {
                return NotFound();
            }
        }

        // GET: api/Wishlists/5
        [HttpPost("{customerId}/{productId}")]
        public IActionResult AddToWishlist(int customerId, int productId)
        {
            // Retrieve the customer
            var customer = _context.Customers.FirstOrDefault(c => c.CustomerId == customerId);

            if (customer == null)
            {
                throw new InvalidOperationException("Customer not found");
            }

            var wishlistItem = new Wishlist
            {
                CustomerId = customerId,
                ProductId = productId
                // You might need to set other properties of the Wishlist entity based on your model
            };

            // Add the Cart entity to the database
            _context.Wishlists.Add(wishlistItem);
            _context.SaveChanges();
            return Ok("Item added to the cart successfully.");
        }

        [HttpDelete("deleteWishItem/{customerId}/{productId}")]
        public IActionResult DeleteCartItem(int customerId, int productId)
        {
            try
            {
                var wishItem = _context.Wishlists.FirstOrDefault(c => c.CustomerId == customerId && c.ProductId == productId);

                if (wishItem != null)
                {
                    _context.Wishlists.Remove(wishItem);
                    _context.SaveChanges();
                }
                return Ok("Item deleted from the cart successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }

        [HttpDelete("deleteAllWishItems/{customerId}")]
        public IActionResult DeleteAllCartItems(int customerId)
        {
            try
            {
                var wishItems = _context.Wishlists.Where(c => c.CustomerId == customerId).ToList();

                _context.Wishlists.RemoveRange(wishItems);
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
