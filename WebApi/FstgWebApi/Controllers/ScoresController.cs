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
            var response = new List<Score>();
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