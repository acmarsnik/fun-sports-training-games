using System;
using System.Collections.Generic;

namespace BusinessContracts
{
	public interface IScoresManager
	{
		IEnumerable<Score> GetScores();
	}
}
