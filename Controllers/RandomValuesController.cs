using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace randomvalueapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RandomValuesController : ControllerBase
    {

        private readonly ILogger<RandomValuesController> _logger;

        public RandomValuesController(ILogger<RandomValuesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Randomevalues> Get()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();
            int length = 8;
            return Enumerable.Range(1, 1).Select(index => new Randomevalues
            {
                Random = new string(Enumerable.Repeat(chars, length)
                 .Select(s => s[random.Next(s.Length)]).ToArray())
            })
            .ToList();
        }
    }
}
