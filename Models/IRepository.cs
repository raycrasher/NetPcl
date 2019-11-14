using System;
using System.Collections.Generic;

namespace NetPcl.Models
{
    public interface IRepository
    {
        IEnumerable<Factor> SearchFactors(string term);
        void SaveFactor(Factor factor);
        void SaveSheet(TestSheet sheet);
        void SaveSuite(TestSuite suite);
        TestSuite GetSuite(int id);
        IEnumerable<TestSuite> GetSuites(int numItemsPerPage, int page);
        TestSheet GetSheet(int id);
    }

}