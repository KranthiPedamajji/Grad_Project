using Grad_Project.Models;
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

        [HttpPost("createOrder")]
        public IActionResult CreateOrder([FromBody] OrdersModel orderModel)
        {
            // Call your stored procedure using DbContext
            _context.Database.ExecuteSqlRaw("CALL CreateOrder({0}, {1}, {2})",
                orderModel.CustomerId, orderModel.ProductIds, orderModel.Quantities);

            // Handle the result or return appropriate response
            return Ok("Order created successfully.");
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
        public async Task<ActionResult<IEnumerable<Order>>> GetOrders()
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
        public ActionResult<IEnumerable<Order>> GetOrders(int customerId)
        {
            IQueryable<Order> query = _context.Orders;

            query = query.Where(o => o.CustomerId == customerId);

            var orders = query.ToList();
            return Ok(orders);
        }

    }
}
