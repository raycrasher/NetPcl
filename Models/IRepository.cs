using System;
using System.Collections.Generic;

namespace NetPcl.Models
{
    public interface IRepository
    {
        IEnumerable<Factor> SearchFactors(string term);
        void SaveFactor(Factor factor);

    }
}