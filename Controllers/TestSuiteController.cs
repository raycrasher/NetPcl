using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetPcl.Models;

namespace NetPcl.Controllers
{
    [ApiController]
    public class TestSuiteController : ControllerBase
    {
        //Todo: database
        static Dictionary<int, Models.TestSuite> suitesTemp = new Dictionary<int, Models.TestSuite>();
        static int nextId = 1;

        private readonly ILogger<TestSuiteController> _logger;

        public TestSuiteController(ILogger<TestSuiteController> logger)
        {
            _logger = logger;
        }

        public class CreatePclPostData
        {
            public string Name { get; set; }
            public string Description { get; set; }
        }

        [Route("/api/pcl")]
        [HttpPost]
        public Result<int> Post(CreatePclPostData data)
        {
            suitesTemp[nextId] = new Models.TestSuite { Id = nextId, Name = data.Name, Author = "", Sheets = new List<Models.TestSheet>() };
            //Todo
            var id=nextId;
            nextId++;
            return new Result<int>(id);
        }

        [Route("/api/pcl/{id}")]
        [HttpGet]
        public Result<TestSuite> GetPcl(int id)
        {
            if (suitesTemp.TryGetValue(id, out var suite))
                return new Result<TestSuite>(suite);
            else return new Result<TestSuite>(false, "Cannot find test suite", null);
        }
    }
}
