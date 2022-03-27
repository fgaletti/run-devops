using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using Shooping.API.Model;
using Shopping.Client.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shooping.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly ProductContext _context;

        public ProductController(ILogger<ProductController> logger, ProductContext context)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        [HttpGet]
        public async Task< IEnumerable<Product>> Get()
        {
            return await _context.Products.Find(prop => true).ToListAsync();
            //var rng = new Random();

            //return Enumerable.Range(1, 5).Select(index =>
            // new Product
            // {
            //     Name = "aaa"
            // }
            //).ToArray();
        }

    }
}
