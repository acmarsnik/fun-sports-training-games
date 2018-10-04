using BusinessContracts;
using System;
using System.Collections.Generic;

namespace BusinessLogic
{
	public class ScoresManager : IScoresManager
	{
		public IEnumerable<Score> GetScores()
		{
			//TODO: fetch this data from the data access layer

			var results = new List<Score>
			{
				new Score { Id = 1, Value = 10 },
				new Score { Id = 2, Value = 7 },
				new Score { Id = 3, Value = 4 },
				new Score { Id = 4, Value = 8 },
				new Score { Id = 5, Value = 7 },
				new Score { Id = 6, Value = 6 },
				new Score { Id = 7, Value = 5 },
				new Score { Id = 8, Value = 3 },
				new Score { Id = 9, Value = 10 },
				new Score { Id = 10, Value = 9 }
			};

			return results;
		}
	}
}
