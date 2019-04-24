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
    /// <summary>
    /// ScoresController
    /// </summary>
    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ScoresController : Controller
    {
        /// <summary>
        /// ScoresController Constructor
        /// </summary>
        /// <param name="scoreManager">IScoresManager </param>
        public ScoresController(IScoresManager scoreManager)
        {
            this.scoreManager = scoreManager;
        }

        private readonly IScoresManager scoreManager;

        /// <summary>
        /// Gets all scores
        /// </summary>
        /// <returns>IActionResult</returns>
        [HttpGet]
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

        //public IActionResult Put([FromBody]Score score)
        //{
        //    Debug.Write($"UserId: {score.UserId}, Score: {score.Value}");
        //    var response = new { status = "Created" };
        //    var output = StatusCode((int)HttpStatusCode.Created, response);
        //    return output;
        //}

        /// <summary>
        /// Adds a score
        /// </summary>
        /// <param name="score">A score object containing: userId, value </param>
        /// <returns>IActionResult</returns>
        [HttpPut]
        [HttpPost]
        [Produces("application/json")]
        public async Task<IActionResult> CreateAsync([FromBody]Score score)
        {
            IScore insertedScore = null;
            try
            {
                insertedScore = (IScore)await scoreManager.InsertScoreAsync(score);
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