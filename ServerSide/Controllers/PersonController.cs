using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ModelShared;
using ServerSide.DataAccess;

namespace ServerSide.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly AppDbContext _context;


        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Person> Get()
        {
            var rng = new Random();
            return _context.Person.ToArray();


        }
    }
}