using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using FstgWebApi.DataModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace FstgWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private IMongoDatabase mongoDatabase;

        //Generic method to get the mongodb database details  
        public IMongoDatabase GetMongoDatabase()
        {
            var mongoClient = new MongoClient("mongodb://localhost:27017");
            return mongoClient.GetDatabase("fstg");
        }

        [HttpGet]
        public IActionResult Index()
        {
            //Get the database connection  
            mongoDatabase = GetMongoDatabase();
            //fetch the details from CustomerDB and pass into view  
            var result = mongoDatabase.GetCollection<Score>("TargetScores").Find(FilterDefinition<Score>.Empty).ToList();
            var output = StatusCode((int)HttpStatusCode.OK, result);
            return output;
        }

        [HttpPost]
        [Produces("application/json")]
        [Route("api/Add/Score")]
        public IActionResult Create(Score score)
        {
            try
            {
                //Get the database connection  
                mongoDatabase = GetMongoDatabase();
                mongoDatabase.GetCollection<Score>("TargetScores").InsertOne(score);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            var output = StatusCode((int)HttpStatusCode.Created, "Inserted");
            return output;
        }


        //[HttpGet]
        //public IActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }
        //    //Get the database connection  
        //    mongoDatabase = GetMongoDatabase();
        //    //fetch the details from CustomerDB and pass into view  
        //    Customer customer = mongoDatabase.GetCollection<Score>("TargetScores").Find<Score>(k => k.CustomerId == id).FirstOrDefault();
        //    if (customer == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(customer);
        //}

        //[HttpPost]
        //public IActionResult Delete(Customer customer)
        //{
        //    try
        //    {
        //        //Get the database connection  
        //        mongoDatabase = GetMongoDatabase();
        //        //Delete the customer record  
        //        var result = mongoDatabase.GetCollection<Score>("TargetScores").DeleteOne<Score>(k => k.CustomerId == customer.CustomerId);
        //        if (result.IsAcknowledged == false)
        //        {
        //            return BadRequest("Unable to Delete Customer " + customer.CustomerId);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //    return RedirectToAction("Index");
        //}

        //[HttpGet]
        //public IActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }
        //    //Get the database connection  
        //    mongoDatabase = GetMongoDatabase();
        //    //fetch the details from CustomerDB based on id and pass into view  
        //    var customer = mongoDatabase.GetCollection<Score>("TargetScores").Find<Score>(k => k.CustomerId == id).FirstOrDefault();
        //    if (customer == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(customer);
        //}

        //[HttpPost]
        //public IActionResult Edit(Customer customer)
        //{
        //    try
        //    {
        //        //Get the database connection  
        //        mongoDatabase = GetMongoDatabase();
        //        //Build the where condition  
        //        var filter = Builders<Score>.Filter.Eq("TargetScoreId", customer.CustomerId);
        //        //Build the update statement   
        //        var updatestatement = Builders<Score>.Update.Set("TargetScoreId", customer.CustomerId);
        //        updatestatement = updatestatement.Set("TargetScoreName", customer.CustomerName);
        //        updatestatement = updatestatement.Set("Address", customer.Address);
        //        //fetch the details from CustomerDB based on id and pass into view  
        //        var result = mongoDatabase.GetCollection<Score>("TargetScores").UpdateOne(filter, updatestatement);
        //        if (result.IsAcknowledged == false)
        //        {
        //            return BadRequest("Unable to update Customer  " + customer.CustomerName);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }

        //    return RedirectToAction("Index");
        //}

        //[HttpGet]
        //public IActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }
        //    //Get the database connection  
        //    mongoDatabase = GetMongoDatabase();
        //    //fetch the details from CustomerDB and pass into view  
        //    Customer customer = mongoDatabase.GetCollection<Score>("TargetScores").Find<Score>(k => k.CustomerId == id).FirstOrDefault();
        //    if (customer == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(customer);
        //}

        //public IActionResult About()
        //{
        //    ViewData["Message"] = "Your application description page.";

        //    return View();
        //}

        //public IActionResult Contact()
        //{
        //    ViewData["Message"] = "Your contact page.";

        //    return View();
        //}

        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}