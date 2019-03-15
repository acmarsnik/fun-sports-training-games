using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using FstgWebApi.BusinessContracts;
using FstgWebApi.DataModels;
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
						Id = score.Id,
                        UserId = score.UserId,
						Value = score.Value
					});
			}

			var output = StatusCode((int)HttpStatusCode.OK, response);
            return output;
        }

        // PUT api/values/5
        [HttpPut]
        public IActionResult Put([FromBody]Score score)
        {
            Debug.Write($"Id: {score.Id}, UserId: {score.UserId}, Score: {score.Value}");
            var response = new { status = "Created" };
            var output = StatusCode((int)HttpStatusCode.Created, response);
            return output;
        }


		public ScoresController(IScoresManager scoreManager)
		{
			this.scoreManager = scoreManager;
		}

		private readonly IScoresManager scoreManager;
	}
}