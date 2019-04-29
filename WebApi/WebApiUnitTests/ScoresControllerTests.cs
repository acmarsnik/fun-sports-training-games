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
using MongoDB.Bson;

namespace WebApiUnitTests
{
    [TestFixture]
    public class ScoresControllerTests
    {
        [Test]
        public async Task Get_Returns_OkAsync()
        {
            var expected = HttpStatusCode.OK;

            var actual = ((ObjectResult)await controller.GetAsync()).StatusCode;

            Assert.AreEqual(expected, (HttpStatusCode)actual);
        }

        //[Test]
        //public async Task Get_Returns_10_ValuesAsync()
        //{
        //    var expected = 3;

        //    var actual = GetObjectResult<List<IScore>>(await controller.GetAsync()).Count;

        //    Assert.AreEqual(expected, actual);
        //}

        //[Test]
        //public async Task Get_Returns_Expected_Score_For_TheLast_ItemAsync()
        //{
        //    int expected = 4;
        //    var actual = GetObjectResult<List<Score>>(await controller.GetAsync());
        //    //.LastOrDefault().Value
        //    Assert.AreEqual(expected, actual);
        //}

        //[Test]
        //public async Task Get_Returns_Scores_From_ScoresManagerAsync()
        //{
        //    await controller.GetAsync();
        //    scoresManager.Verify(it => it.GetScoresAsync());
        //}

        //private T GetObjectResult<T>(IActionResult result)
        //{
        //    return (T)((ObjectResult)result).Value;
        //}

        [SetUp]
        public void Setup()
        {


            var mockery = AutoMock.GetLoose();
            scoresManager = mockery.Mock<IScoresManager>();
            SetupTestScores();
            // Throws error: invalid setup on a non-virtual (overridable in vb) member
            //scoresManager.Setup(it => it.GetScoresAsync().Result).Returns(() => TestScores);
            controller = mockery.Create<ScoreController>();


        }

        private void SetupTestScores()
        {
            ObjectId objectId1 = new ObjectId();
            ObjectId objectId2 = new ObjectId();
            ObjectId objectId3 = new ObjectId();

            TestScores = new List<IScore> {
                new Score { _id = objectId1, UserId = 1, Value = 10 },
                new Score { _id = objectId2, UserId = 2, Value = 7 },
                new Score { _id = objectId3, UserId = 3, Value = 4 }
            };
        }

        private IEnumerable<IScore> TestScores;
        private IScoreController controller;
        private Mock<IScoresManager> scoresManager;

    }


}
