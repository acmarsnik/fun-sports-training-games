using FstgWebApi.BusinessContracts;
using FstgWebApi.DataAccess;
using FstgWebApi.DataContracts;
using FstgWebApi.DataModels;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FstgWebApi.BusinessLogic
{
    public class ScoresManager : IScoresManager
    {
        private readonly FstgContext _context;

        public ScoresManager(IOptions<Settings> settings)
        {
            _context = new FstgContext(settings);
        }

        public async Task<IScore> GetScoreByIdAsync(ObjectId _id)
        {
            try
            {
                IAsyncCursor<Score> asyncCursorScore = await _context.Scores.FindAsync(score => score._id == _id);
                Score selectedScore = await asyncCursorScore.FirstOrDefaultAsync();
                return selectedScore;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<IScore>> GetScoresByUserIdAsync(int userId)
        {
            try
            {
                IAsyncCursor<Score> asyncCursorUserScores = await _context.Scores.FindAsync(score => score.UserId == userId);
                List<Score> userScores = await asyncCursorUserScores.ToListAsync();
                return userScores;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<IEnumerable<IScore>> GetScoresAsync()
        {
            //TODO: fetch this data from the data access layer
            try
            {
                IAsyncCursor<Score> asyncCursorAllScores = await _context.Scores.FindAsync(_ => true);
                List<Score> allScores = await asyncCursorAllScores.ToListAsync();
                return allScores;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IScore> InsertScoreAsync(IScore score)
        {
            //TODO: fetch this data from the data access layer
            try
            {
                await _context.Scores.InsertOneAsync((Score)score);
                return score;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public async Task<IScore> UpdateScoreAsync(IScore score)
        {
            //TODO: fetch this data from the data access layer
            try
            {
                var filter = Builders<Score>.Filter.Eq("_id", score._id);
                var update = Builders<Score>.Update
                                .Set(mongoScore => mongoScore.Value, score.Value)
                                .Set(mongoScore => mongoScore.UserId, score.UserId);
                //.CurrentDate(s => s.UpdatedOn);
                await _context.Scores.UpdateOneAsync(filter, update);
                return score;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public async Task<DeleteResult> DeleteScoreAsync(ObjectId _id)
        {
            //TODO: fetch this data from the data access layer
            try
            {
                DeleteResult deleteResult = await _context.Scores.DeleteOneAsync(Builders<Score>.Filter.Eq("_id", _id));
                return deleteResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public async Task<DeleteResult> DeleteAllScoresAsync()
        {
            //TODO: fetch this data from the data access layer
            try
            {
                DeleteResult deleteResult = await _context.Scores.DeleteManyAsync(Builders<Score>.Filter.Empty);
                return deleteResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
