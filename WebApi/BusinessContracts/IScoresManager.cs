using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FstgWebApi.DataContracts;
using MongoDB.Bson;
using MongoDB.Driver;

namespace FstgWebApi.BusinessContracts
{
    public interface IScoresManager
    {
        Task<IScore> GetScoreByIdAsync(ObjectId _id);
        Task<IEnumerable<IScore>> GetScoresAsync();
        Task<IEnumerable<IScore>> GetScoresByUserIdAsync(int userId);
        Task<IScore> InsertScoreAsync(IScore score);
        Task<IScore> UpdateScoreAsync(IScore score);
        Task<DeleteResult> DeleteScoreAsync(ObjectId _id);
        Task<DeleteResult> DeleteAllScoresAsync();
    }
}
