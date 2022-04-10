using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// using MongoDB.Bson;
// using MongoDB.Driver;

using FGWebsite.Schemas;

namespace FGWebsite.Controllers
{
    [ApiController]
    [Route("api")] // Sets the url end point - i.e. [controller] sets to the default, but you could have it be "myurl"
    public class APIController : ControllerBase
    {

        // private readonly ILogger<APIController> _logger;

        // public APIController(ILogger<APIController> logger)
        // {
        //     _logger = logger;
        // }

        // [HttpGet]
        // public IEnumerable<APIController> Get()
        // {
        //     return new IEnumerable<APIController>[];
        // }

        [HttpGet]
        public string Get()
        {
            return Environment.GetEnvironmentVariable("MONGODB_URI");
        }
 
        [HttpGet ("test")] /// When this url is accessed, it will run the following function
        public ActionResult<IEnumerable<myClass>> getThings() // just the name of the function, can be named anything
        {
            return new []
            {
                new myClass {Something = "1"},
                new myClass {Something = "2"},
                new myClass {Something = "3"},
            };
        }

        [HttpGet ("mongo")] /// When this url is accessed, it will run the following function
        public string getURI() 
        {
            var value =  Environment.GetEnvironmentVariable("MONGODB_URI");
            if(value != null){
                return value;
            } else {
                return "No URI found";
            }
            // return "Test";
        }

        // [HttpGet ("env")]
        // public IEnumerable<variables> getEnv()
        // {
        //     IEnumerable<variables> vari = new IEnumerable<variables>();
        //     foreach(var env in Environment.GetEnvironmentVariables()){
        //         vari.add(env.Key, env.Value);
        //     }
        //     return vari;
        // }

        [HttpGet ("db/users")] /** api/db/users **/
        public ActionResult<IEnumerable<Users>> GetUsers()
        {
            return new Users[]{};
        }

    }

    public class myClass {
        public string Something { get; set; }
    }

    public class variables {
        public string key {get;set;}
        public string value {get;set;}
    }

}
