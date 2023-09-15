using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleHierarchies.Interfaces.Data.Mammals
{
    public interface IBengalTiger : IMammal
    {
        bool ApexPredator { get; set; }
        float LargeSize { get; set; }
        string CamouflageFur { get; set; }
        bool PowerfulLegs { get; set; }
        bool SolitaryBehavior { get; set; }
    }
}
