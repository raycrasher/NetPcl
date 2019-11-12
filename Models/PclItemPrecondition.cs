using System;
using System.Collections.Generic;

namespace NetPcl 
{
    public class PclItemPrecondition {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<PclItemPrecondition> Prerequisites {get;set;} = new List<PclItemPrecondition>();

    }
}