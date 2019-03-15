using FstgWebApi.BusinessContracts;
using FstgWebApi.DataContracts;
using FstgWebApi.DataModels;
using System;
using System.Collections.Generic;

namespace FstgWebApi.BusinessLogic
{
	public class ScoresManager : IScoresManager
	{
		public IEnumerable<IScore> GetScores()
		{
			//TODO: fetch this data from the data access layer

			var results = new List<IScore>
			{
				new Score { Id = 1, UserId = 1, Value = 10 },
				new Score { Id = 2, UserId = 1, Value = 7 },
				new Score { Id = 3, UserId = 1, Value = 4 },
				new Score { Id = 4, UserId = 1, Value = 8 },
				new Score { Id = 5, UserId = 1, Value = 7 },
				new Score { Id = 6, UserId = 1, Value = 6 },
				new Score { Id = 7, UserId = 1, Value = 5 },
				new Score { Id = 8, UserId = 1, Value = 3 },
				new Score { Id = 9, UserId = 1, Value = 10 },
				new Score { Id = 10, UserId = 1, Value = 9 }
			};

			return results;
		}
	}
}
