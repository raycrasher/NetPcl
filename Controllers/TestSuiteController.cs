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

        private readonly ILogger<TestSuiteController> _logger;
        private readonly IRepository _repo;

        public TestSuiteController(ILogger<TestSuiteController> logger, IRepository repo)
        {
            _logger = logger;
            _repo=repo;
        }

        [Route("/api/pcl")]
        [HttpPost]
        public Result<int> SavePcl(TestSuite data)
        {
            _repo.SaveSuite(data);
            return new Result<int>(data.Id);
        }

        [Route("/api/pcl/{id}")]
        [HttpGet]
        public Result<TestSuite> GetPcl(int id)
        {
            var data=_repo.GetSuite(id);
            if(data==null)
                return new Result<TestSuite>(false, "Cannot find test suite", null);
            else
                return new Result<TestSuite>(data);
        }

        [Route("/api/sheet")]
        [HttpPost]
        public Result<int> SaveSheet(TestSheet sheet){
            _repo.SaveSheet(sheet);
            return new Result<int>(sheet.Id);
        }

        [Route("/api/sheet/{id}")]
        [HttpGet]
        public Result<TestSheet> GetSheet(int id)
        {
            var data=_repo.GetSheet(id);
            if(data==null)
                return new Result<TestSheet>(false, "Cannot find test suite", null);
            else
                return new Result<TestSheet>(data);
        }
    }
}
