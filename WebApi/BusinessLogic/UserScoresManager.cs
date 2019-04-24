using FstgWebApi.BusinessContracts;
using FstgWebApi.DataAccess;
using FstgWebApi.DataContracts;
using FstgWebApi.DataModels;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FstgWebApi.BusinessLogic
{
    public class UserScoresManager : IUserScoresManager
    {
        private readonly FstgContext _context;

        public UserScoresManager(IOptions<Settings> settings)
        {
            _context = new FstgContext(settings);
        }

        public async Task<IEnumerable<IScore>> GetScoresByUserIdAsync(int userId)
        {
            //TODO: fetch this data from the data access layer
            try
            {
                var allScores = await _context.Scores.Find(score => score.UserId == userId).ToListAsync();
                return allScores;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
