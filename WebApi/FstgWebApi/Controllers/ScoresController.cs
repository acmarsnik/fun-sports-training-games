using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using BC = BusinessContracts;
using FstgWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FstgWebApi.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]")]
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

			var scores = scoreManager.GetScores();
			foreach (var score in scores)
			{
				response.Add(
					new Score {
						id = score.Id,
						score = score.Value
					});
			}

			var output = StatusCode((int)HttpStatusCode.OK, response);
            return output;
        }

        // PUT api/values/5
        [HttpPut]
        public IActionResult Put([FromBody]NewScore newScore)
        {
            Debug.Write($"Score: {newScore.Score}, UserId: {newScore.UserId}");
            var response = new { status = "Created" };
            var output = StatusCode((int)HttpStatusCode.Created, response);
            return output;
        }


		public ScoresController(BC.IScoresManager scoreManager)
		{
			this.scoreManager = scoreManager;
		}

		private readonly BC.IScoresManager scoreManager;
	}
}