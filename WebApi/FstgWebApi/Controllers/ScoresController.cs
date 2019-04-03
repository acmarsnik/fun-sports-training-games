using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using FstgWebApi.BusinessContracts;
using FstgWebApi.DataContracts;
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
        public ScoresController(IScoresManager scoreManager)
        {
            this.scoreManager = scoreManager;
        }

        private readonly IScoresManager scoreManager;

        public async Task<IActionResult> GetAsync()
        {
            var response = new List<Score>();
			IEnumerable<IScore> iEnumerableScores = await scoreManager.GetScoresAsync();
            List<IScore> scores = iEnumerableScores.ToList<IScore>();

            foreach (var score in scores)
			{
				response.Add(
					new Score {
						_id = score._id,
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
            Debug.Write($"Id: {score._id}, UserId: {score.UserId}, Score: {score.Value}");
            var response = new { status = "Created" };
            var output = StatusCode((int)HttpStatusCode.Created, response);
            return output;
        }

        [HttpPost]
        [Produces("application/json")]
        public IActionResult Create(IScore score)
        {
            IScore insertedScore = null;
            try
            {
                insertedScore = (IScore)scoreManager.InsertScoreAsync(score);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            var output = StatusCode((int)HttpStatusCode.Created, insertedScore);
            return output;
        }
	}
}