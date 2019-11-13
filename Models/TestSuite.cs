using System;
using System.Collections.Generic;

namespace NetPcl.Models
{
    public class TestSuite {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }

        public List<TestSheet> Sheets { get; set; } = new List<TestSheet>();
    }
}