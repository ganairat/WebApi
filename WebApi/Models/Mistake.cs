using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class Mistake
    {
        public Mistake() { }
        public string persentageInitializedVariables { get; set; }
        public string persentageGoodFormedMethods { get; set; }
        public string goodNamedClasses { get; set; }
        public string goodTabulatedLines { get; set; }
        public string goodDifferedClasses { get; set; }
        public string goodIfStatement { get; set; }
        public string percentageUnusedVariables { get; set; }
        public string percentageUnusedFields { get; set; }
    }
}