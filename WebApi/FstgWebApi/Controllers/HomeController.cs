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
    /// <summary>
    /// Home Controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        /// <summary>
        /// Just returns an Ok Result
        /// </summary>
        /// <returns>IActionResult</returns>
        [HttpGet]
        public IActionResult Index()
        {
            var output = StatusCode((int)HttpStatusCode.OK, "Fun Sports Training Games API is running.");
            return output;
        }
    }
}