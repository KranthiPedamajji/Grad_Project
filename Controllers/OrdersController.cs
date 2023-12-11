using Grad_Project.Models;
using Grad_Project.NorthWindModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Grad_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly grad_projectContext _context;

        public OrdersController(grad_projectContext context)
        {
            _context = context;
        }

        [HttpPost("create-from-carts")]
        public IActionResult CreateOrdersFromCarts([FromBody] List<Cart> carts)
        {
            try
            {
                // Validate the cart data
                if (carts == null || !carts.Any())
                {
                    return BadRequest("Invalid cart data");
                }

                // Validate that all cart items have the same customer ID
                var distinctCustomerIds = carts.Select(c => c.CustomerId).Distinct().Count();
                if (distinctCustomerIds > 1)
                {
                    return BadRequest("All cart items must have the same customer ID");
                }

                var newOrder = new Models.Order
                {
                    CustomerId = carts.First().CustomerId.Value,
                    OrderDate = DateTime.Now,
                    TotalPrice = 0,
                };


                // Add the new order to the database
                _context.Orders.Add(newOrder);
                _context.SaveChanges();

                int orderId = newOrder.OrderId;

                // Add order details for each cart item
                foreach (var cart in carts)
                {
                    // Validate the cart item data
                    if (string.IsNullOrEmpty(cart.ProductName) || cart.Quantity == null)
                    {
                        return BadRequest("Invalid cart item data");
                    }

                    // Assuming OrderDetail includes necessary information for the order details
                    var orderDetail = new Models.Orderdetail
                    {
                        ProductName = cart.ProductName,
                        Quantity = cart.Quantity.Value,
                        OrderId = orderId

                    };

                    _context.Orderdetails.Add(orderDetail);
                    _context.SaveChanges();

                    // Add the order detail to the order
                    //newOrder.OrderDetails.Add(orderDetail);
                }
               

                // Save changes to the database
                _context.SaveChanges();

                return Ok(new { Message = "Order created successfully" });
            }
            catch (Exception ex)
            {
                // Log the exception
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }


        [HttpPost("cancelOrder")]
        public IActionResult CancelOrder([FromBody] int orderId)
        {
            // Call your stored procedure using DbContext
            _context.Database.ExecuteSqlRaw("CALL CancelOrder({0})", orderId);

            // Handle the result or return appropriate response
            return Ok("Order canceled successfully.");
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Models.Order>>> GetOrders()
        {
            if (_context.Orders == null)
            {
                return NotFound();
            }
            return await _context.Orders.ToListAsync();
        }

        //[HttpGet("{id}")]
        //public async Task<ActionResult<Order>> GetOrder(int id)
        //{
        //    if (_context.Orders == null)
        //    {
        //        return NotFound();
        //    }
        //    var order = await _context.Orders.FindAsync(id);

        //    if (order == null)
        //    {
        //        return NotFound();
        //    }

        //    return order;
        //}

        [HttpGet("{customerId}")]
        public ActionResult<IEnumerable<Models.Order>> GetOrders(int customerId)
        {
            IQueryable<Models.Order> query = _context.Orders;

            query = query.Where(o => o.CustomerId == customerId);

            var orders = query.ToList();
            return Ok(orders);
        }

    }
}
