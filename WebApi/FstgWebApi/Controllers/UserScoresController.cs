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
    public class UserScoresController : Controller
    {
        /// <summary>
        /// ScoresController Constructor
        /// </summary>
        /// <param name="userScoreManager">IScoresManager </param>
        public UserScoresController(IUserScoresManager userScoreManager)
        {
            this.userScoreManager = userScoreManager;
        }

        private readonly IUserScoresManager userScoreManager;

        /// <summary>
        /// Gets scores by user id
        /// </summary>
        /// <returns>IActionResult</returns>
        [HttpGet]
        public async Task<IActionResult> GetByUserIdAsync(int userId)
        {
            var response = new List<Score>();
            IEnumerable<IScore> iEnumerableScores = await userScoreManager.GetScoresByUserIdAsync(userId);
            List<IScore> scores = iEnumerableScores.ToList<IScore>();

            foreach (var score in scores)
            {
                response.Add(
                    new Score
                    {
                        _id = score._id,
                        UserId = score.UserId,
                        Value = score.Value
                    });
            }

            var output = StatusCode((int)HttpStatusCode.OK, response);
            return output;
        }
    }
}