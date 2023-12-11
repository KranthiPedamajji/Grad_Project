using Grad_Project.AdventWorksModel;
using Grad_Project.Models;
using Grad_Project.NorthWindModels;
using Grad_Project.Sakila;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Grad_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly grad_projectContext _gcontext;
        private readonly sakilaContext _scontext;
        private readonly northwindContext _ncontext;
        private readonly adventureworksContext _acontext;


        public OrdersController(grad_projectContext context, sakilaContext _scontext, northwindContext _ncontext, adventureworksContext _acontext)
        {
            _gcontext = context;
        }

        [HttpPost("createOrder")]
        public IActionResult CreateOrder([FromBody] OrdersModel orderModel)
        {
            //_context.Orders.Add(newOrder);

            // Handle the result or return appropriate response
            return Ok("Order created successfully.");
        }

        [HttpPost("cancelOrder")]
        public IActionResult CancelOrder([FromBody] int orderId)
        {
            // Call your stored procedure using DbContext
            _gcontext.Database.ExecuteSqlRaw("CALL CancelOrder({0})", orderId);

            // Handle the result or return appropriate response
            return Ok("Order canceled successfully.");
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Models.Order>>> GetOrders()
        {
            if (_gcontext.Orders == null)
            {
                return NotFound();
            }
            return await _gcontext.Orders.ToListAsync();
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
            IQueryable<Models.Order> query = _gcontext.Orders;

            query = query.Where(o => o.CustomerId == customerId);

            var orders = query.ToList();
            return Ok(orders);
        }

    }
}
