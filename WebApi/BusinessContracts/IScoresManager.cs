using System;
using System.Collections.Generic;
using FstgWebApi.DataContracts;

namespace FstgWebApi.BusinessContracts
{
	public interface IScoresManager
	{
		IEnumerable<IScore> GetScores();
	}
}
