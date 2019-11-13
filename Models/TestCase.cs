using System;
using System.Collections.Generic;

namespace NetPcl.Models
{
    public class TestCase {
        public int Id {get;set;}
        public string Name {get;set;}
        public List<Tuple<Factor, Level>> Checks { get; set; } = new List<Tuple<Factor, Level>>();
    }
}