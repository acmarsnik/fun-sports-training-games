using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Autofac.Extras.Moq;
using BC = BusinessContracts;
using FstgWebApi.Controllers;
using FstgWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;

using NUnit.Framework;

namespace WebApiUnitTests
{
	[TestFixture]
    public class ScoresControllerTests
    {
		[Test]
		public void Get_Returns_Ok()
		{
			var expected = HttpStatusCode.OK;

			var actual = ((ObjectResult)controller.Get()).StatusCode;

			Assert.AreEqual(expected, (HttpStatusCode)actual);
		}

		[Test]
		public void Get_Returns_10_Values()
		{
			var expected = 3;

			var actual = GetOjectResult<List<Score>>(controller.Get()).Count;

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void Get_Returns_Expected_Score_For_TheLast_Item()
		{
			var expected = 4;

			var actual = GetOjectResult<List<Score>>(controller.Get()).Last().score;

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void Get_Returns_Scores_From_ScoresManager()
		{
			controller.Get();
			scoresManager.Verify(it => it.GetScores());
		}

		private T GetOjectResult<T>(IActionResult result)
		{
			return (T)((ObjectResult)result).Value;
		}

		[SetUp]
		public void Setup()
		{
			

			var mockery = AutoMock.GetLoose();
			scoresManager = mockery.Mock<BC.IScoresManager>();
			scoresManager.Setup(it => it.GetScores()).Returns(() => TestScores);

			controller = mockery.Create<ScoresController>();

			SetupTestScores();
		}

		private void SetupTestScores()
		{
			TestScores = new List<BC.Score> {
				new BC.Score { Id = 1, Value = 10 },
				new BC.Score { Id = 2, Value = 7 },
				new BC.Score { Id = 3, Value = 4 }
			};
		}

		private List<BC.Score> TestScores;
		private ScoresController controller;
		private Mock<BC.IScoresManager> scoresManager;

	}


}
