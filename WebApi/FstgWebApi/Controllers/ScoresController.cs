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
    [Route("api/getTargetScores")]
    public class ScoresController : Controller
    {
        public IActionResult Get()
        {
            var response = new List<Score>
            {
                new Score { id = 1, score = 10 },
                new Score { id = 2, score = 7 },
                new Score { id = 3, score = 4 },
                new Score { id = 4, score = 8 },
                new Score { id = 5, score = 7 },
                new Score { id = 6, score = 6 },
                new Score { id = 7, score = 5 },
                new Score { id = 8, score = 3 },
                new Score { id = 9, score = 10 },
                new Score { id = 10, score = 9 }
            };

            var output = StatusCode((int)HttpStatusCode.OK, response);
            return output;
        }
    }
}