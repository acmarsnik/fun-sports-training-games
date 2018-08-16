using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using FstgWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FstgWebApi.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/Scores")]
    public class ScoresController : Controller
    {
        public IActionResult Get()
        {
            var response = new List<Score>
            {
                new Score { Id = 1, Value = 10 },
                new Score { Id = 2, Value = 6 }
            };

            var output = StatusCode((int)HttpStatusCode.OK, response);
            return output;
        }
    }
}