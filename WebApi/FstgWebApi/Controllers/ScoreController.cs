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
using MongoDB.Bson;
using MongoDB.Driver;

namespace FstgWebApi.Controllers
{
    /// <summary>
    /// ScoresController
    /// </summary>
    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ScoreController : Controller
    {
        /// <summary>
        /// ScoresController Constructor
        /// </summary>
        /// <param name="scoreManager">IScoresManager </param>
        public ScoreController(IScoresManager scoreManager)
        {
            this.scoreManager = scoreManager;
        }

        private readonly IScoresManager scoreManager;

        /// <summary>
        /// Gets Score by Id
        /// </summary>
        /// <returns>IActionResult</returns>
        [HttpGet]
        public async Task<IActionResult> GetByIdAsync(string _id)
        {
            IScore iScore = await scoreManager.GetScoreByIdAsync(new ObjectId(_id));
            ObjectResult output = StatusCode((int)HttpStatusCode.OK, (Score)iScore);
            return output;
        }

        /// <summary>
        /// Gets scores by User Id
        /// </summary>
        /// <returns>IActionResult</returns>
        [Route("User")]
        [HttpGet]
        public async Task<IActionResult> GetByUserIdAsync(int userId)
        {
            IEnumerable<IScore> iEnumerableIScores = await scoreManager.GetScoresByUserIdAsync(userId);
            List<Score> listScores = ConvertIEnumerableIScoreToListScore(iEnumerableIScores);
            ObjectResult output = StatusCode((int)HttpStatusCode.OK, listScores);
            return output;
        }

        /// <summary>
        /// Gets all scores
        /// </summary>
        /// <returns>IActionResult</returns>
        [Route("All")]
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            IEnumerable<IScore> iEnumerableIScores = await scoreManager.GetScoresAsync();
            List<Score> listScores = ConvertIEnumerableIScoreToListScore(iEnumerableIScores);
            ObjectResult output = StatusCode((int)HttpStatusCode.OK, listScores);
            return output;
        }

        /// <summary>
        /// Adds a score
        /// </summary>
        /// <param name="score">A score object containing: userId, value </param>
        /// <returns>IActionResult</returns>
        [HttpPost]
        [Produces("application/json")]
        public async Task<IActionResult> CreateAsync(Score score)
        {
            IScore insertedScore = null;
            try
            {
                insertedScore = await scoreManager.InsertScoreAsync(score);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            var output = StatusCode((int)HttpStatusCode.Created, insertedScore);
            return output;
        }

        /// <summary>
        /// Updates a score
        /// </summary>
        /// <param name="_id">the id of the score </param>
        /// <param name="score">A score object containing: userId, value </param>
        /// <returns>IActionResult</returns>
        [HttpPut]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateAsync(string _id, Score score)
        {
            IScore insertedScore = null;
            try
            {
                score._id = new ObjectId(_id);
                insertedScore = await scoreManager.UpdateScoreAsync(score);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            var output = StatusCode((int)HttpStatusCode.Created, insertedScore);
            return output;
        }

        /// <summary>
        /// Deletes a score
        /// </summary>
        /// <param name="_id">the id of the score </param>
        /// <returns>IActionResult</returns>
        [HttpDelete]
        [Produces("application/json")]
        public async Task<IActionResult> DeleteAsync(string _id)
        {
            DeleteResult deleteResult = null;
            try
            {
                deleteResult = await scoreManager.DeleteScoreAsync(new ObjectId(_id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            var output = StatusCode((int)HttpStatusCode.OK, deleteResult);
            return output;
        }

        /// <summary>
        /// Deletes all scores
        /// </summary>
        /// <returns>IActionResult</returns>
        [Route("All")]
        [HttpDelete]
        [Produces("application/json")]
        public async Task<IActionResult> DeleteAllAsync()
        {
            DeleteResult deleteResult = null;
            try
            {
                deleteResult = await scoreManager.DeleteAllScoresAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            var output = StatusCode((int)HttpStatusCode.OK, deleteResult);
            return output;
        }

        // TODO: Move out of controller
        private List<Score> ConvertIEnumerableIScoreToListScore(IEnumerable<IScore> iEnumerableIScores)
        {
            var response = new List<Score>();

            try
            {
                List<IScore> scores = iEnumerableIScores.ToList();

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
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return response;
        }
    }
}