using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FstgWebApi.DataContracts;

namespace FstgWebApi.BusinessContracts
{
    public interface IUserScoresManager
    {
        Task<IEnumerable<IScore>> GetScoresByUserIdAsync(int userId);
    }
}
