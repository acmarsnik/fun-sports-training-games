using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Autofac.Extras.Moq;
using FstgWebApi.DataModels;
using FstgWebApi.BusinessContracts;
using FstgWebApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;

using NUnit.Framework;
using System.Threading.Tasks;
using FstgWebApi.DataContracts;

namespace WebApiUnitTests
{
	[TestFixture]
    public class ScoresControllerTests
    {
		[Test]
		public async Task Get_Returns_OkAsync()
		{
			var expected = HttpStatusCode.OK;

			var actual = ((ObjectResult) await controller.GetAsync()).StatusCode;

			Assert.AreEqual(expected, (HttpStatusCode)actual);
		}

		[Test]
		public async Task Get_Returns_10_ValuesAsync()
		{
			var expected = 3;

			var actual = GetOjectResult<List<IScore>>(await controller.GetAsync()).Count;

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public async Task Get_Returns_Expected_Score_For_TheLast_ItemAsync()
		{
			var expected = 4;

			var actual = GetOjectResult<List<IScore>>(await controller.GetAsync()).Last().Value;

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public async Task Get_Returns_Scores_From_ScoresManagerAsync()
		{
            await controller.GetAsync();
			scoresManager.Verify(it => it.GetScoresAsync());
		}

		private T GetOjectResult<T>(IActionResult result)
		{
			return (T)((ObjectResult)result).Value;
		}

		[SetUp]
		public void Setup()
		{
			

			var mockery = AutoMock.GetLoose();
			scoresManager = mockery.Mock<IScoresManager>();
			scoresManager.Setup(it => it.GetScoresAsync().Result).Returns(() => TestScores);

			controller = mockery.Create<ScoresController>();

			SetupTestScores();
		}

		private void SetupTestScores()
		{
			TestScores = new List<IScore> {
				new Score { UserId = 1, Value = 10 },
				new Score { UserId = 2, Value = 7 },
				new Score { UserId = 3, Value = 4 }
			};
		}

		private List<IScore> TestScores;
		private ScoresController controller;
		private Mock<IScoresManager> scoresManager;

	}


}
