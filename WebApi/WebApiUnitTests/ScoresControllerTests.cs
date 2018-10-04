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

			var actual = (HttpStatusCode)((ObjectResult)controller.Get()).StatusCode;

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void Get_Returns_10_Values()
		{
			var expected = 10;

			var actual = ((List<Score>)((ObjectResult)controller.Get()).Value).Count;

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void Get_Returns_Expected_Score_For_TheLast_Item()
		{
			var expected = 9;

			var actual = ((List<Score>)((ObjectResult)controller.Get()).Value).Last().score;

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void Get_Returns_Scores_From_ScoresManager()
		{
			controller.Get();
			scoresManager.Verify(it => it.GetScores());
		}

		[SetUp]
		public void Setup()
		{
			var mockery = AutoMock.GetLoose();

			scoresManager = mockery.Mock<BC.IScoresManager>();

			controller = mockery.Create<ScoresController>();
		}

		private ScoresController controller;
		private Mock<BC.IScoresManager> scoresManager;

	}


}
