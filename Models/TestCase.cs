using System;
using System.Collections.Generic;

namespace NetPcl.Models
{
    public class TestCase : DbObject 
    {
        public string Name {get;set;}
        public List<Tuple<Factor, Level>> Checks { get; set; } = new List<Tuple<Factor, Level>>();
    }
}