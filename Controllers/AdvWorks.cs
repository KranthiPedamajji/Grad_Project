using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Grad_Project.AdventWorksModel;

namespace Grad_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvWorks : ControllerBase
    {
        private readonly adventureworksContext _context;

        public AdvWorks(adventureworksContext context)
        {
            _context = context;
        }

        // GET: api/AdvWorks
        [HttpGet]
        public IActionResult GetProductsAndPhotos()
        {
            var query = from p in _context.Products
                        join ppp in _context.Productproductphotos on p.ProductId equals ppp.ProductId
                        join pp in _context.Productphotos on ppp.ProductPhotoId equals pp.ProductPhotoId
                        select new
                        {
                            Product = p,
                            ProductProductPhoto = ppp,
                            ProductPhoto = pp
                        };

            var result = query.ToList();
            return Ok(result);
        }

        // GET: api/AdvWorks/5
        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var query = from p in _context.Products
                        join ppp in _context.Productproductphotos on p.ProductId equals ppp.ProductId
                        join pp in _context.Productphotos on ppp.ProductPhotoId equals pp.ProductPhotoId
                        where p.ProductId == id 
                        select new
                        {
                            Product = p,
                            ProductProductPhoto = ppp,
                            ProductPhoto = pp
                        };

            var result =  query.FirstOrDefault();
            return Ok(result);
        }

        //[HttpGet("image")]
        //public IActionResult GetImage()
        //{
        //    // Replace this with the actual base64-encoded image string from your database
        //    string base64String = "R0lGODlhw7AAwpUAw7cAAAAAAMKAAAAAwoAAwoDCgAAAAMKAwoAAwoAAwoDCgMKAwoDCgMOAw4DDgMO/AAAAw78Aw7/DvwAAAMO/w78Aw78Aw7/Dv8O/w7/DvwAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAMwAAZgAAwpkAAMOMAADDvwAzAAAzMwAzZgAzwpkAM8OMADPDvwBmAABmMwBmZgBmwpkAZsOMAGbDvwDCmQAAwpkzAMKZZgDCmcKZAMKZw4wAwpnDvwDDjAAAw4wzAMOMZgDDjMKZAMOMw4wAw4zDvwDDvwAAw78zAMO/ZgDDv8KZAMO/w4wAw7/DvzMAADMAMzMAZjMAwpkzAMOMMwDDvzMzADMzMzMzZjMzwpkzM8OMMzPDvzNmADNmMzNmZjNmwpkzZsOMM2bDvzPCmQAzwpkzM8KZZjPCmcKZM8KZw4wzwpnDvzPDjAAzw4wzM8OMZjPDjMKZM8OMw4wzw4zDvzPDvwAzw78zM8O/ZjPDv8KZM8O/w4wzw7/Dv2YAAGYAM2YAZmYAwplmAMOMZgDDv2YzAGYzM2YzZmYzwplmM8OMZjPDv2ZmAGZmM2ZmZmZmwplmZsOMZmbDv2bCmQBmwpkzZsKZZmbCmcKZZsKZw4xmwpnDv2bDjABmw4wzZsOMZmbDjMKZZsOMw4xmw4zDv2bDvwBmw78zZsO/ZmbDv8KZZsO/w4xmw7/Dv8KZAADCmQAzwpkAZsKZAMKZwpkAw4zCmQDDv8KZMwDCmTMzwpkzZsKZM8KZwpkzw4zCmTPDv8KZZgDCmWYzwplmZsKZZsKZwplmw4zCmWbDv8KZwpkAwpnCmTPCmcKZZsKZwpnCmcKZwpnDjMKZwpnDv8KZw4wAwpnDjDPCmcOMZsKZw4zCmcKZw4zDjMKZw4zDv8KZw78AwpnDvzPCmcO/ZsKZw7/CmcKZw7/DjMKZw7/Dv8OMAADDjAAzw4wAZsOMAMKZw4wAw4zDjADDv8OMMwDDjDMzw4wzZsOMM8KZw4wzw4zDjDPDv8OMZgDDjGYzw4xmZsOMZsKZw4xmw4zDjGbDv8OMwpkAw4zCmTPDjMKZZsOMwpnCmcOMwpnDjMOMwpnDv8OMw4wAw4zDjDPD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";

        //    if (base64String == null)
        //    {
        //        return NotFound();
        //    }

        //    // Convert the base64 string to bytes
        //    byte[] imageBytes = Convert.FromBase64String(base64String);

        //    // Return the image as a file
        //    return File(imageBytes, "image/jpeg"); // Assuming it's a JPEG image, adjust the content type accordingly
        //}
    }
}
