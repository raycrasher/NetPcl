using System;
using System.Collections.Generic;

namespace NetPcl 
{
    public class PclSuite {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }

        public List<PclSheet> Sheets { get; set; } = new List<PclSheet>();
    }
}