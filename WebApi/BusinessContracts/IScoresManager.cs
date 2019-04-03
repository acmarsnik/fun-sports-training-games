using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FstgWebApi.DataContracts;

namespace FstgWebApi.BusinessContracts
{
	public interface IScoresManager
	{
		Task<IEnumerable<IScore>> GetScoresAsync();
        Task<IScore> InsertScoreAsync(IScore score);
    }
}
