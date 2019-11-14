using System;
using System.Collections.Generic;

namespace NetPcl.Models
{
    public class TestSuite : DbObject{
        public string Name { get; set; }
        public string Author { get; set; }

        public List<TestSheet> Sheets { get; set; } = new List<TestSheet>();
    }
}