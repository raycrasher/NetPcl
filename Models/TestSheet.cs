using System;
using System.Collections.Generic;

namespace NetPcl.Models
{
    public class TestSheet : DbObject{
        public string Name { get; set; }

        public List<Factor> Factors {get;set;} = new List<Factor>();
        public List<TestCase> TestCases { get; set; } = new List<TestCase>();
    }
}