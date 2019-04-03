using FstgWebApi.BusinessContracts;
using FstgWebApi.DataAccess;
using FstgWebApi.DataContracts;
using FstgWebApi.DataModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
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

        public async Task<IEnumerable<IScore>> GetScoresAsync()
		{
            //TODO: fetch this data from the data access layer
            try
            {
                return await _context.Scores.Find(_ => true).ToListAsync();
            }
            catch(Exception ex)
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
    }
}
